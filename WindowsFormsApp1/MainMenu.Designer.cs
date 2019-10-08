namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuote = new System.Windows.Forms.Button();
            this.exitMenu = new System.Windows.Forms.Button();
            this.deskTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskTop)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote.Location = new System.Drawing.Point(25, 23);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(176, 55);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "Add New Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.addQuote_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuote.Location = new System.Drawing.Point(25, 102);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(176, 55);
            this.viewQuote.TabIndex = 1;
            this.viewQuote.Text = "View Quotes";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.viewQuote_Click);
            // 
            // searchQuote
            // 
            this.searchQuote.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuote.Location = new System.Drawing.Point(25, 181);
            this.searchQuote.Name = "searchQuote";
            this.searchQuote.Size = new System.Drawing.Size(176, 55);
            this.searchQuote.TabIndex = 2;
            this.searchQuote.Text = "Search Quotes";
            this.searchQuote.UseVisualStyleBackColor = true;
            this.searchQuote.Click += new System.EventHandler(this.searchQuote_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenu.Location = new System.Drawing.Point(25, 257);
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(176, 55);
            this.exitMenu.TabIndex = 3;
            this.exitMenu.Text = "Exit";
            this.exitMenu.UseVisualStyleBackColor = true;
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // deskTop
            // 
            this.deskTop.Image = ((System.Drawing.Image)(resources.GetObject("deskTop.Image")));
            this.deskTop.Location = new System.Drawing.Point(240, 84);
            this.deskTop.Name = "deskTop";
            this.deskTop.Size = new System.Drawing.Size(176, 186);
            this.deskTop.TabIndex = 4;
            this.deskTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 337);
            this.Controls.Add(this.deskTop);
            this.Controls.Add(this.exitMenu);
            this.Controls.Add(this.searchQuote);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.addQuote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.deskTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuote;
        private System.Windows.Forms.Button exitMenu;
        private System.Windows.Forms.PictureBox deskTop;
    }
}

