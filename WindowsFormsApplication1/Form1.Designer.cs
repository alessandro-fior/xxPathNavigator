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
            this.XMLfile.Location = new System.Drawing.Point(64, 34);
            this.XMLfile.Margin = new System.Windows.Forms.Padding(2);
            this.XMLfile.Name = "XMLfile";
            this.XMLfile.Size = new System.Drawing.Size(233, 20);
            this.XMLfile.TabIndex = 0;
           // this.XMLfile.TextChanged += new System.EventHandler(this.XMLfile_TextChanged);
            // 
            // outputbox
            // 
            this.outputbox.Location = new System.Drawing.Point(421, 155);
            this.outputbox.Margin = new System.Windows.Forms.Padding(2);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(299, 221);
            this.outputbox.TabIndex = 1;
            // 
            // xpathinput
            // 
            this.xpathinput.Location = new System.Drawing.Point(421, 34);
            this.xpathinput.Margin = new System.Windows.Forms.Padding(2);
            this.xpathinput.Name = "xpathinput";
            this.xpathinput.Size = new System.Drawing.Size(233, 20);
            this.xpathinput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path for XML document:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xpath statement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(664, 33);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(56, 21);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // originalXML
            // 
            this.originalXML.Location = new System.Drawing.Point(64, 86);
            this.originalXML.Margin = new System.Windows.Forms.Padding(2);
            this.originalXML.Multiline = true;
            this.originalXML.Name = "originalXML";
            this.originalXML.Size = new System.Drawing.Size(293, 290);
            this.originalXML.TabIndex = 7;
            // 
            // original
            // 
            this.original.AutoSize = true;
            this.original.Location = new System.Drawing.Point(66, 62);
            this.original.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(67, 13);
            this.original.TabIndex = 8;
            this.original.Text = "Original XML";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(301, 33);
            this.open.Margin = new System.Windows.Forms.Padding(2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(56, 21);
            this.open.TabIndex = 9;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 437);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
