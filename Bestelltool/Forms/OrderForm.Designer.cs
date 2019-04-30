namespace Bestelltool
{
    partial class OrderForm
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
            this.richTextBox_notice = new System.Windows.Forms.RichTextBox();
            this.label_anmerkung = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.trackBar_ammount = new System.Windows.Forms.TrackBar();
            this.label_ammount = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_costcentre = new System.Windows.Forms.TextBox();
            this.label_kostenstelle = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ammount)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_notice
            // 
            this.richTextBox_notice.BackColor = System.Drawing.Color.White;
            this.richTextBox_notice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_notice.Location = new System.Drawing.Point(18, 237);
            this.richTextBox_notice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_notice.Name = "richTextBox_notice";
            this.richTextBox_notice.Size = new System.Drawing.Size(424, 212);
            this.richTextBox_notice.TabIndex = 13;
            this.richTextBox_notice.Text = "";
            // 
            // label_anmerkung
            // 
            this.label_anmerkung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_anmerkung.AutoSize = true;
            this.label_anmerkung.Location = new System.Drawing.Point(15, 211);
            this.label_anmerkung.Name = "label_anmerkung";
            this.label_anmerkung.Size = new System.Drawing.Size(91, 20);
            this.label_anmerkung.TabIndex = 14;
            this.label_anmerkung.Text = "Anmerkung";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_add.Location = new System.Drawing.Point(152, 474);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(154, 55);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "In den Warenkorb";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // trackBar_ammount
            // 
            this.trackBar_ammount.Location = new System.Drawing.Point(18, 115);
            this.trackBar_ammount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_ammount.Maximum = 30;
            this.trackBar_ammount.Minimum = 1;
            this.trackBar_ammount.Name = "trackBar_ammount";
            this.trackBar_ammount.Size = new System.Drawing.Size(213, 69);
            this.trackBar_ammount.TabIndex = 16;
            this.trackBar_ammount.Value = 1;
            this.trackBar_ammount.Scroll += new System.EventHandler(this.trackBar_ammount_Scroll);
            // 
            // label_ammount
            // 
            this.label_ammount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ammount.AutoSize = true;
            this.label_ammount.Location = new System.Drawing.Point(15, 77);
            this.label_ammount.Name = "label_ammount";
            this.label_ammount.Size = new System.Drawing.Size(58, 20);
            this.label_ammount.TabIndex = 17;
            this.label_ammount.Text = "Menge";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(226, 115);
            this.label_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(18, 20);
            this.label_number.TabIndex = 18;
            this.label_number.Text = "1";
            // 
            // textBox_costcentre
            // 
            this.textBox_costcentre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_costcentre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_costcentre.Location = new System.Drawing.Point(276, 115);
            this.textBox_costcentre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_costcentre.MaxLength = 100;
            this.textBox_costcentre.Name = "textBox_costcentre";
            this.textBox_costcentre.Size = new System.Drawing.Size(166, 26);
            this.textBox_costcentre.TabIndex = 19;
            this.textBox_costcentre.TextChanged += new System.EventHandler(this.textBox_costcentre_TextChanged);
            // 
            // label_kostenstelle
            // 
            this.label_kostenstelle.AutoSize = true;
            this.label_kostenstelle.Location = new System.Drawing.Point(314, 77);
            this.label_kostenstelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kostenstelle.Name = "label_kostenstelle";
            this.label_kostenstelle.Size = new System.Drawing.Size(96, 20);
            this.label_kostenstelle.TabIndex = 20;
            this.label_kostenstelle.Text = "Kostenstelle";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Location = new System.Drawing.Point(-3, -3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(471, 51);
            this.panel_top.TabIndex = 21;
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
            this.button_exit.Location = new System.Drawing.Point(386, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 49);
            this.button_exit.TabIndex = 19;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(466, 545);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.label_kostenstelle);
            this.Controls.Add(this.textBox_costcentre);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_ammount);
            this.Controls.Add(this.trackBar_ammount);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.richTextBox_notice);
            this.Controls.Add(this.label_anmerkung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warenkorb";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_ammount)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_notice;
        private System.Windows.Forms.Label label_anmerkung;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TrackBar trackBar_ammount;
        private System.Windows.Forms.Label label_ammount;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_costcentre;
        private System.Windows.Forms.Label label_kostenstelle;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_exit;
    }
}