namespace WindowsFormsApp1
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.lblRush = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblDispTotalCost = new System.Windows.Forms.Label();
            this.lblDispName = new System.Windows.Forms.Label();
            this.lblDispRush = new System.Windows.Forms.Label();
            this.lblDispMaterial = new System.Windows.Forms.Label();
            this.lblDispDrawers = new System.Windows.Forms.Label();
            this.lblDispDepth = new System.Windows.Forms.Label();
            this.lblDispWidth = new System.Windows.Forms.Label();
            this.lblDispCreateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblDispQuoteNo = new System.Windows.Forms.Label();
            this.lblQuoteNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(90, 397);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(138, 41);
            this.btnAddQuote.TabIndex = 22;
            this.btnAddQuote.Text = "Close";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // lblRush
            // 
            this.lblRush.AutoSize = true;
            this.lblRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRush.Location = new System.Drawing.Point(73, 281);
            this.lblRush.Name = "lblRush";
            this.lblRush.Size = new System.Drawing.Size(47, 20);
            this.lblRush.TabIndex = 23;
            this.lblRush.Text = "Rush";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(56, 243);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(65, 20);
            this.lblMaterial.TabIndex = 21;
            this.lblMaterial.Text = "Material";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(55, 203);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(68, 20);
            this.lblDrawers.TabIndex = 18;
            this.lblDrawers.Text = "Drawers";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(69, 160);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(53, 20);
            this.lblDepth.TabIndex = 14;
            this.lblDepth.Text = "Depth";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(73, 119);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 20);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "Width";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(39, 316);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(81, 20);
            this.lblTotalCost.TabIndex = 25;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblDispTotalCost
            // 
            this.lblDispTotalCost.AutoSize = true;
            this.lblDispTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispTotalCost.Location = new System.Drawing.Point(136, 316);
            this.lblDispTotalCost.Name = "lblDispTotalCost";
            this.lblDispTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblDispTotalCost.TabIndex = 32;
            // 
            // lblDispName
            // 
            this.lblDispName.AutoSize = true;
            this.lblDispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispName.Location = new System.Drawing.Point(136, 80);
            this.lblDispName.Name = "lblDispName";
            this.lblDispName.Size = new System.Drawing.Size(0, 20);
            this.lblDispName.TabIndex = 31;
            // 
            // lblDispRush
            // 
            this.lblDispRush.AutoSize = true;
            this.lblDispRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispRush.Location = new System.Drawing.Point(136, 281);
            this.lblDispRush.Name = "lblDispRush";
            this.lblDispRush.Size = new System.Drawing.Size(0, 20);
            this.lblDispRush.TabIndex = 30;
            // 
            // lblDispMaterial
            // 
            this.lblDispMaterial.AutoSize = true;
            this.lblDispMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispMaterial.Location = new System.Drawing.Point(136, 243);
            this.lblDispMaterial.Name = "lblDispMaterial";
            this.lblDispMaterial.Size = new System.Drawing.Size(0, 20);
            this.lblDispMaterial.TabIndex = 29;
            // 
            // lblDispDrawers
            // 
            this.lblDispDrawers.AutoSize = true;
            this.lblDispDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispDrawers.Location = new System.Drawing.Point(136, 203);
            this.lblDispDrawers.Name = "lblDispDrawers";
            this.lblDispDrawers.Size = new System.Drawing.Size(0, 20);
            this.lblDispDrawers.TabIndex = 28;
            // 
            // lblDispDepth
            // 
            this.lblDispDepth.AutoSize = true;
            this.lblDispDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispDepth.Location = new System.Drawing.Point(136, 160);
            this.lblDispDepth.Name = "lblDispDepth";
            this.lblDispDepth.Size = new System.Drawing.Size(0, 20);
            this.lblDispDepth.TabIndex = 27;
            // 
            // lblDispWidth
            // 
            this.lblDispWidth.AutoSize = true;
            this.lblDispWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispWidth.Location = new System.Drawing.Point(136, 119);
            this.lblDispWidth.Name = "lblDispWidth";
            this.lblDispWidth.Size = new System.Drawing.Size(0, 20);
            this.lblDispWidth.TabIndex = 26;
            // 
            // lblDispCreateDate
            // 
            this.lblDispCreateDate.AutoSize = true;
            this.lblDispCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispCreateDate.Location = new System.Drawing.Point(136, 357);
            this.lblDispCreateDate.Name = "lblDispCreateDate";
            this.lblDispCreateDate.Size = new System.Drawing.Size(0, 20);
            this.lblDispCreateDate.TabIndex = 34;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.Location = new System.Drawing.Point(24, 357);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(96, 20);
            this.lblCreateDate.TabIndex = 33;
            this.lblCreateDate.Text = "Create Date";
            // 
            // lblDispQuoteNo
            // 
            this.lblDispQuoteNo.AutoSize = true;
            this.lblDispQuoteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispQuoteNo.Location = new System.Drawing.Point(136, 41);
            this.lblDispQuoteNo.Name = "lblDispQuoteNo";
            this.lblDispQuoteNo.Size = new System.Drawing.Size(0, 20);
            this.lblDispQuoteNo.TabIndex = 36;
            // 
            // lblQuoteNo
            // 
            this.lblQuoteNo.AutoSize = true;
            this.lblQuoteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteNo.Location = new System.Drawing.Point(57, 41);
            this.lblQuoteNo.Name = "lblQuoteNo";
            this.lblQuoteNo.Size = new System.Drawing.Size(66, 20);
            this.lblQuoteNo.TabIndex = 35;
            this.lblQuoteNo.Text = "Quote #";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 460);
            this.Controls.Add(this.lblDispQuoteNo);
            this.Controls.Add(this.lblQuoteNo);
            this.Controls.Add(this.lblDispCreateDate);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblDispTotalCost);
            this.Controls.Add(this.lblDispName);
            this.Controls.Add(this.lblDispRush);
            this.Controls.Add(this.lblDispMaterial);
            this.Controls.Add(this.lblDispDrawers);
            this.Controls.Add(this.lblDispDepth);
            this.Controls.Add(this.lblDispWidth);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.lblRush);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWidth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Label lblRush;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblDispTotalCost;
        private System.Windows.Forms.Label lblDispName;
        private System.Windows.Forms.Label lblDispRush;
        private System.Windows.Forms.Label lblDispMaterial;
        private System.Windows.Forms.Label lblDispDrawers;
        private System.Windows.Forms.Label lblDispDepth;
        private System.Windows.Forms.Label lblDispWidth;
        private System.Windows.Forms.Label lblDispCreateDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblDispQuoteNo;
        private System.Windows.Forms.Label lblQuoteNo;
    }
}