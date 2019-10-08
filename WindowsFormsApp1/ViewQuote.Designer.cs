namespace WindowsFormsApp1
{
    partial class ViewQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQuote));
            this.btnListClose = new System.Windows.Forms.Button();
            this.txtBoxListResults = new System.Windows.Forms.TextBox();
            this.lblListQuotes = new System.Windows.Forms.Label();
            this.btnListQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListClose
            // 
            this.btnListClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClose.Location = new System.Drawing.Point(377, 397);
            this.btnListClose.Name = "btnListClose";
            this.btnListClose.Size = new System.Drawing.Size(75, 33);
            this.btnListClose.TabIndex = 17;
            this.btnListClose.Text = "Close";
            this.btnListClose.UseVisualStyleBackColor = true;
            this.btnListClose.Click += new System.EventHandler(this.btnListClose_Click);
            // 
            // txtBoxListResults
            // 
            this.txtBoxListResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxListResults.Location = new System.Drawing.Point(12, 78);
            this.txtBoxListResults.Multiline = true;
            this.txtBoxListResults.Name = "txtBoxListResults";
            this.txtBoxListResults.Size = new System.Drawing.Size(763, 158);
            this.txtBoxListResults.TabIndex = 16;
            // 
            // lblListQuotes
            // 
            this.lblListQuotes.AutoSize = true;
            this.lblListQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListQuotes.Location = new System.Drawing.Point(330, 27);
            this.lblListQuotes.Name = "lblListQuotes";
            this.lblListQuotes.Size = new System.Drawing.Size(153, 25);
            this.lblListQuotes.TabIndex = 12;
            this.lblListQuotes.Text = "List All Quotes";
            // 
            // btnListQuotes
            // 
            this.btnListQuotes.Location = new System.Drawing.Point(377, 242);
            this.btnListQuotes.Name = "btnListQuotes";
            this.btnListQuotes.Size = new System.Drawing.Size(75, 23);
            this.btnListQuotes.TabIndex = 18;
            this.btnListQuotes.Text = "List Quotes";
            this.btnListQuotes.UseVisualStyleBackColor = true;
            this.btnListQuotes.Visible = false;
            this.btnListQuotes.Click += new System.EventHandler(this.btnListQuotes_Click);
            // 
            // ViewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListQuotes);
            this.Controls.Add(this.btnListClose);
            this.Controls.Add(this.txtBoxListResults);
            this.Controls.Add(this.lblListQuotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewQuote";
            this.Text = "ViewQuote";
            this.Load += new System.EventHandler(this.btnListQuotes_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListClose;
        private System.Windows.Forms.TextBox txtBoxListResults;
        private System.Windows.Forms.Label lblListQuotes;
        private System.Windows.Forms.Button btnListQuotes;
    }
}