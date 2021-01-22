namespace WindowsFormsApplication1
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
            this.XMLfile = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.xpathinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.originalXML = new System.Windows.Forms.TextBox();
            this.original = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // XMLfile
            // 
            this.XMLfile.Location = new System.Drawing.Point(96, 52);
            this.XMLfile.Name = "XMLfile";
            this.XMLfile.Size = new System.Drawing.Size(348, 26);
            this.XMLfile.TabIndex = 0;
            this.XMLfile.Text = "C:\\CUT\\CutTicket.CTX.xml";
            // 
            // outputbox
            // 
            this.outputbox.Location = new System.Drawing.Point(632, 238);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(446, 338);
            this.outputbox.TabIndex = 1;
            // 
            // xpathinput
            // 
            this.xpathinput.Location = new System.Drawing.Point(632, 52);
            this.xpathinput.Name = "xpathinput";
            this.xpathinput.Size = new System.Drawing.Size(348, 26);
            this.xpathinput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path for XML document:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xpath statement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(996, 51);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(84, 32);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // originalXML
            // 
            this.originalXML.Location = new System.Drawing.Point(96, 132);
            this.originalXML.Multiline = true;
            this.originalXML.Name = "originalXML";
            this.originalXML.Size = new System.Drawing.Size(438, 444);
            this.originalXML.TabIndex = 7;
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(99, 95);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(99, 20);
            this.original.TabIndex = 8;
            this.original.Text = "Original XML";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(452, 51);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(84, 32);
            this.open.TabIndex = 9;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(632, 117);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 672);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.original);
            this.Controls.Add(this.originalXML);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xpathinput);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.XMLfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox XMLfile;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.TextBox xpathinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox originalXML;
        private System.Windows.Forms.Label original;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
