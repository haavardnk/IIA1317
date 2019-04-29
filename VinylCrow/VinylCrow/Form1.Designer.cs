namespace VinylCrow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listRecord = new System.Windows.Forms.ListBox();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.checkLive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkSigned = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.textPressing = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.comboCondition = new System.Windows.Forms.ComboBox();
            this.checkLimited = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeYear = new System.Windows.Forms.DateTimePicker();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.recordImage = new System.Windows.Forms.PictureBox();
            this.fileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // listRecord
            // 
            this.listRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRecord.FormattingEnabled = true;
            this.listRecord.ItemHeight = 36;
            this.listRecord.Location = new System.Drawing.Point(6, 171);
            this.listRecord.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listRecord.Name = "listRecord";
            this.listRecord.Size = new System.Drawing.Size(542, 1048);
            this.listRecord.TabIndex = 0;
            this.listRecord.SelectedIndexChanged += new System.EventHandler(this.listRecord_SelectedIndexChanged);
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(6, 119);
            this.btnCollection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(184, 44);
            this.btnCollection.TabIndex = 1;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            // 
            // btnWishlist
            // 
            this.btnWishlist.Location = new System.Drawing.Point(202, 119);
            this.btnWishlist.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(182, 44);
            this.btnWishlist.TabIndex = 2;
            this.btnWishlist.Text = "Wishlist";
            this.btnWishlist.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2528, 44);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 117);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 38);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 41);
            this.textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 67);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.listRecord);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCollection);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnWishlist);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 1260);
            this.panel1.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(396, 12);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 44);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.checkLive);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkSigned);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboGenre);
            this.panel2.Controls.Add(this.textPressing);
            this.panel2.Controls.Add(this.textColor);
            this.panel2.Controls.Add(this.comboCondition);
            this.panel2.Controls.Add(this.checkLimited);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimeYear);
            this.panel2.Controls.Add(this.textDescription);
            this.panel2.Controls.Add(this.textArtist);
            this.panel2.Controls.Add(this.textTitle);
            this.panel2.Controls.Add(this.recordImage);
            this.panel2.Location = new System.Drawing.Point(578, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1948, 1254);
            this.panel2.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1544, 506);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1706, 506);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(22, 506);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(230, 44);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Choose Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkLive
            // 
            this.checkLive.AutoSize = true;
            this.checkLive.Location = new System.Drawing.Point(946, 392);
            this.checkLive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkLive.Name = "checkLive";
            this.checkLive.Size = new System.Drawing.Size(28, 27);
            this.checkLive.TabIndex = 19;
            this.checkLive.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 36);
            this.label8.TabIndex = 18;
            this.label8.Text = "Seen live:";
            // 
            // checkSigned
            // 
            this.checkSigned.AutoSize = true;
            this.checkSigned.Location = new System.Drawing.Point(946, 325);
            this.checkSigned.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkSigned.Name = "checkSigned";
            this.checkSigned.Size = new System.Drawing.Size(28, 27);
            this.checkSigned.TabIndex = 17;
            this.checkSigned.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "Signed:";
            // 
            // comboGenre
            // 
            this.comboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Alternative",
            "Blues",
            "Classical",
            "Comedy",
            "Country",
            "Dance",
            "Electronic",
            "Hip-Hop",
            "Industrial",
            "Jazz",
            "Latin",
            "Opera",
            "Pop",
            "R&B/Soul",
            "Reggae",
            "Rock",
            "Metal"});
            this.comboGenre.Location = new System.Drawing.Point(1562, 171);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(290, 44);
            this.comboGenre.TabIndex = 15;
            // 
            // textPressing
            // 
            this.textPressing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPressing.Location = new System.Drawing.Point(1562, 242);
            this.textPressing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textPressing.Name = "textPressing";
            this.textPressing.Size = new System.Drawing.Size(290, 41);
            this.textPressing.TabIndex = 14;
            // 
            // textColor
            // 
            this.textColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColor.Location = new System.Drawing.Point(1562, 379);
            this.textColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(290, 41);
            this.textColor.TabIndex = 13;
            // 
            // comboCondition
            // 
            this.comboCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCondition.FormattingEnabled = true;
            this.comboCondition.Items.AddRange(new object[] {
            "Mint",
            "Near Mint",
            "Very Good Plus",
            "Very Good",
            "Good",
            "Poor"});
            this.comboCondition.Location = new System.Drawing.Point(1562, 312);
            this.comboCondition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboCondition.Name = "comboCondition";
            this.comboCondition.Size = new System.Drawing.Size(290, 44);
            this.comboCondition.TabIndex = 12;
            // 
            // checkLimited
            // 
            this.checkLimited.AutoSize = true;
            this.checkLimited.Location = new System.Drawing.Point(946, 256);
            this.checkLimited.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkLimited.Name = "checkLimited";
            this.checkLimited.Size = new System.Drawing.Size(28, 27);
            this.checkLimited.TabIndex = 11;
            this.checkLimited.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1296, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Condition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1296, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Limited edition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1296, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pressing Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1296, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year:";
            // 
            // dateTimeYear
            // 
            this.dateTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeYear.Location = new System.Drawing.Point(946, 167);
            this.dateTimeYear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimeYear.Name = "dateTimeYear";
            this.dateTimeYear.Size = new System.Drawing.Size(290, 41);
            this.dateTimeYear.TabIndex = 4;
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(22, 562);
            this.textDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(1830, 669);
            this.textDescription.TabIndex = 3;
            this.textDescription.Text = "";
            // 
            // textArtist
            // 
            this.textArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArtist.Location = new System.Drawing.Point(728, 90);
            this.textArtist.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(1124, 51);
            this.textArtist.TabIndex = 2;
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(728, 23);
            this.textTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(1124, 51);
            this.textTitle.TabIndex = 1;
            // 
            // recordImage
            // 
            this.recordImage.Location = new System.Drawing.Point(22, 23);
            this.recordImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recordImage.Name = "recordImage";
            this.recordImage.Size = new System.Drawing.Size(664, 471);
            this.recordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recordImage.TabIndex = 0;
            this.recordImage.TabStop = false;
            // 
            // fileDialogImage
            // 
            this.fileDialogImage.FileName = "openFileDialog1";
            this.fileDialogImage.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*\"";
            this.fileDialogImage.Title = "Choose vinyl image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2528, 1310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "VinylCrow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRecord;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPressing;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.ComboBox comboCondition;
        private System.Windows.Forms.CheckBox checkLimited;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeYear;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.PictureBox recordImage;
        private System.Windows.Forms.CheckBox checkLive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkSigned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog fileDialogImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}

