namespace AppForEventРandler
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Probe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.multiplePasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.focusOnSpotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jumpToSpotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.SpotNo,
            this.Description,
            this.Remarks,
            this.Probe,
            this.UPR,
            this.SWD});
			this.dataGridView1.Location = new System.Drawing.Point(128, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(672, 437);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
			// 
			// No
			// 
			this.No.HeaderText = "No.";
			this.No.Name = "No";
			// 
			// SpotNo
			// 
			this.SpotNo.HeaderText = "SpotNo.";
			this.SpotNo.Name = "SpotNo";
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			// 
			// Remarks
			// 
			this.Remarks.HeaderText = "Remarks";
			this.Remarks.Name = "Remarks";
			// 
			// Probe
			// 
			this.Probe.HeaderText = "Probe";
			this.Probe.Name = "Probe";
			// 
			// UPR
			// 
			this.UPR.HeaderText = "UPR";
			this.UPR.Name = "UPR";
			// 
			// SWD
			// 
			this.SWD.HeaderText = "SWD";
			this.SWD.Name = "SWD";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(408, 222);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.clearCellToolStripMenuItem,
            this.pasteCellToolStripMenuItem,
            this.multiplePasteToolStripMenuItem,
            this.findReplaceToolStripMenuItem,
            this.toolStripSeparator1,
            this.focusOnSpotToolStripMenuItem,
            this.jumpToSpotToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 252);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.cutToolStripMenuItem.Text = "Cut";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// clearCellToolStripMenuItem
			// 
			this.clearCellToolStripMenuItem.Name = "clearCellToolStripMenuItem";
			this.clearCellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clearCellToolStripMenuItem.Text = "Clear Cell";
			// 
			// pasteCellToolStripMenuItem
			// 
			this.pasteCellToolStripMenuItem.Name = "pasteCellToolStripMenuItem";
			this.pasteCellToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pasteCellToolStripMenuItem.Text = "Paste Cell";
			// 
			// multiplePasteToolStripMenuItem
			// 
			this.multiplePasteToolStripMenuItem.Name = "multiplePasteToolStripMenuItem";
			this.multiplePasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.multiplePasteToolStripMenuItem.Text = "Multiple Paste";
			// 
			// findReplaceToolStripMenuItem
			// 
			this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
			this.findReplaceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.findReplaceToolStripMenuItem.Text = "Find\\Replace";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// focusOnSpotToolStripMenuItem
			// 
			this.focusOnSpotToolStripMenuItem.Name = "focusOnSpotToolStripMenuItem";
			this.focusOnSpotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.focusOnSpotToolStripMenuItem.Text = "Focus on spot";
			// 
			// jumpToSpotToolStripMenuItem
			// 
			this.jumpToSpotToolStripMenuItem.Name = "jumpToSpotToolStripMenuItem";
			this.jumpToSpotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.jumpToSpotToolStripMenuItem.Text = "Jump to spot";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 461);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn No;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpotNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn Probe;
		private System.Windows.Forms.DataGridViewTextBoxColumn UPR;
		private System.Windows.Forms.DataGridViewTextBoxColumn SWD;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearCellToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteCellToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem multiplePasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findReplaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem focusOnSpotToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jumpToSpotToolStripMenuItem;
	}
}

