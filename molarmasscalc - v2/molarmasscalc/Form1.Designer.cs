namespace molarmasscalc
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
            this.formulabox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.finalmassbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.realtimecheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gramsMolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formulabox
            // 
            this.formulabox.Location = new System.Drawing.Point(61, 48);
            this.formulabox.Name = "formulabox";
            this.formulabox.Size = new System.Drawing.Size(193, 20);
            this.formulabox.TabIndex = 0;
            this.formulabox.TextChanged += new System.EventHandler(this.formulabox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Molar Mass Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formula:";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(23, 89);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.calculatebutton.TabIndex = 1;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // finalmassbox
            // 
            this.finalmassbox.Location = new System.Drawing.Point(61, 130);
            this.finalmassbox.Name = "finalmassbox";
            this.finalmassbox.ReadOnly = true;
            this.finalmassbox.Size = new System.Drawing.Size(193, 20);
            this.finalmassbox.TabIndex = 3;
            this.finalmassbox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mass (g):";
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(23, 171);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 9;
            this.closebutton.TabStop = false;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // realtimecheckbox
            // 
            this.realtimecheckbox.AutoSize = true;
            this.realtimecheckbox.Location = new System.Drawing.Point(198, 93);
            this.realtimecheckbox.Name = "realtimecheckbox";
            this.realtimecheckbox.Size = new System.Drawing.Size(74, 17);
            this.realtimecheckbox.TabIndex = 11;
            this.realtimecheckbox.Text = "Real Time";
            this.realtimecheckbox.UseVisualStyleBackColor = true;
            this.realtimecheckbox.CheckedChanged += new System.EventHandler(this.realtimecheckbox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.closeToolStripMenuItem.Text = "Quit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gramsMolesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // gramsMolesToolStripMenuItem
            // 
            this.gramsMolesToolStripMenuItem.Name = "gramsMolesToolStripMenuItem";
            this.gramsMolesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gramsMolesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gramsMolesToolStripMenuItem.Text = "Grams to Moles";
            this.gramsMolesToolStripMenuItem.Click += new System.EventHandler(this.gramsMolesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Grams to Moles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.realtimecheckbox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalmassbox);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formulabox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Molar Mass Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox formulabox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.TextBox finalmassbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.CheckBox realtimecheckbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gramsMolesToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
    }
}

