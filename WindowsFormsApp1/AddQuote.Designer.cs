namespace WindowsFormsApp1
{
    partial class AddQuote
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lstMaterial = new System.Windows.Forms.ListBox();
            this.lstRush = new System.Windows.Forms.ListBox();
            this.lblRush = new System.Windows.Forms.Label();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(43, 79);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(50, 20);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(97, 76);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtWidth_Validating);
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepth.Location = new System.Drawing.Point(97, 117);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 26);
            this.txtDepth.TabIndex = 3;
            this.txtDepth.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepth_Validating);
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(39, 120);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(53, 20);
            this.lblDepth.TabIndex = 2;
            this.lblDepth.Text = "Depth";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(25, 163);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(68, 20);
            this.lblDrawers.TabIndex = 4;
            this.lblDrawers.Text = "Drawers";
            // 
            // numDrawers
            // 
            this.numDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawers.Location = new System.Drawing.Point(97, 160);
            this.numDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(47, 26);
            this.numDrawers.TabIndex = 4;
            this.numDrawers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(26, 203);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(65, 20);
            this.lblMaterial.TabIndex = 6;
            this.lblMaterial.Text = "Material";
            // 
            // lstMaterial
            // 
            this.lstMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaterial.FormattingEnabled = true;
            this.lstMaterial.ItemHeight = 20;
            this.lstMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.lstMaterial.Location = new System.Drawing.Point(97, 203);
            this.lstMaterial.Name = "lstMaterial";
            this.lstMaterial.Size = new System.Drawing.Size(120, 104);
            this.lstMaterial.TabIndex = 5;
            // 
            // lstRush
            // 
            this.lstRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRush.FormattingEnabled = true;
            this.lstRush.ItemHeight = 20;
            this.lstRush.Items.AddRange(new object[] {
            "None",
            "3",
            "5",
            "7"});
            this.lstRush.Location = new System.Drawing.Point(97, 325);
            this.lstRush.Name = "lstRush";
            this.lstRush.Size = new System.Drawing.Size(120, 84);
            this.lstRush.TabIndex = 6;
            // 
            // lblRush
            // 
            this.lblRush.AutoSize = true;
            this.lblRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRush.Location = new System.Drawing.Point(46, 325);
            this.lblRush.Name = "lblRush";
            this.lblRush.Size = new System.Drawing.Size(47, 20);
            this.lblRush.TabIndex = 8;
            this.lblRush.Text = "Rush";
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(97, 434);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(138, 41);
            this.btnAddQuote.TabIndex = 7;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(97, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 497);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.lstRush);
            this.Controls.Add(this.lblRush);
            this.Controls.Add(this.lstMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblWidth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ListBox lstMaterial;
        private System.Windows.Forms.ListBox lstRush;
        private System.Windows.Forms.Label lblRush;
        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}