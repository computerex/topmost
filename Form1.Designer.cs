namespace maketopmost
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btntoggle = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntoggle
            // 
            this.btntoggle.Location = new System.Drawing.Point(12, 12);
            this.btntoggle.Name = "btntoggle";
            this.btntoggle.Size = new System.Drawing.Size(75, 23);
            this.btntoggle.TabIndex = 5;
            this.btntoggle.Text = "Toggle";
            this.btntoggle.UseVisualStyleBackColor = true;
            this.btntoggle.Click += new System.EventHandler(this.btntoggle_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(93, 12);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 6;
            this.btnselect.Text = "select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 62);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btntoggle);
            this.Name = "Form1";
            this.Text = "Window customizer";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btntoggle;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label1;
    }
}

