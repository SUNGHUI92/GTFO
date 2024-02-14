namespace WindowsFormsApp1
{
    partial class Form16
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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButtonPanel = new System.Windows.Forms.Panel();
            this.pd_dele_cancle_btn = new System.Windows.Forms.Button();
            this.pd_dele_alram_btn = new System.Windows.Forms.Button();
            this.DataGridUserInformation = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxAuthority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pd_sch_delet_select_btn = new System.Windows.Forms.Button();
            this.pd_sch_popup_btn = new System.Windows.Forms.Button();
            this.pd_sch_btn = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ComboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.deleteButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUserInformation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButtonPanel
            // 
            this.deleteButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteButtonPanel.Controls.Add(this.pd_dele_cancle_btn);
            this.deleteButtonPanel.Controls.Add(this.pd_dele_alram_btn);
            this.deleteButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteButtonPanel.Location = new System.Drawing.Point(0, 690);
            this.deleteButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButtonPanel.Name = "deleteButtonPanel";
            this.deleteButtonPanel.Size = new System.Drawing.Size(1400, 50);
            this.deleteButtonPanel.TabIndex = 50;
            this.deleteButtonPanel.Visible = false;
            // 
            // pd_dele_cancle_btn
            // 
            this.pd_dele_cancle_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pd_dele_cancle_btn.Location = new System.Drawing.Point(710, 11);
            this.pd_dele_cancle_btn.Name = "pd_dele_cancle_btn";
            this.pd_dele_cancle_btn.Size = new System.Drawing.Size(77, 30);
            this.pd_dele_cancle_btn.TabIndex = 21;
            this.pd_dele_cancle_btn.Text = "취소";
            this.pd_dele_cancle_btn.UseVisualStyleBackColor = true;
            // 
            // pd_dele_alram_btn
            // 
            this.pd_dele_alram_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pd_dele_alram_btn.Location = new System.Drawing.Point(604, 11);
            this.pd_dele_alram_btn.Name = "pd_dele_alram_btn";
            this.pd_dele_alram_btn.Size = new System.Drawing.Size(77, 30);
            this.pd_dele_alram_btn.TabIndex = 20;
            this.pd_dele_alram_btn.Text = "확인";
            this.pd_dele_alram_btn.UseVisualStyleBackColor = true;
            // 
            // DataGridUserInformation
            // 
            this.DataGridUserInformation.AllowUserToAddRows = false;
            this.DataGridUserInformation.AllowUserToDeleteRows = false;
            this.DataGridUserInformation.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUserInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUserInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridUserInformation.Location = new System.Drawing.Point(0, 50);
            this.DataGridUserInformation.Name = "DataGridUserInformation";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUserInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridUserInformation.RowHeadersWidth = 82;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridUserInformation.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridUserInformation.RowTemplate.Height = 23;
            this.DataGridUserInformation.Size = new System.Drawing.Size(1400, 690);
            this.DataGridUserInformation.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ComboBoxAuthority);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ComboBoxPosition);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pd_sch_delet_select_btn);
            this.panel2.Controls.Add(this.pd_sch_popup_btn);
            this.panel2.Controls.Add(this.pd_sch_btn);
            this.panel2.Controls.Add(this.TextBoxName);
            this.panel2.Controls.Add(this.ComboBoxDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 50);
            this.panel2.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(435, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "권한";
            // 
            // ComboBoxAuthority
            // 
            this.ComboBoxAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAuthority.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBoxAuthority.FormattingEnabled = true;
            this.ComboBoxAuthority.Location = new System.Drawing.Point(486, 8);
            this.ComboBoxAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxAuthority.Name = "ComboBoxAuthority";
            this.ComboBoxAuthority.Size = new System.Drawing.Size(135, 42);
            this.ComboBoxAuthority.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(229, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "직책";
            // 
            // ComboBoxPosition
            // 
            this.ComboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPosition.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBoxPosition.FormattingEnabled = true;
            this.ComboBoxPosition.Location = new System.Drawing.Point(280, 8);
            this.ComboBoxPosition.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxPosition.Name = "ComboBoxPosition";
            this.ComboBoxPosition.Size = new System.Drawing.Size(135, 42);
            this.ComboBoxPosition.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "소속";
            // 
            // pd_sch_delet_select_btn
            // 
            this.pd_sch_delet_select_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.pd_sch_delet_select_btn.Location = new System.Drawing.Point(1293, 8);
            this.pd_sch_delet_select_btn.Name = "pd_sch_delet_select_btn";
            this.pd_sch_delet_select_btn.Size = new System.Drawing.Size(50, 27);
            this.pd_sch_delet_select_btn.TabIndex = 39;
            this.pd_sch_delet_select_btn.Text = "삭제";
            this.pd_sch_delet_select_btn.UseVisualStyleBackColor = true;
            // 
            // pd_sch_popup_btn
            // 
            this.pd_sch_popup_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.pd_sch_popup_btn.Location = new System.Drawing.Point(1237, 8);
            this.pd_sch_popup_btn.Name = "pd_sch_popup_btn";
            this.pd_sch_popup_btn.Size = new System.Drawing.Size(50, 27);
            this.pd_sch_popup_btn.TabIndex = 38;
            this.pd_sch_popup_btn.Text = "등록";
            this.pd_sch_popup_btn.UseVisualStyleBackColor = true;
            // 
            // pd_sch_btn
            // 
            this.pd_sch_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.pd_sch_btn.Location = new System.Drawing.Point(1028, 7);
            this.pd_sch_btn.Name = "pd_sch_btn";
            this.pd_sch_btn.Size = new System.Drawing.Size(50, 27);
            this.pd_sch_btn.TabIndex = 37;
            this.pd_sch_btn.Text = "검색";
            this.pd_sch_btn.UseVisualStyleBackColor = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBoxName.Location = new System.Drawing.Point(650, 7);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(366, 44);
            this.TextBoxName.TabIndex = 36;
            // 
            // ComboBoxDepartment
            // 
            this.ComboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDepartment.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBoxDepartment.FormattingEnabled = true;
            this.ComboBoxDepartment.Location = new System.Drawing.Point(76, 8);
            this.ComboBoxDepartment.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxDepartment.Name = "ComboBoxDepartment";
            this.ComboBoxDepartment.Size = new System.Drawing.Size(135, 42);
            this.ComboBoxDepartment.TabIndex = 40;
            // 
            // Form16
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 740);
            this.Controls.Add(this.deleteButtonPanel);
            this.Controls.Add(this.DataGridUserInformation);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.deleteButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUserInformation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
>>>>>>> 2c4943974f7e009d32315ec622de7451bae59a70
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD
=======

        private System.Windows.Forms.Panel deleteButtonPanel;
        private System.Windows.Forms.Button pd_dele_cancle_btn;
        private System.Windows.Forms.Button pd_dele_alram_btn;
        private System.Windows.Forms.DataGridView DataGridUserInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxAuthority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pd_sch_delet_select_btn;
        private System.Windows.Forms.Button pd_sch_popup_btn;
        private System.Windows.Forms.Button pd_sch_btn;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.ComboBox ComboBoxDepartment;
>>>>>>> 2c4943974f7e009d32315ec622de7451bae59a70
    }
}