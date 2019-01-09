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
            this.lTimTxt = new System.Windows.Forms.TextBox();
            this.lBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dTxt = new System.Windows.Forms.TextBox();
            this.sTime = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Timer(this.components);
            this.sTick = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sBtn.Location = new System.Drawing.Point(9, 75);
            this.sBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sBtn.Name = "sBtn";
            this.sBtn.Size = new System.Drawing.Size(148, 33);
            this.sBtn.TabIndex = 0;
            this.sBtn.Text = "Sample";
            this.sBtn.UseVisualStyleBackColor = true;
            this.sBtn.Click += new System.EventHandler(this.sBtn_Click);
            // 
            // sTimTxt
            // 
            this.sTimTxt.Location = new System.Drawing.Point(148, 32);
            this.sTimTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sTimTxt.Name = "sTimTxt";
            this.sTimTxt.Size = new System.Drawing.Size(100, 22);
            this.sTimTxt.TabIndex = 2;
            this.sTimTxt.Text = "4,4";
            this.sTimTxt.TextChanged += new System.EventHandler(this.sTimTxt_TextChanged);
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(15, 32);
            this.aTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aTxt.Multiline = true;
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(243, 122);
            this.aTxt.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aTxt);
            this.groupBox1.Location = new System.Drawing.Point(277, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(269, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors - Analog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Next Sampling Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sTimTxt);
            this.groupBox2.Controls.Add(this.sBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(259, 160);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sampling";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lTimTxt);
            this.groupBox3.Controls.Add(this.lBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(259, 144);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // lTimTxt
            // 
            this.lTimTxt.Location = new System.Drawing.Point(148, 32);
            this.lTimTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lTimTxt.Name = "lTimTxt";
            this.lTimTxt.Size = new System.Drawing.Size(100, 22);
            this.lTimTxt.TabIndex = 2;
            this.lTimTxt.Text = "13";
            this.lTimTxt.TextChanged += new System.EventHandler(this.lTimTxt_TextChanged);
            // 
            // lBtn
            // 
            this.lBtn.Location = new System.Drawing.Point(9, 75);
            this.lBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBtn.Name = "lBtn";
            this.lBtn.Size = new System.Drawing.Size(148, 34);
            this.lBtn.TabIndex = 0;
            this.lBtn.Text = "Log to File";
            this.lBtn.UseVisualStyleBackColor = true;
            this.lBtn.Click += new System.EventHandler(this.lBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Next Sampling Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(553, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dTxt);
            this.groupBox4.Location = new System.Drawing.Point(277, 196);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(269, 145);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sensors - Digital";
            // 
            // dTxt
            // 
            this.dTxt.Location = new System.Drawing.Point(15, 32);
            this.dTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTxt.Multiline = true;
            this.dTxt.Name = "dTxt";
            this.dTxt.Size = new System.Drawing.Size(243, 107);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 353);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dTxt;
        private System.Windows.Forms.Timer sTime;
        private System.Windows.Forms.Timer lTime;
        private System.Windows.Forms.Timer sTick;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

