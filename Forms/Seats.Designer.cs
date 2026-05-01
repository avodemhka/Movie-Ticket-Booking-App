namespace BnA
{
    partial class Seats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seats));
            this.panelSeats = new System.Windows.Forms.FlowLayoutPanel();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lstSelectedTickets = new System.Windows.Forms.ListBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.groupBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSeats
            // 
            this.panelSeats.BackColor = System.Drawing.Color.Transparent;
            this.panelSeats.Location = new System.Drawing.Point(251, 83);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(501, 315);
            this.panelSeats.TabIndex = 37;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Moccasin;
            this.btnComplete.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComplete.Location = new System.Drawing.Point(610, 405);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(142, 34);
            this.btnComplete.TabIndex = 36;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSummary.Location = new System.Drawing.Point(32, 289);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(201, 112);
            this.txtSummary.TabIndex = 35;
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // lstSelectedTickets
            // 
            this.lstSelectedTickets.FormattingEnabled = true;
            this.lstSelectedTickets.ItemHeight = 16;
            this.lstSelectedTickets.Location = new System.Drawing.Point(32, 167);
            this.lstSelectedTickets.Name = "lstSelectedTickets";
            this.lstSelectedTickets.Size = new System.Drawing.Size(201, 116);
            this.lstSelectedTickets.TabIndex = 34;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTime.Controls.Add(this.rb4);
            this.groupBoxTime.Controls.Add(this.rb3);
            this.groupBoxTime.Controls.Add(this.rb2);
            this.groupBoxTime.Controls.Add(this.rb1);
            this.groupBoxTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxTime.Location = new System.Drawing.Point(32, 83);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(201, 78);
            this.groupBoxTime.TabIndex = 33;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time:";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(105, 45);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(59, 20);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "21:00";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(105, 21);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(59, 20);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "18:30";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(14, 45);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(59, 20);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "15:30";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(14, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(59, 20);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "13:00";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Film";
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Items.AddRange(new object[] {
            "Avatar",
            "Dune",
            "Greatest Showman",
            "Home Alone ",
            "Ice Age ",
            "John Wick",
            "Oppenheimer",
            "The Gray Man",
            "Uncharted"});
            this.cmbFilm.Location = new System.Drawing.Point(32, 53);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(201, 24);
            this.cmbFilm.TabIndex = 31;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(771, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 15);
            this.exit.TabIndex = 38;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(467, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "scene";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Maroon;
            this.back.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(251, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 33);
            this.back.TabIndex = 42;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lstSelectedTickets);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seats";
            this.Load += new System.EventHandler(this.Seats_Load);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSeats;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.ListBox lstSelectedTickets;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button back;
    }
}