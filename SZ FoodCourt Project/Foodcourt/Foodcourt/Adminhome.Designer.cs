namespace Foodcourt
{
    partial class Adminhome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMTYPESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATESTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWSALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.salesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.uPDATESTOCKToolStripMenuItem,
            this.vIEWSALESToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(618, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTEMTYPESToolStripMenuItem,
            this.iTEMSToolStripMenuItem,
            this.salesmanToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // iTEMTYPESToolStripMenuItem
            // 
            this.iTEMTYPESToolStripMenuItem.Name = "iTEMTYPESToolStripMenuItem";
            this.iTEMTYPESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iTEMTYPESToolStripMenuItem.Text = "ITEM TYPES";
            this.iTEMTYPESToolStripMenuItem.Click += new System.EventHandler(this.iTEMTYPESToolStripMenuItem_Click);
            // 
            // iTEMSToolStripMenuItem
            // 
            this.iTEMSToolStripMenuItem.Name = "iTEMSToolStripMenuItem";
            this.iTEMSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iTEMSToolStripMenuItem.Text = "ITEMS";
            this.iTEMSToolStripMenuItem.Click += new System.EventHandler(this.iTEMSToolStripMenuItem_Click);
            // 
            // uPDATESTOCKToolStripMenuItem
            // 
            this.uPDATESTOCKToolStripMenuItem.Name = "uPDATESTOCKToolStripMenuItem";
            this.uPDATESTOCKToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.uPDATESTOCKToolStripMenuItem.Text = "UPDATE STOCK";
            this.uPDATESTOCKToolStripMenuItem.Click += new System.EventHandler(this.uPDATESTOCKToolStripMenuItem_Click);
            // 
            // vIEWSALESToolStripMenuItem
            // 
            this.vIEWSALESToolStripMenuItem.Name = "vIEWSALESToolStripMenuItem";
            this.vIEWSALESToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.vIEWSALESToolStripMenuItem.Text = "VIEW SALES";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT ";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO SZ FOODCOURT ";
            // 
            // salesmanToolStripMenuItem
            // 
            this.salesmanToolStripMenuItem.Name = "salesmanToolStripMenuItem";
            this.salesmanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesmanToolStripMenuItem.Text = "Salesman";
            this.salesmanToolStripMenuItem.Click += new System.EventHandler(this.salesmanToolStripMenuItem_Click);
            // 
            // Adminhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(618, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Adminhome";
            this.Text = "Adminhome";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMTYPESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATESTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWSALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem salesmanToolStripMenuItem;
    }
}