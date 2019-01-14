namespace DAQ_Simulator
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
            this.components = new System.ComponentModel.Container();
            this.sBtn = new System.Windows.Forms.Button();
            this.sTimTxt = new System.Windows.Forms.TextBox();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nSampleTxt = new System.Windows.Forms.Label();
            this.lTimTxt = new System.Windows.Forms.TextBox();
            this.lBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dTxt = new System.Windows.Forms.TextBox();
            this.sTime = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Timer(this.components);
            this.sTick = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sBtn
            // 
            this.sBtn.Location = new System.Drawing.Point(7, 61);
            this.sBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sBtn.Name = "sBtn";
            this.sBtn.Size = new System.Drawing.Size(111, 27);
            this.sBtn.TabIndex = 0;
            this.sBtn.Text = "Sample";
            this.sBtn.UseVisualStyleBackColor = true;
            this.sBtn.Click += new System.EventHandler(this.sBtn_Click);
            // 
            // sTimTxt
            // 
            this.sTimTxt.Location = new System.Drawing.Point(128, 26);
            this.sTimTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sTimTxt.Name = "sTimTxt";
            this.sTimTxt.Size = new System.Drawing.Size(59, 20);
            this.sTimTxt.TabIndex = 2;
            this.sTimTxt.Text = "4,4";
            this.sTimTxt.TextChanged += new System.EventHandler(this.sTimTxt_TextChanged);
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(11, 26);
            this.aTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aTxt.Multiline = true;
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(183, 100);
            this.aTxt.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aTxt);
            this.groupBox1.Location = new System.Drawing.Point(208, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(202, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors - Analog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minimum Sampling Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sTimTxt);
            this.groupBox2.Controls.Add(this.sBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(194, 130);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sampling";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nSampleTxt);
            this.groupBox3.Controls.Add(this.lTimTxt);
            this.groupBox3.Controls.Add(this.lBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(194, 117);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // nSampleTxt
            // 
            this.nSampleTxt.AutoSize = true;
            this.nSampleTxt.Location = new System.Drawing.Point(7, 98);
            this.nSampleTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nSampleTxt.Name = "nSampleTxt";
            this.nSampleTxt.Size = new System.Drawing.Size(0, 13);
            this.nSampleTxt.TabIndex = 8;
            // 
            // lTimTxt
            // 
            this.lTimTxt.Location = new System.Drawing.Point(128, 26);
            this.lTimTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lTimTxt.Name = "lTimTxt";
            this.lTimTxt.Size = new System.Drawing.Size(59, 20);
            this.lTimTxt.TabIndex = 2;
            this.lTimTxt.Text = "13";
            this.lTimTxt.TextChanged += new System.EventHandler(this.lTimTxt_TextChanged);
            // 
            // lBtn
            // 
            this.lBtn.Location = new System.Drawing.Point(7, 61);
            this.lBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBtn.Name = "lBtn";
            this.lBtn.Size = new System.Drawing.Size(111, 28);
            this.lBtn.TabIndex = 0;
            this.lBtn.Text = "Log to File";
            this.lBtn.UseVisualStyleBackColor = true;
            this.lBtn.Click += new System.EventHandler(this.lBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minimum Logging Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dTxt);
            this.groupBox4.Location = new System.Drawing.Point(208, 159);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(202, 118);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sensors - Digital";
            // 
            // dTxt
            // 
            this.dTxt.Location = new System.Drawing.Point(11, 26);
            this.dTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTxt.Multiline = true;
            this.dTxt.Name = "dTxt";
            this.dTxt.Size = new System.Drawing.Size(183, 88);
            this.dTxt.TabIndex = 4;
            // 
            // sTime
            // 
            this.sTime.Interval = 4400;
            this.sTime.Tick += new System.EventHandler(this.sTime_Tick);
            // 
            // lTime
            // 
            this.lTime.Interval = 13000;
            this.lTime.Tick += new System.EventHandler(this.lTime_Tick);
            // 
            // sTick
            // 
            this.sTick.Enabled = true;
            this.sTick.Tick += new System.EventHandler(this.sTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 287);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sBtn;
        private System.Windows.Forms.TextBox sTimTxt;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lTimTxt;
        private System.Windows.Forms.Button lBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dTxt;
        private System.Windows.Forms.Timer sTime;
        private System.Windows.Forms.Timer lTime;
        private System.Windows.Forms.Timer sTick;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label nSampleTxt;
    }
}

