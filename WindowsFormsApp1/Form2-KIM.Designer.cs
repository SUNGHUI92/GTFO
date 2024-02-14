namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.sch_btn = new System.Windows.Forms.Button();
            this.first_time = new System.Windows.Forms.DateTimePicker();
            this.search_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last_time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1224, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 54;
            this.label3.Text = "항목";
            // 
            // sch_btn
            // 
            this.sch_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.sch_btn.Location = new System.Drawing.Point(1704, 47);
            this.sch_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sch_btn.Name = "sch_btn";
            this.sch_btn.Size = new System.Drawing.Size(146, 42);
            this.sch_btn.TabIndex = 52;
            this.sch_btn.Text = "검색";
            this.sch_btn.UseVisualStyleBackColor = true;
            // 
            // first_time
            // 
            this.first_time.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.first_time.Location = new System.Drawing.Point(233, 47);
            this.first_time.Margin = new System.Windows.Forms.Padding(2);
            this.first_time.Name = "first_time";
            this.first_time.Size = new System.Drawing.Size(426, 42);
            this.first_time.TabIndex = 49;
            // 
            // search_combobox
            // 
            this.search_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_combobox.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_combobox.FormattingEnabled = true;
            this.search_combobox.Items.AddRange(new object[] {
            "제조업체",
            "보관위치",
            "유통기한"});
            this.search_combobox.Location = new System.Drawing.Point(1320, 47);
            this.search_combobox.Margin = new System.Windows.Forms.Padding(0);
            this.search_combobox.Name = "search_combobox";
            this.search_combobox.Size = new System.Drawing.Size(288, 42);
            this.search_combobox.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(663, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 38);
            this.label1.TabIndex = 51;
            this.label1.Text = "~";
            // 
            // last_time
            // 
            this.last_time.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.last_time.Location = new System.Drawing.Point(714, 47);
            this.last_time.Margin = new System.Windows.Forms.Padding(2);
            this.last_time.Name = "last_time";
            this.last_time.Size = new System.Drawing.Size(426, 42);
            this.last_time.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "기간검색";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.importDate,
            this.lotNumber,
            this.materialId,
            this.materialName,
            this.company,
            this.productType,
            this.etc});
            this.dataGridView1.Location = new System.Drawing.Point(22, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1994, 1244);
            this.dataGridView1.TabIndex = 55;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 10;
            this.No.Name = "No";
            // 
            // importDate
            // 
            this.importDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importDate.HeaderText = "보관위치";
            this.importDate.MinimumWidth = 10;
            this.importDate.Name = "importDate";
            // 
            // lotNumber
            // 
            this.lotNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lotNumber.HeaderText = "입고일";
            this.lotNumber.MinimumWidth = 10;
            this.lotNumber.Name = "lotNumber";
            // 
            // materialId
            // 
            this.materialId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialId.HeaderText = "유통기한";
            this.materialId.MinimumWidth = 10;
            this.materialId.Name = "materialId";
            // 
            // materialName
            // 
            this.materialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialName.HeaderText = "상품코드";
            this.materialName.MinimumWidth = 10;
            this.materialName.Name = "materialName";
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.HeaderText = "제조업체";
            this.company.MinimumWidth = 10;
            this.company.Name = "company";
            // 
            // productType
            // 
            this.productType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productType.HeaderText = "품명";
            this.productType.MinimumWidth = 10;
            this.productType.Name = "productType";
            // 
            // etc
            // 
            this.etc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etc.HeaderText = "검사결과";
            this.etc.MinimumWidth = 10;
            this.etc.Name = "etc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10F);
            this.button1.Location = new System.Drawing.Point(1870, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 56;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2050, 1400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sch_btn);
            this.Controls.Add(this.first_time);
            this.Controls.Add(this.search_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_time);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sch_btn;
        private System.Windows.Forms.DateTimePicker first_time;
        private System.Windows.Forms.ComboBox search_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker last_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn importDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn etc;
        private System.Windows.Forms.Button button1;
    }
}