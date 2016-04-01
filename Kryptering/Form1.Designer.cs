namespace Kryptering
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDekryptera = new System.Windows.Forms.Button();
            this.btnKrypera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNyckel = new System.Windows.Forms.TextBox();
            this.rbnTecken = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel2.Controls.Add(this.rbnTecken);
            this.splitContainer1.Panel2.Controls.Add(this.btnDekryptera);
            this.splitContainer1.Panel2.Controls.Add(this.btnKrypera);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbxNyckel);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(613, 267);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 210);
            this.textBox1.TabIndex = 4;
            // 
            // btnDekryptera
            // 
            this.btnDekryptera.Location = new System.Drawing.Point(263, 10);
            this.btnDekryptera.Name = "btnDekryptera";
            this.btnDekryptera.Size = new System.Drawing.Size(75, 23);
            this.btnDekryptera.TabIndex = 5;
            this.btnDekryptera.Text = "Dekryptera";
            this.btnDekryptera.UseVisualStyleBackColor = true;
            this.btnDekryptera.Click += new System.EventHandler(this.btnDekryptera_Click);
            // 
            // btnKrypera
            // 
            this.btnKrypera.Location = new System.Drawing.Point(181, 11);
            this.btnKrypera.Name = "btnKrypera";
            this.btnKrypera.Size = new System.Drawing.Size(75, 23);
            this.btnKrypera.TabIndex = 4;
            this.btnKrypera.Text = "Kryptera";
            this.btnKrypera.UseVisualStyleBackColor = true;
            this.btnKrypera.Click += new System.EventHandler(this.btnKrypera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nyckel";
            // 
            // tbxNyckel
            // 
            this.tbxNyckel.Location = new System.Drawing.Point(58, 8);
            this.tbxNyckel.Name = "tbxNyckel";
            this.tbxNyckel.Size = new System.Drawing.Size(100, 20);
            this.tbxNyckel.TabIndex = 2;
            // 
            // rbnTecken
            // 
            this.rbnTecken.AutoSize = true;
            this.rbnTecken.Location = new System.Drawing.Point(358, 11);
            this.rbnTecken.Name = "rbnTecken";
            this.rbnTecken.Size = new System.Drawing.Size(62, 17);
            this.rbnTecken.TabIndex = 6;
            this.rbnTecken.TabStop = true;
            this.rbnTecken.Text = "Tecken";
            this.rbnTecken.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(427, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 267);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNyckel;
        private System.Windows.Forms.Button btnDekryptera;
        private System.Windows.Forms.Button btnKrypera;
        private System.Windows.Forms.RadioButton rbnTecken;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

