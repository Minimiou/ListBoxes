namespace ListBoxes
{
    partial class frmMain
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
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.lblRemoveInstructions = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.lblAddInstructions = new System.Windows.Forms.Label();
            this.lblselectnum = new System.Windows.Forms.Label();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveHero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnRemoveHero.Location = new System.Drawing.Point(386, 266);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(102, 29);
            this.btnRemoveHero.TabIndex = 71;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = false;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnAddHero.Location = new System.Drawing.Point(397, 204);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(87, 29);
            this.btnAddHero.TabIndex = 70;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = false;
            // 
            // txtAddHero
            // 
            this.txtAddHero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHero.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtAddHero.Location = new System.Drawing.Point(262, 204);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(133, 29);
            this.txtAddHero.TabIndex = 69;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveHero.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtRemoveHero.Location = new System.Drawing.Point(262, 266);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(122, 29);
            this.txtRemoveHero.TabIndex = 68;
            // 
            // lblRemoveInstructions
            // 
            this.lblRemoveInstructions.AutoSize = true;
            this.lblRemoveInstructions.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveInstructions.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblRemoveInstructions.Location = new System.Drawing.Point(260, 242);
            this.lblRemoveInstructions.Name = "lblRemoveInstructions";
            this.lblRemoveInstructions.Size = new System.Drawing.Size(238, 22);
            this.lblRemoveInstructions.TabIndex = 67;
            this.lblRemoveInstructions.Text = "Enter a hero name to remove:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblStatus.Location = new System.Drawing.Point(12, 276);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 22);
            this.lblStatus.TabIndex = 66;
            this.lblStatus.Text = "Status:";
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveAllNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAllNumbers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumbers.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(107, 204);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(112, 29);
            this.btnRemoveAllNumbers.TabIndex = 65;
            this.btnRemoveAllNumbers.Text = "Remove All";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = false;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveNumber.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnRemoveNumber.Location = new System.Drawing.Point(12, 204);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(93, 29);
            this.btnRemoveNumber.TabIndex = 64;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // lblAddInstructions
            // 
            this.lblAddInstructions.AutoSize = true;
            this.lblAddInstructions.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInstructions.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAddInstructions.Location = new System.Drawing.Point(260, 179);
            this.lblAddInstructions.Name = "lblAddInstructions";
            this.lblAddInstructions.Size = new System.Drawing.Size(211, 22);
            this.lblAddInstructions.TabIndex = 63;
            this.lblAddInstructions.Text = "Enter a hero name to add:";
            // 
            // lblselectnum
            // 
            this.lblselectnum.AutoSize = true;
            this.lblselectnum.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectnum.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblselectnum.Location = new System.Drawing.Point(10, 179);
            this.lblselectnum.Name = "lblselectnum";
            this.lblselectnum.Size = new System.Drawing.Size(213, 22);
            this.lblselectnum.TabIndex = 62;
            this.lblselectnum.Text = "Select a number to remove";
            // 
            // lstHeroes
            // 
            this.lstHeroes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeroes.ForeColor = System.Drawing.Color.SlateBlue;
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.ItemHeight = 22;
            this.lstHeroes.Location = new System.Drawing.Point(262, 74);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(208, 92);
            this.lstHeroes.TabIndex = 61;
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.ForeColor = System.Drawing.Color.SlateBlue;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 22;
            this.lstNumbers.Location = new System.Drawing.Point(12, 74);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(207, 92);
            this.lstNumbers.TabIndex = 60;
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblHeroes.Location = new System.Drawing.Point(260, 12);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(63, 22);
            this.lblHeroes.TabIndex = 59;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblNumbers.Location = new System.Drawing.Point(10, 12);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(78, 22);
            this.lblNumbers.TabIndex = 58;
            this.lblNumbers.Text = "Numbers";
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSortHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortHeroes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortHeroes.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSortHeroes.Location = new System.Drawing.Point(373, 39);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(97, 29);
            this.btnSortHeroes.TabIndex = 57;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = false;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNewHeroes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewHeroes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHeroes.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnNewHeroes.Location = new System.Drawing.Point(262, 39);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(97, 29);
            this.btnNewHeroes.TabIndex = 56;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = false;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSortNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNumbers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNumbers.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSortNumbers.Location = new System.Drawing.Point(122, 39);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(97, 29);
            this.btnSortNumbers.TabIndex = 55;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = false;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNewNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNumbers.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnNewNumbers.Location = new System.Drawing.Point(12, 39);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(97, 29);
            this.btnNewNumbers.TabIndex = 54;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = false;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblRemoveInstructions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblAddInstructions);
            this.Controls.Add(this.lblselectnum);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMain";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Label lblRemoveInstructions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Label lblAddInstructions;
        private System.Windows.Forms.Label lblselectnum;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewNumbers;
    }
}

