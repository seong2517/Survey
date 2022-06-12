namespace Survey
{
  partial class Chart
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.pieChart1 = new LiveCharts.WinForms.PieChart();
      this.dataDataSet = new Survey.DataDataSet();
      this.q1TableAdapter = new Survey.DataDataSetTableAdapters.Q1TableAdapter();
      this.dataDataSet1 = new Survey.DataDataSet1();
      this.q1BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.q1TableAdapter1 = new Survey.DataDataSet1TableAdapters.Q1TableAdapter();
      this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aNSWERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.q1BindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(-5, 1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(810, 485);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.pieChart1);
      this.tabPage1.Controls.Add(this.dataGridView1);
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(802, 459);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(802, 459);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(649, 228);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.aNSWERDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.q1BindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(484, 72);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(240, 150);
      this.dataGridView1.TabIndex = 1;
      // 
      // pieChart1
      // 
      this.pieChart1.Location = new System.Drawing.Point(83, 96);
      this.pieChart1.Name = "pieChart1";
      this.pieChart1.Size = new System.Drawing.Size(369, 335);
      this.pieChart1.TabIndex = 2;
      this.pieChart1.Text = "pieChart1";
      // 
      // dataDataSet
      // 
      this.dataDataSet.DataSetName = "DataDataSet";
      this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // q1TableAdapter
      // 
      this.q1TableAdapter.ClearBeforeFill = true;
      // 
      // dataDataSet1
      // 
      this.dataDataSet1.DataSetName = "DataDataSet1";
      this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // q1BindingSource
      // 
      this.q1BindingSource.DataMember = "Q1";
      this.q1BindingSource.DataSource = this.dataDataSet1;
      // 
      // q1TableAdapter1
      // 
      this.q1TableAdapter1.ClearBeforeFill = true;
      // 
      // uSERNAMEDataGridViewTextBoxColumn
      // 
      this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
      this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
      this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
      // 
      // aNSWERDataGridViewTextBoxColumn
      // 
      this.aNSWERDataGridViewTextBoxColumn.DataPropertyName = "ANSWER";
      this.aNSWERDataGridViewTextBoxColumn.HeaderText = "ANSWER";
      this.aNSWERDataGridViewTextBoxColumn.Name = "aNSWERDataGridViewTextBoxColumn";
      // 
      // Chart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 481);
      this.Controls.Add(this.tabControl1);
      this.Name = "Chart";
      this.Text = "Chart";
      this.Load += new System.EventHandler(this.Chart_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.q1BindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private LiveCharts.WinForms.PieChart pieChart1;
    private DataDataSet dataDataSet;
    private DataDataSetTableAdapters.Q1TableAdapter q1TableAdapter;
    private DataDataSet1 dataDataSet1;
    private System.Windows.Forms.BindingSource q1BindingSource;
    private DataDataSet1TableAdapters.Q1TableAdapter q1TableAdapter1;
    private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn aNSWERDataGridViewTextBoxColumn;
  }
}