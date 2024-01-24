namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassWord = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "MemberID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "MemberName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 222);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(376, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(376, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "PassWord:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(685, 53);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(685, 139);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 20);
            label7.TabIndex = 6;
            label7.Text = "filter:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(763, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(939, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(151, 28);
            comboBox2.TabIndex = 14;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(266, 280);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(94, 29);
            button7.TabIndex = 15;
            button7.Text = "Load";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(511, 280);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(94, 29);
            button8.TabIndex = 16;
            button8.Text = "New";
            button8.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(738, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(996, 44);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(94, 29);
            button10.TabIndex = 18;
            button10.Text = "Submit";
            button10.UseVisualStyleBackColor = true;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(63, 325);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new System.Drawing.Size(1027, 286);
            dgvMemberList.TabIndex = 19;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(152, 44);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(208, 27);
            txtMemberID.TabIndex = 20;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(152, 126);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(208, 27);
            txtMemberName.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(152, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(208, 27);
            txtEmail.TabIndex = 22;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new System.Drawing.Point(457, 46);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new System.Drawing.Size(208, 27);
            txtPassWord.TabIndex = 23;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(457, 132);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(208, 27);
            txtCity.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(763, 44);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(208, 27);
            textBox6.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(376, 218);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 20);
            label8.TabIndex = 26;
            label8.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(457, 215);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(208, 27);
            txtCountry.TabIndex = 27;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1146, 637);
            Controls.Add(txtCountry);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(txtCity);
            Controls.Add(txtPassWord);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(dgvMemberList);
            Controls.Add(button10);
            Controls.Add(btnDelete);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountry;
    }
}