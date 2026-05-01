namespace BnA
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.confirmPassReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginReg = new System.Windows.Forms.Button();
            this.showPassReg = new System.Windows.Forms.CheckBox();
            this.signup = new System.Windows.Forms.Button();
            this.passReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmPassReg
            // 
            this.confirmPassReg.Location = new System.Drawing.Point(535, 127);
            this.confirmPassReg.Multiline = true;
            this.confirmPassReg.Name = "confirmPassReg";
            this.confirmPassReg.PasswordChar = '*';
            this.confirmPassReg.Size = new System.Drawing.Size(212, 27);
            this.confirmPassReg.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(428, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Confirm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Already have an account?";
            // 
            // loginReg
            // 
            this.loginReg.BackColor = System.Drawing.Color.Moccasin;
            this.loginReg.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginReg.Location = new System.Drawing.Point(457, 266);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(259, 32);
            this.loginReg.TabIndex = 26;
            this.loginReg.Text = "Login";
            this.loginReg.UseVisualStyleBackColor = false;
            this.loginReg.Click += new System.EventHandler(this.loginReg_Click);
            // 
            // showPassReg
            // 
            this.showPassReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.showPassReg.AutoSize = true;
            this.showPassReg.BackColor = System.Drawing.Color.Transparent;
            this.showPassReg.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showPassReg.Location = new System.Drawing.Point(535, 160);
            this.showPassReg.Name = "showPassReg";
            this.showPassReg.Size = new System.Drawing.Size(144, 19);
            this.showPassReg.TabIndex = 25;
            this.showPassReg.Text = "Show password";
            this.showPassReg.UseVisualStyleBackColor = false;
            this.showPassReg.CheckedChanged += new System.EventHandler(this.showPassReg_CheckedChanged);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Moccasin;
            this.signup.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(457, 194);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(259, 32);
            this.signup.TabIndex = 24;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // passReg
            // 
            this.passReg.Location = new System.Drawing.Point(535, 94);
            this.passReg.Multiline = true;
            this.passReg.Name = "passReg";
            this.passReg.PasswordChar = '*';
            this.passReg.Size = new System.Drawing.Size(212, 27);
            this.passReg.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(415, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password:";
            // 
            // userReg
            // 
            this.userReg.Location = new System.Drawing.Point(535, 61);
            this.userReg.Multiline = true;
            this.userReg.Name = "userReg";
            this.userReg.Size = new System.Drawing.Size(212, 27);
            this.userReg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(415, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username:";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exit.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(771, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 15);
            this.exit.TabIndex = 30;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.confirmPassReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginReg);
            this.Controls.Add(this.showPassReg);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.passReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userReg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confirmPassReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginReg;
        private System.Windows.Forms.CheckBox showPassReg;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox passReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
    }
}