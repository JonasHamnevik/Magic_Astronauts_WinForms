namespace Magic_Astronauts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveBtn = new System.Windows.Forms.Button();
            this.load_Btn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            this.tempDataGridViewTextBoxColumn.Width = 125;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.Width = 125;
            // 
            // Browse_btn
            // 
            this.Browse_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Browse_btn.Location = new System.Drawing.Point(303, 12);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(140, 39);
            this.Browse_btn.TabIndex = 1;
            this.Browse_btn.Text = "Browse";
            this.Browse_btn.UseVisualStyleBackColor = true;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(464, 20);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(415, 27);
            this.txtFileName.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(739, 710);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 39);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // load_Btn
            // 
            this.load_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_Btn.Location = new System.Drawing.Point(303, 710);
            this.load_Btn.Name = "load_Btn";
            this.load_Btn.Size = new System.Drawing.Size(140, 39);
            this.load_Btn.TabIndex = 8;
            this.load_Btn.Text = "Load";
            this.load_Btn.UseVisualStyleBackColor = true;
            this.load_Btn.Click += new System.EventHandler(this.load_Btn_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Magic_Astronauts.Core.Weather);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.locationDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn1,
            this.humidityDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(303, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(576, 647);
            this.dataGridView1.TabIndex = 9;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempDataGridViewTextBoxColumn1
            // 
            this.tempDataGridViewTextBoxColumn1.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn1.HeaderText = "Temp";
            this.tempDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tempDataGridViewTextBoxColumn1.Name = "tempDataGridViewTextBoxColumn1";
            this.tempDataGridViewTextBoxColumn1.Width = 125;
            // 
            // humidityDataGridViewTextBoxColumn1
            // 
            this.humidityDataGridViewTextBoxColumn1.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn1.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.humidityDataGridViewTextBoxColumn1.Name = "humidityDataGridViewTextBoxColumn1";
            this.humidityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // clear_Btn
            // 
            this.clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear_Btn.Location = new System.Drawing.Point(523, 710);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(140, 39);
            this.clear_Btn.TabIndex = 10;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 763);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.load_Btn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Browse_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Browse_btn;
        private TextBox txtFileName;
        private OpenFileDialog openFileDialog1;
        private BindingSource weatherBindingSource;
        private Button saveBtn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private Button load_Btn;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn1;
        private Button clear_Btn;
        private Panel panel1;
    }
}