namespace Foodcourt
{
    partial class Additems
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtitemno = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.cbitemtype = new System.Windows.Forms.ComboBox();
            this.txtitemprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD ITEMS ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Price";
            // 
            // txtitemno
            // 
            this.txtitemno.Enabled = false;
            this.txtitemno.Location = new System.Drawing.Point(275, 113);
            this.txtitemno.Name = "txtitemno";
            this.txtitemno.Size = new System.Drawing.Size(172, 20);
            this.txtitemno.TabIndex = 5;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(275, 233);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(168, 20);
            this.txtitemname.TabIndex = 6;
            // 
            // cbitemtype
            // 
            this.cbitemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbitemtype.FormattingEnabled = true;
            this.cbitemtype.Location = new System.Drawing.Point(275, 177);
            this.cbitemtype.Name = "cbitemtype";
            this.cbitemtype.Size = new System.Drawing.Size(168, 21);
            this.cbitemtype.TabIndex = 7;
            this.cbitemtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtitemprice
            // 
            this.txtitemprice.Location = new System.Drawing.Point(271, 286);
            this.txtitemprice.Name = "txtitemprice";
            this.txtitemprice.Size = new System.Drawing.Size(172, 20);
            this.txtitemprice.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(140, 348);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 36);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(316, 348);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(101, 36);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(823, 423);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtitemprice);
            this.Controls.Add(this.cbitemtype);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtitemno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Additems";
            this.Text = "Additems";
            this.Load += new System.EventHandler(this.Additems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtitemno;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.ComboBox cbitemtype;
        private System.Windows.Forms.TextBox txtitemprice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclose;
    }
}