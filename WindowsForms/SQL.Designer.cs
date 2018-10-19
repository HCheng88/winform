namespace WindowsForms
{
    partial class SQL
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Psw = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Psw = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(179, 87);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 21);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Psw
            // 
            this.textBox_Psw.Location = new System.Drawing.Point(179, 129);
            this.textBox_Psw.Name = "textBox_Psw";
            this.textBox_Psw.Size = new System.Drawing.Size(100, 21);
            this.textBox_Psw.TabIndex = 1;
            this.textBox_Psw.UseSystemPasswordChar = true;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(132, 90);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 12);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "用户名";
            // 
            // label_Psw
            // 
            this.label_Psw.AutoSize = true;
            this.label_Psw.Location = new System.Drawing.Point(144, 132);
            this.label_Psw.Name = "label_Psw";
            this.label_Psw.Size = new System.Drawing.Size(29, 12);
            this.label_Psw.TabIndex = 3;
            this.label_Psw.Text = "密码";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(112, 172);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(225, 172);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "增加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(112, 215);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(75, 23);
            this.button_Set.TabIndex = 0;
            this.button_Set.Text = "修改";
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "编号";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 7;
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(225, 215);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(75, 23);
            this.button_Del.TabIndex = 8;
            this.button_Del.Text = "删除";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 292);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Psw);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Psw);
            this.Controls.Add(this.textBox_Name);
            this.Name = "SQL";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Psw;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Psw;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Del;
    }
}