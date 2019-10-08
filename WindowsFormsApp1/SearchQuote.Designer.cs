namespace WindowsFormsApp1
{
    partial class SearchQuote
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
            this.lblSearchQuotes = new System.Windows.Forms.Label();
            this.lstSearchMaterial = new System.Windows.Forms.ListBox();
            this.lblSearchMaterial = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxResults = new System.Windows.Forms.TextBox();
            this.btnSearchClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchQuotes
            // 
            this.lblSearchQuotes.AutoSize = true;
            this.lblSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchQuotes.Location = new System.Drawing.Point(347, 28);
            this.lblSearchQuotes.Name = "lblSearchQuotes";
            this.lblSearchQuotes.Size = new System.Drawing.Size(157, 25);
            this.lblSearchQuotes.TabIndex = 0;
            this.lblSearchQuotes.Text = "Search Quotes";
            // 
            // lstSearchMaterial
            // 
            this.lstSearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchMaterial.FormattingEnabled = true;
            this.lstSearchMaterial.ItemHeight = 20;
            this.lstSearchMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.lstSearchMaterial.Location = new System.Drawing.Point(352, 57);
            this.lstSearchMaterial.Name = "lstSearchMaterial";
            this.lstSearchMaterial.Size = new System.Drawing.Size(120, 104);
            this.lstSearchMaterial.TabIndex = 7;
            // 
            // lblSearchMaterial
            // 
            this.lblSearchMaterial.AutoSize = true;
            this.lblSearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMaterial.Location = new System.Drawing.Point(281, 57);
            this.lblSearchMaterial.Name = "lblSearchMaterial";
            this.lblSearchMaterial.Size = new System.Drawing.Size(65, 20);
            this.lblSearchMaterial.TabIndex = 8;
            this.lblSearchMaterial.Text = "Material";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(370, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxResults
            // 
            this.txtBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResults.Location = new System.Drawing.Point(12, 210);
            this.txtBoxResults.Multiline = true;
            this.txtBoxResults.Name = "txtBoxResults";
            this.txtBoxResults.Size = new System.Drawing.Size(763, 100);
            this.txtBoxResults.TabIndex = 10;
            // 
            // btnSearchClose
            // 
            this.btnSearchClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClose.Location = new System.Drawing.Point(370, 405);
            this.btnSearchClose.Name = "btnSearchClose";
            this.btnSearchClose.Size = new System.Drawing.Size(75, 33);
            this.btnSearchClose.TabIndex = 11;
            this.btnSearchClose.Text = "Close";
            this.btnSearchClose.UseVisualStyleBackColor = true;
            this.btnSearchClose.Click += new System.EventHandler(this.btnSearchClose_Click);
            // 
            // SearchQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchClose);
            this.Controls.Add(this.txtBoxResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstSearchMaterial);
            this.Controls.Add(this.lblSearchMaterial);
            this.Controls.Add(this.lblSearchQuotes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuote";
            this.Text = "Search Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchQuotes;
        private System.Windows.Forms.ListBox lstSearchMaterial;
        private System.Windows.Forms.Label lblSearchMaterial;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxResults;
        private System.Windows.Forms.Button btnSearchClose;
    }
}