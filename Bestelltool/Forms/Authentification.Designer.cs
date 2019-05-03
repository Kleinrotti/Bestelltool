namespace Bestelltool
{
    partial class Authentification
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_headline = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_loading = new System.Windows.Forms.Label();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(292, 282);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(201, 26);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(292, 352);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(201, 26);
            this.textBox_password.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(323, 208);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(146, 33);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Anmelden";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(135, 282);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(151, 25);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Benutzername";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(186, 352);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(100, 25);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Passwort";
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.White;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_enter.Location = new System.Drawing.Point(292, 422);
            this.button_enter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(201, 78);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "Anmelden";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Location = new System.Drawing.Point(0, -1);
            this.panel_top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(791, 51);
            this.panel_top.TabIndex = 6;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(714, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(78, 51);
            this.button_exit.TabIndex = 19;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(14, 75);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(304, 55);
            this.label_headline.TabIndex = 7;
            this.label_headline.Text = "Bestellsoftware";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(18, 132);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(128, 29);
            this.label_version.TabIndex = 8;
            this.label_version.Text = "Version: 2.1";
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.BackColor = System.Drawing.Color.Transparent;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(354, 192);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(98, 29);
            this.label_loading.TabIndex = 9;
            this.label_loading.Text = "Laden...";
            this.label_loading.Visible = false;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_loading.Image = global::Bestelltool.Properties.Resources.loading;
            this.pictureBox_loading.Location = new System.Drawing.Point(514, 208);
            this.pictureBox_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(276, 282);
            this.pictureBox_loading.TabIndex = 10;
            this.pictureBox_loading.TabStop = false;
            this.pictureBox_loading.Visible = false;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 529);
            this.Controls.Add(this.pictureBox_loading);
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authentification_FormClosing);
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authentification_KeyDown);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.PictureBox pictureBox_loading;
    }
}