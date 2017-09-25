/*
 * Created by SharpDevelop.
 * User: suvoroda
 * Date: 22.03.2015
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace MDBReader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=";		
		static string sFilePN = "";
		OleDbDataAdapter odbAdapter = new OleDbDataAdapter();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDataGridView();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		/*Инициализация DGV*/
		private void InitializeDataGridView()
	    {
	        // Automatically generate the DataGridView columns.
	        DBTable.AutoGenerateColumns = true;
	
	        // Automatically resize the visible rows.
	        DBTable.AutoSizeRowsMode =
	            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
	
	        // Set the DataGridView control's border.
	        DBTable.BorderStyle = BorderStyle.Fixed3D;
	
	        // Put the cells in edit mode when user enters them.
	        DBTable.EditMode = DataGridViewEditMode.EditOnEnter;
	    }	
		
		void OpenDBFileClick(object sender, EventArgs e)
		{
			int iCntTab = 0;
			Stream myStream = null;
			if(OpenDb.ShowDialog() == DialogResult.OK)
		    {
		        try
		        {
		            if ((myStream = OpenDb.OpenFile()) != null)
		            {
		                using (myStream)
		                {		                    
		                	sFilePN = OpenDb.FileName;
		                }
		            }
		        }
		        catch (Exception ex)
		        {
		        	MessageBox.Show(String.Format("Ошибка чтения файла. Ошибка: {0}", ex.Message));
		        }
		        
		        ListTables.Items.Clear();	
				
				try
				{					
					OleDbConnection odbc = new OleDbConnection(connectionString + sFilePN);
					odbc.Open();
					
					DataTable dt = odbc.GetSchema("Tables", new String[] {null,null,null,"TABLE"});
					foreach (DataRow dr in dt.Rows)
					{
						string TbName = dr["TABLE_NAME"].ToString();
						ListTables.Items.Add(TbName);
						OleDbCommand odbCommand = new OleDbCommand("Select * from ["+ListTables.Items[iCntTab++].ToString()+"]", new OleDbConnection(connectionString + sFilePN));
						odbAdapter.SelectCommand = odbCommand;
						odbAdapter.Fill(DataSetDB, TbName);					
					}
					ListTables.SelectedIndex = 0;
					
					odbc.Close();
				}
				catch(SqlException sqlEx)
				{
					MessageBox.Show(String.Format("Ошибка запроса к {0}. Ошибка: {1}", sFilePN, sqlEx.ToString()));
				}
				catch(Exception Ex)
				{
					MessageBox.Show(String.Format("Ошибка: {0}", Ex.ToString()));
				}
				
					     	
				
			}
		}
		
		void ListTablesSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				BindingDBSource.DataSource = DataSetDB.Tables[ListTables.SelectedIndex];
				DBTable.DataSource = BindingDBSource;
			}
			catch(Exception ex)
			{
				MessageBox.Show(String.Format("Ошибка вывода данных : {0}", ex.ToString()));
			}
		}
	}
}
