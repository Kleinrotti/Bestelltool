namespace Bestelltool
{
    partial class UI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_right = new System.Windows.Forms.GroupBox();
            this.listView_warenkorb = new System.Windows.Forms.ListView();
            this.columnHeader_ammount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_kostenstelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_anmerkung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_mail = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_location1 = new System.Windows.Forms.RadioButton();
            this.radioButton_location2 = new System.Windows.Forms.RadioButton();
            this.label_target = new System.Windows.Forms.Label();
            this.textBox_othermail = new System.Windows.Forms.TextBox();
            this.button_order = new System.Windows.Forms.Button();
            this.radioButton_custommail = new System.Windows.Forms.RadioButton();
            this.label_mailadresse = new System.Windows.Forms.Label();
            this.radioButton_defaultmail = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip_warenkorb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_change = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label_user = new System.Windows.Forms.Label();
            this.groupBox_left = new System.Windows.Forms.GroupBox();
            this.label_productammount = new System.Windows.Forms.Label();
            this.label_searchfor = new System.Windows.Forms.Label();
            this.listView_items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_products = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_addwarenkorb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.button_search = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.konfigpfaddialog = new System.Windows.Forms.OpenFileDialog();
            this.bestellblattpfaddialog = new System.Windows.Forms.OpenFileDialog();
            this.warenlistenpfaddialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_headline = new System.Windows.Forms.Label();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.button_ordersite = new System.Windows.Forms.Button();
            this.fileSystemWatcher_orderhistory = new System.IO.FileSystemWatcher();
            this.label_lastorder = new System.Windows.Forms.Label();
            this.label_lastorderinfo = new System.Windows.Forms.Label();
            this.fileSystemWatcher_products = new System.IO.FileSystemWatcher();
            this.pictureBox_bottom = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrastoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warenlistenpfadÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestelllistenpfadÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_right.SuspendLayout();
            this.panel_mail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_warenkorb.SuspendLayout();
            this.groupBox_left.SuspendLayout();
            this.contextMenuStrip_products.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_orderhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bottom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_right
            // 
            this.groupBox_right.Controls.Add(this.listView_warenkorb);
            this.groupBox_right.Controls.Add(this.panel_mail);
            this.groupBox_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_right.Location = new System.Drawing.Point(807, 104);
            this.groupBox_right.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_right.Name = "groupBox_right";
            this.groupBox_right.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_right.Size = new System.Drawing.Size(794, 898);
            this.groupBox_right.TabIndex = 4;
            this.groupBox_right.TabStop = false;
            this.groupBox_right.Text = "Warenkorb";
            // 
            // listView_warenkorb
            // 
            this.listView_warenkorb.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_warenkorb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ammount,
            this.columnHeader_name,
            this.columnHeader_kostenstelle,
            this.columnHeader_anmerkung});
            this.listView_warenkorb.LabelWrap = false;
            this.listView_warenkorb.Location = new System.Drawing.Point(12, 24);
            this.listView_warenkorb.MultiSelect = false;
            this.listView_warenkorb.Name = "listView_warenkorb";
            this.listView_warenkorb.ShowItemToolTips = true;
            this.listView_warenkorb.Size = new System.Drawing.Size(774, 589);
            this.listView_warenkorb.TabIndex = 17;
            this.listView_warenkorb.UseCompatibleStateImageBehavior = false;
            this.listView_warenkorb.View = System.Windows.Forms.View.Details;
            this.listView_warenkorb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_warenkorb_MouseClick);
            this.listView_warenkorb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_warenkorb_MouseDoubleClick);
            // 
            // columnHeader_ammount
            // 
            this.columnHeader_ammount.Text = "Anzahl";
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            this.columnHeader_name.Width = 210;
            // 
            // columnHeader_kostenstelle
            // 
            this.columnHeader_kostenstelle.Text = "Kostenstelle";
            this.columnHeader_kostenstelle.Width = 169;
            // 
            // columnHeader_anmerkung
            // 
            this.columnHeader_anmerkung.Text = "Anmerkung";
            this.columnHeader_anmerkung.Width = 160;
            // 
            // panel_mail
            // 
            this.panel_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mail.Controls.Add(this.panel2);
            this.panel_mail.Controls.Add(this.label_target);
            this.panel_mail.Controls.Add(this.textBox_othermail);
            this.panel_mail.Controls.Add(this.button_order);
            this.panel_mail.Controls.Add(this.radioButton_custommail);
            this.panel_mail.Controls.Add(this.label_mailadresse);
            this.panel_mail.Controls.Add(this.radioButton_defaultmail);
            this.panel_mail.Location = new System.Drawing.Point(12, 622);
            this.panel_mail.Margin = new System.Windows.Forms.Padding(4);
            this.panel_mail.Name = "panel_mail";
            this.panel_mail.Size = new System.Drawing.Size(773, 263);
            this.panel_mail.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.radioButton_location1);
            this.panel2.Controls.Add(this.radioButton_location2);
            this.panel2.Location = new System.Drawing.Point(-2, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 102);
            this.panel2.TabIndex = 18;
            // 
            // radioButton_location1
            // 
            this.radioButton_location1.AutoSize = true;
            this.radioButton_location1.Checked = true;
            this.radioButton_location1.Location = new System.Drawing.Point(8, 12);
            this.radioButton_location1.Name = "radioButton_location1";
            this.radioButton_location1.Size = new System.Drawing.Size(118, 26);
            this.radioButton_location1.TabIndex = 18;
            this.radioButton_location1.TabStop = true;
            this.radioButton_location1.Text = "Standort 1";
            this.radioButton_location1.UseVisualStyleBackColor = true;
            // 
            // radioButton_location2
            // 
            this.radioButton_location2.AutoSize = true;
            this.radioButton_location2.Location = new System.Drawing.Point(8, 46);
            this.radioButton_location2.Name = "radioButton_location2";
            this.radioButton_location2.Size = new System.Drawing.Size(118, 26);
            this.radioButton_location2.TabIndex = 19;
            this.radioButton_location2.Text = "Standort 2";
            this.radioButton_location2.UseVisualStyleBackColor = true;
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_target.ForeColor = System.Drawing.Color.Black;
            this.label_target.Location = new System.Drawing.Point(315, 16);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(154, 32);
            this.label_target.TabIndex = 17;
            this.label_target.Text = "Empfänger";
            // 
            // textBox_othermail
            // 
            this.textBox_othermail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_othermail.Enabled = false;
            this.textBox_othermail.Location = new System.Drawing.Point(36, 116);
            this.textBox_othermail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_othermail.Name = "textBox_othermail";
            this.textBox_othermail.Size = new System.Drawing.Size(338, 28);
            this.textBox_othermail.TabIndex = 13;
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_order.Location = new System.Drawing.Point(519, 165);
            this.button_order.Margin = new System.Windows.Forms.Padding(4);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(248, 92);
            this.button_order.TabIndex = 16;
            this.button_order.Text = "Abschicken";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // radioButton_custommail
            // 
            this.radioButton_custommail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_custommail.AutoSize = true;
            this.radioButton_custommail.Location = new System.Drawing.Point(6, 118);
            this.radioButton_custommail.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_custommail.Name = "radioButton_custommail";
            this.radioButton_custommail.Size = new System.Drawing.Size(21, 20);
            this.radioButton_custommail.TabIndex = 14;
            this.radioButton_custommail.UseVisualStyleBackColor = true;
            this.radioButton_custommail.CheckedChanged += new System.EventHandler(this.radioButton_custommail_CheckedChanged);
            // 
            // label_mailadresse
            // 
            this.label_mailadresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mailadresse.AutoSize = true;
            this.label_mailadresse.Location = new System.Drawing.Point(194, 69);
            this.label_mailadresse.Name = "label_mailadresse";
            this.label_mailadresse.Size = new System.Drawing.Size(184, 22);
            this.label_mailadresse.TabIndex = 13;
            this.label_mailadresse.Text = "Mail: sample@mail.de";
            // 
            // radioButton_defaultmail
            // 
            this.radioButton_defaultmail.AutoSize = true;
            this.radioButton_defaultmail.Checked = true;
            this.radioButton_defaultmail.Location = new System.Drawing.Point(6, 68);
            this.radioButton_defaultmail.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_defaultmail.Name = "radioButton_defaultmail";
            this.radioButton_defaultmail.Size = new System.Drawing.Size(171, 26);
            this.radioButton_defaultmail.TabIndex = 5;
            this.radioButton_defaultmail.TabStop = true;
            this.radioButton_defaultmail.Text = "Standard Auftrag";
            this.radioButton_defaultmail.UseVisualStyleBackColor = true;
            this.radioButton_defaultmail.CheckedChanged += new System.EventHandler(this.radioButton_defaultmail_CheckedChanged);
            // 
            // contextMenuStrip_warenkorb
            // 
            this.contextMenuStrip_warenkorb.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_warenkorb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_change,
            this.toolStripMenuItem_delete});
            this.contextMenuStrip_warenkorb.Name = "contextMenuStrip_warenkorb";
            this.contextMenuStrip_warenkorb.Size = new System.Drawing.Size(149, 64);
            this.contextMenuStrip_warenkorb.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_warenkorb_ItemClicked);
            // 
            // toolStripMenuItem_change
            // 
            this.toolStripMenuItem_change.Name = "toolStripMenuItem_change";
            this.toolStripMenuItem_change.Size = new System.Drawing.Size(148, 30);
            this.toolStripMenuItem_change.Text = "Ändern";
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(148, 30);
            this.toolStripMenuItem_delete.Text = "Löschen";
            // 
            // label_user
            // 
            this.label_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(1250, 18);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(137, 20);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "Mustermann, Fritz";
            // 
            // groupBox_left
            // 
            this.groupBox_left.Controls.Add(this.label_productammount);
            this.groupBox_left.Controls.Add(this.label_searchfor);
            this.groupBox_left.Controls.Add(this.listView_items);
            this.groupBox_left.Controls.Add(this.button_search);
            this.groupBox_left.Controls.Add(this.button_refresh);
            this.groupBox_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_left.Location = new System.Drawing.Point(15, 104);
            this.groupBox_left.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_left.Name = "groupBox_left";
            this.groupBox_left.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_left.Size = new System.Drawing.Size(729, 898);
            this.groupBox_left.TabIndex = 19;
            this.groupBox_left.TabStop = false;
            this.groupBox_left.Text = "Produkte";
            // 
            // label_productammount
            // 
            this.label_productammount.AutoSize = true;
            this.label_productammount.Location = new System.Drawing.Point(560, 844);
            this.label_productammount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productammount.Name = "label_productammount";
            this.label_productammount.Size = new System.Drawing.Size(20, 22);
            this.label_productammount.TabIndex = 19;
            this.label_productammount.Text = "0";
            // 
            // label_searchfor
            // 
            this.label_searchfor.AutoSize = true;
            this.label_searchfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchfor.Location = new System.Drawing.Point(141, 844);
            this.label_searchfor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_searchfor.Name = "label_searchfor";
            this.label_searchfor.Size = new System.Drawing.Size(112, 22);
            this.label_searchfor.TabIndex = 18;
            this.label_searchfor.Text = "Keine Suche";
            // 
            // listView_items
            // 
            this.listView_items.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_items.ContextMenuStrip = this.contextMenuStrip_products;
            this.listView_items.LabelWrap = false;
            this.listView_items.Location = new System.Drawing.Point(8, 27);
            this.listView_items.MultiSelect = false;
            this.listView_items.Name = "listView_items";
            this.listView_items.Size = new System.Drawing.Size(714, 791);
            this.listView_items.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_items.TabIndex = 1;
            this.listView_items.UseCompatibleStateImageBehavior = false;
            this.listView_items.View = System.Windows.Forms.View.Details;
            this.listView_items.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_items_MouseClick);
            this.listView_items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_items_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produkt";
            this.columnHeader1.Width = 400;
            // 
            // contextMenuStrip_products
            // 
            this.contextMenuStrip_products.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_products.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_addwarenkorb,
            this.toolStripMenuItem_add,
            this.toolStripMenuItem_remove});
            this.contextMenuStrip_products.Name = "contextMenuStrip_products";
            this.contextMenuStrip_products.Size = new System.Drawing.Size(241, 94);
            this.contextMenuStrip_products.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip_products_Closed);
            // 
            // toolStripMenuItem_addwarenkorb
            // 
            this.toolStripMenuItem_addwarenkorb.Enabled = false;
            this.toolStripMenuItem_addwarenkorb.Name = "toolStripMenuItem_addwarenkorb";
            this.toolStripMenuItem_addwarenkorb.Size = new System.Drawing.Size(240, 30);
            this.toolStripMenuItem_addwarenkorb.Text = "In den Warenkorb";
            this.toolStripMenuItem_addwarenkorb.Visible = false;
            this.toolStripMenuItem_addwarenkorb.Click += new System.EventHandler(this.toolStripMenuItem_addwarenkorb_Click);
            // 
            // toolStripMenuItem_add
            // 
            this.toolStripMenuItem_add.Name = "toolStripMenuItem_add";
            this.toolStripMenuItem_add.Size = new System.Drawing.Size(240, 30);
            this.toolStripMenuItem_add.Text = "Produkt hinzufügen";
            this.toolStripMenuItem_add.Click += new System.EventHandler(this.toolStripMenuItem_add_Click);
            // 
            // toolStripMenuItem_remove
            // 
            this.toolStripMenuItem_remove.Enabled = false;
            this.toolStripMenuItem_remove.Name = "toolStripMenuItem_remove";
            this.toolStripMenuItem_remove.Size = new System.Drawing.Size(240, 30);
            this.toolStripMenuItem_remove.Text = "Produkt entfernen";
            this.toolStripMenuItem_remove.Visible = false;
            this.toolStripMenuItem_remove.Click += new System.EventHandler(this.toolStripMenuItem_remove_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_search.BackgroundImage = global::Bestelltool.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_search.Location = new System.Drawing.Point(14, 824);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(118, 62);
            this.button_search.TabIndex = 17;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_refresh.BackgroundImage = global::Bestelltool.Properties.Resources.View_refresh_Gion_simple_svg;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_refresh.Location = new System.Drawing.Point(604, 824);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(118, 63);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // konfigpfaddialog
            // 
            this.konfigpfaddialog.FileName = "Konfig";
            this.konfigpfaddialog.Filter = "Konfigdatei|*.ini";
            this.konfigpfaddialog.Title = "Konfigdatei";
            // 
            // bestellblattpfaddialog
            // 
            this.bestellblattpfaddialog.FileName = "Bestellblatt";
            this.bestellblattpfaddialog.Filter = "Bestellblatt|*.best";
            this.bestellblattpfaddialog.Title = "Bestellblatt";
            // 
            // warenlistenpfaddialog
            // 
            this.warenlistenpfaddialog.FileName = "Warenliste";
            this.warenlistenpfaddialog.Filter = "Warenliste|*.WL";
            this.warenlistenpfaddialog.Title = "Warenliste";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.label_welcome);
            this.panel1.Controls.Add(this.pictureBox_logo);
            this.panel1.Controls.Add(this.label_headline);
            this.panel1.Controls.Add(this.button_minimize);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.label_user);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 51);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label_welcome
            // 
            this.label_welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(1148, 19);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(94, 20);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Willkommen";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(72, 51);
            this.pictureBox_logo.TabIndex = 21;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.ForeColor = System.Drawing.Color.White;
            this.label_headline.Location = new System.Drawing.Point(712, 10);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(178, 29);
            this.label_headline.TabIndex = 20;
            this.label_headline.Text = "Bestellsoftware";
            this.label_headline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_headline_MouseDown);
            // 
            // button_minimize
            // 
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Location = new System.Drawing.Point(1431, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(90, 46);
            this.button_minimize.TabIndex = 19;
            this.button_minimize.Text = "-";
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(1527, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(90, 46);
            this.button_exit.TabIndex = 18;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_history.FlatAppearance.BorderSize = 0;
            this.button_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_history.ForeColor = System.Drawing.Color.White;
            this.button_history.Location = new System.Drawing.Point(1527, 57);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(90, 42);
            this.button_history.TabIndex = 21;
            this.button_history.Text = "Verlauf";
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_ordersite
            // 
            this.button_ordersite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button_ordersite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ordersite.FlatAppearance.BorderSize = 0;
            this.button_ordersite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ordersite.ForeColor = System.Drawing.Color.White;
            this.button_ordersite.Location = new System.Drawing.Point(1443, 57);
            this.button_ordersite.Name = "button_ordersite";
            this.button_ordersite.Size = new System.Drawing.Size(90, 42);
            this.button_ordersite.TabIndex = 22;
            this.button_ordersite.Text = "Bestellen";
            this.button_ordersite.UseVisualStyleBackColor = false;
            this.button_ordersite.Click += new System.EventHandler(this.button_ordersite_Click);
            // 
            // fileSystemWatcher_orderhistory
            // 
            this.fileSystemWatcher_orderhistory.EnableRaisingEvents = true;
            this.fileSystemWatcher_orderhistory.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher_orderhistory.SynchronizingObject = this;
            this.fileSystemWatcher_orderhistory.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_orderhistory_Changed);
            // 
            // label_lastorder
            // 
            this.label_lastorder.AutoSize = true;
            this.label_lastorder.Location = new System.Drawing.Point(9, 1010);
            this.label_lastorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastorder.Name = "label_lastorder";
            this.label_lastorder.Size = new System.Drawing.Size(137, 20);
            this.label_lastorder.TabIndex = 23;
            this.label_lastorder.Text = "Letzte Bestellung:";
            // 
            // label_lastorderinfo
            // 
            this.label_lastorderinfo.AutoSize = true;
            this.label_lastorderinfo.Location = new System.Drawing.Point(142, 1010);
            this.label_lastorderinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastorderinfo.Name = "label_lastorderinfo";
            this.label_lastorderinfo.Size = new System.Drawing.Size(14, 20);
            this.label_lastorderinfo.TabIndex = 24;
            this.label_lastorderinfo.Text = "-";
            // 
            // fileSystemWatcher_products
            // 
            this.fileSystemWatcher_products.EnableRaisingEvents = true;
            this.fileSystemWatcher_products.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher_products.SynchronizingObject = this;
            this.fileSystemWatcher_products.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_products_Changed);
            // 
            // pictureBox_bottom
            // 
            this.pictureBox_bottom.BackgroundImage = global::Bestelltool.Properties.Resources.loading_small;
            this.pictureBox_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_bottom.Enabled = false;
            this.pictureBox_bottom.Location = new System.Drawing.Point(1571, 997);
            this.pictureBox_bottom.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_bottom.Name = "pictureBox_bottom";
            this.pictureBox_bottom.Size = new System.Drawing.Size(46, 38);
            this.pictureBox_bottom.TabIndex = 25;
            this.pictureBox_bottom.TabStop = false;
            this.pictureBox_bottom.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.extrastoolStripMenuItem,
            this.infoStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1617, 50);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dateiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dateiToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(74, 44);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // extrastoolStripMenuItem
            // 
            this.extrastoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warenlistenpfadÄndernToolStripMenuItem,
            this.bestelllistenpfadÄndernToolStripMenuItem});
            this.extrastoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrastoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.extrastoolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.extrastoolStripMenuItem.Name = "extrastoolStripMenuItem";
            this.extrastoolStripMenuItem.Size = new System.Drawing.Size(80, 44);
            this.extrastoolStripMenuItem.Text = "Extras";
            // 
            // warenlistenpfadÄndernToolStripMenuItem
            // 
            this.warenlistenpfadÄndernToolStripMenuItem.Name = "warenlistenpfadÄndernToolStripMenuItem";
            this.warenlistenpfadÄndernToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.warenlistenpfadÄndernToolStripMenuItem.Text = "Warenlistenpfad ändern";
            this.warenlistenpfadÄndernToolStripMenuItem.Click += new System.EventHandler(this.warenlistenpfadÄndernToolStripMenuItem_Click);
            // 
            // bestelllistenpfadÄndernToolStripMenuItem
            // 
            this.bestelllistenpfadÄndernToolStripMenuItem.Name = "bestelllistenpfadÄndernToolStripMenuItem";
            this.bestelllistenpfadÄndernToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.bestelllistenpfadÄndernToolStripMenuItem.Text = "Bestelllistenpfad ändern";
            this.bestelllistenpfadÄndernToolStripMenuItem.Click += new System.EventHandler(this.bestelllistenpfadÄndernToolStripMenuItem_Click);
            // 
            // infoStripMenuItem
            // 
            this.infoStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.infoStripMenuItem.Name = "infoStripMenuItem";
            this.infoStripMenuItem.Size = new System.Drawing.Size(62, 44);
            this.infoStripMenuItem.Text = "Info";
            this.infoStripMenuItem.ToolTipText = "Info";
            this.infoStripMenuItem.Click += new System.EventHandler(this.InfoStripMenuItem_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1617, 1039);
            this.Controls.Add(this.button_ordersite);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.pictureBox_bottom);
            this.Controls.Add(this.label_lastorderinfo);
            this.Controls.Add(this.label_lastorder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_left);
            this.Controls.Add(this.groupBox_right);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestellsoftware";
            this.Load += new System.EventHandler(this.UI_Load);
            this.groupBox_right.ResumeLayout(false);
            this.panel_mail.ResumeLayout(false);
            this.panel_mail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip_warenkorb.ResumeLayout(false);
            this.groupBox_left.ResumeLayout(false);
            this.groupBox_left.PerformLayout();
            this.contextMenuStrip_products.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_orderhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bottom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_right;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Panel panel_mail;
        private System.Windows.Forms.TextBox textBox_othermail;
        private System.Windows.Forms.RadioButton radioButton_custommail;
        private System.Windows.Forms.Label label_mailadresse;
        private System.Windows.Forms.RadioButton radioButton_defaultmail;
        private System.Windows.Forms.GroupBox groupBox_left;
        private System.Windows.Forms.OpenFileDialog konfigpfaddialog;
        private System.Windows.Forms.OpenFileDialog bestellblattpfaddialog;
        private System.Windows.Forms.OpenFileDialog warenlistenpfaddialog;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListView listView_warenkorb;
        private System.Windows.Forms.ListView listView_items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader_ammount;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_kostenstelle;
        private System.Windows.Forms.ColumnHeader columnHeader_anmerkung;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_warenkorb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_change;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_products;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_add;
        private System.Windows.Forms.Label label_searchfor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_addwarenkorb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Button button_ordersite;
        private System.IO.FileSystemWatcher fileSystemWatcher_orderhistory;
        private System.Windows.Forms.Label label_lastorderinfo;
        private System.Windows.Forms.Label label_lastorder;
        private System.Windows.Forms.RadioButton radioButton_location2;
        private System.Windows.Forms.RadioButton radioButton_location1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_productammount;
        private System.IO.FileSystemWatcher fileSystemWatcher_products;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_remove;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.PictureBox pictureBox_bottom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrastoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warenlistenpfadÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestelllistenpfadÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoStripMenuItem;
    }
}

