namespace molarmasscalc
{
    partial class Grams2Moles
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
            this.gramstextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofelementtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.finalmolestextbox = new System.Windows.Forms.TextBox();
            this.molesofwhatlabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G2MButton = new System.Windows.Forms.Button();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gramstextbox
            // 
            this.gramstextbox.Location = new System.Drawing.Point(9, 11);
            this.gramstextbox.Name = "gramstextbox";
            this.gramstextbox.Size = new System.Drawing.Size(66, 20);
            this.gramstextbox.TabIndex = 0;
            this.gramstextbox.TextChanged += new System.EventHandler(this.gramstextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "grams of";
            // 
            // ofelementtextbox
            // 
            this.ofelementtextbox.Location = new System.Drawing.Point(129, 10);
            this.ofelementtextbox.Name = "ofelementtextbox";
            this.ofelementtextbox.Size = new System.Drawing.Size(59, 20);
            this.ofelementtextbox.TabIndex = 2;
            this.ofelementtextbox.TextChanged += new System.EventHandler(this.ofelementtextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // finalmolestextbox
            // 
            this.finalmolestextbox.Location = new System.Drawing.Point(45, 51);
            this.finalmolestextbox.Name = "finalmolestextbox";
            this.finalmolestextbox.ReadOnly = true;
            this.finalmolestextbox.Size = new System.Drawing.Size(87, 20);
            this.finalmolestextbox.TabIndex = 4;
            this.finalmolestextbox.TextChanged += new System.EventHandler(this.finalmolestextbox_TextChanged);
            // 
            // molesofwhatlabel
            // 
            this.molesofwhatlabel.AutoSize = true;
            this.molesofwhatlabel.Location = new System.Drawing.Point(139, 58);
            this.molesofwhatlabel.Name = "molesofwhatlabel";
            this.molesofwhatlabel.Size = new System.Drawing.Size(23, 13);
            this.molesofwhatlabel.TabIndex = 5;
            this.molesofwhatlabel.Text = "mol";
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(142, 80);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(46, 23);
            this.closebutton.TabIndex = 6;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(9, 80);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(66, 23);
            this.calculatebutton.TabIndex = 7;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.calculateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(197, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Visible = false;
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Visible = false;
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // G2MButton
            // 
            this.G2MButton.Location = new System.Drawing.Point(79, 80);
            this.G2MButton.Name = "G2MButton";
            this.G2MButton.Size = new System.Drawing.Size(57, 23);
            this.G2MButton.TabIndex = 9;
            this.G2MButton.Text = "G2M";
            this.G2MButton.UseVisualStyleBackColor = true;
            this.G2MButton.Click += new System.EventHandler(this.G2MButton_Click);
            // 
            // copyToToolStripMenuItem
            // 
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            this.copyToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.copyToToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyToToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToToolStripMenuItem.Click += new System.EventHandler(this.copyToToolStripMenuItem_Click);
            // 
            // Grams2Moles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 112);
            this.Controls.Add(this.G2MButton);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.molesofwhatlabel);
            this.Controls.Add(this.finalmolestextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ofelementtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gramstextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Grams2Moles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Grams<>Moles";
            this.Load += new System.EventHandler(this.Grams2Moles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gramstextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ofelementtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalmolestextbox;
        private System.Windows.Forms.Label molesofwhatlabel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.Button G2MButton;
        private System.Windows.Forms.ToolStripMenuItem copyToToolStripMenuItem;
    }
}