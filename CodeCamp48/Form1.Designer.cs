namespace CodeCamp48
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
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.tbDirectQuery = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lbCommandRoots = new System.Windows.Forms.ListBox();
            this.lbParameter1 = new System.Windows.Forms.ListBox();
            this.lbParameter2 = new System.Windows.Forms.ListBox();
            this.lbParameter3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(12, 38);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(75, 23);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "Run";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDirectQuery
            // 
            this.tbDirectQuery.Location = new System.Drawing.Point(12, 12);
            this.tbDirectQuery.Name = "tbDirectQuery";
            this.tbDirectQuery.Size = new System.Drawing.Size(260, 20);
            this.tbDirectQuery.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(197, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Pin Controls";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbCommandRoots
            // 
            this.lbCommandRoots.FormattingEnabled = true;
            this.lbCommandRoots.Items.AddRange(new object[] {
            "pinmode",
            "pullup",
            "read",
            "write"});
            this.lbCommandRoots.Location = new System.Drawing.Point(12, 67);
            this.lbCommandRoots.Name = "lbCommandRoots";
            this.lbCommandRoots.Size = new System.Drawing.Size(48, 69);
            this.lbCommandRoots.TabIndex = 8;
            this.lbCommandRoots.SelectedIndexChanged += new System.EventHandler(this.lbCommandRoots_SelectedIndexChanged);
            // 
            // lbParameter1
            // 
            this.lbParameter1.FormattingEnabled = true;
            this.lbParameter1.Location = new System.Drawing.Point(66, 67);
            this.lbParameter1.Name = "lbParameter1";
            this.lbParameter1.Size = new System.Drawing.Size(48, 69);
            this.lbParameter1.TabIndex = 9;
            this.lbParameter1.SelectedIndexChanged += new System.EventHandler(this.lbParameter1_SelectedIndexChanged);
            // 
            // lbParameter2
            // 
            this.lbParameter2.FormattingEnabled = true;
            this.lbParameter2.Location = new System.Drawing.Point(120, 67);
            this.lbParameter2.Name = "lbParameter2";
            this.lbParameter2.Size = new System.Drawing.Size(48, 69);
            this.lbParameter2.TabIndex = 10;
            this.lbParameter2.SelectedIndexChanged += new System.EventHandler(this.lbParameter2_SelectedIndexChanged);
            // 
            // lbParameter3
            // 
            this.lbParameter3.FormattingEnabled = true;
            this.lbParameter3.Location = new System.Drawing.Point(174, 67);
            this.lbParameter3.Name = "lbParameter3";
            this.lbParameter3.Size = new System.Drawing.Size(48, 69);
            this.lbParameter3.TabIndex = 11;
            this.lbParameter3.SelectedIndexChanged += new System.EventHandler(this.lbParameter3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "RGB Demo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbParameter3);
            this.Controls.Add(this.lbParameter2);
            this.Controls.Add(this.lbParameter1);
            this.Controls.Add(this.lbCommandRoots);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbDirectQuery);
            this.Controls.Add(this.btnRunQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.TextBox tbDirectQuery;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox lbCommandRoots;
        private System.Windows.Forms.ListBox lbParameter1;
        private System.Windows.Forms.ListBox lbParameter2;
        private System.Windows.Forms.ListBox lbParameter3;
        private System.Windows.Forms.Button button1;
    }
}

