/*
 * Created by SharpDevelop.
 * User: suvoroda
 * Date: 22.03.2015
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MDBReader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.BindingDBSource = new System.Windows.Forms.BindingSource(this.components);
			this.DataSetDB = new System.Data.DataSet();
			this.OpenDb = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.DBTable = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.OpenDBFile = new System.Windows.Forms.Button();
			this.ListTables = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.BindingDBSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSetDB)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DBTable)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BindingDBSource
			// 
			this.BindingDBSource.DataSource = this.DataSetDB;
			this.BindingDBSource.Position = 0;
			// 
			// DataSetDB
			// 
			this.DataSetDB.DataSetName = "NewDataSet";
			// 
			// OpenDb
			// 
			this.OpenDb.FileName = "openFileDialog1";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Controls.Add(this.DBTable, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 527);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// DBTable
			// 
			this.DBTable.AutoGenerateColumns = false;
			this.DBTable.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.DBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DBTable.DataSource = this.BindingDBSource;
			this.DBTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DBTable.GridColor = System.Drawing.SystemColors.HotTrack;
			this.DBTable.Location = new System.Drawing.Point(3, 39);
			this.DBTable.Name = "DBTable";
			this.DBTable.Size = new System.Drawing.Size(540, 485);
			this.DBTable.TabIndex = 13;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.OpenDBFile);
			this.panel1.Controls.Add(this.ListTables);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(540, 30);
			this.panel1.TabIndex = 12;
			// 
			// OpenDBFile
			// 
			this.OpenDBFile.ForeColor = System.Drawing.SystemColors.Highlight;
			this.OpenDBFile.Location = new System.Drawing.Point(458, 1);
			this.OpenDBFile.Name = "OpenDBFile";
			this.OpenDBFile.Size = new System.Drawing.Size(75, 23);
			this.OpenDBFile.TabIndex = 11;
			this.OpenDBFile.Text = "Открыть";
			this.OpenDBFile.UseVisualStyleBackColor = true;
			this.OpenDBFile.Click += new System.EventHandler(this.OpenDBFileClick);
			// 
			// ListTables
			// 
			this.ListTables.BackColor = System.Drawing.SystemColors.Desktop;
			this.ListTables.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.ListTables.FormattingEnabled = true;
			this.ListTables.Location = new System.Drawing.Point(3, 3);
			this.ListTables.Name = "ListTables";
			this.ListTables.Size = new System.Drawing.Size(449, 21);
			this.ListTables.TabIndex = 9;
			this.ListTables.SelectedIndexChanged += new System.EventHandler(this.ListTablesSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(546, 527);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "MDBReader";
			((System.ComponentModel.ISupportInitialize)(this.BindingDBSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSetDB)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DBTable)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button OpenDBFile;
		private System.Windows.Forms.OpenFileDialog OpenDb;
		private System.Windows.Forms.DataGridView DBTable;
		private System.Data.DataSet DataSetDB;
		private System.Windows.Forms.BindingSource BindingDBSource;
		private System.Windows.Forms.ComboBox ListTables;
	}
}
