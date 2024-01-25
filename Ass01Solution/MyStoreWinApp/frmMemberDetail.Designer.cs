namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassWord = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtCountry = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "MemberID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "MenberName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 263);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "PassWord:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 341);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 425);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Country:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(256, 44);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(246, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(256, 112);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(246, 27);
            txtMemberName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(256, 188);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(246, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new System.Drawing.Point(256, 263);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new System.Drawing.Size(246, 27);
            txtPassWord.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(256, 334);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(246, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(256, 418);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(246, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(178, 492);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(350, 494);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(591, 558);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassWord);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
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
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}