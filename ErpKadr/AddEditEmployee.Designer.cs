namespace ErpKadr
{
    partial class AddEditEmployee
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
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbDateToEmploy = new System.Windows.Forms.Label();
            this.lbPycheck = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnNoConfirm = new System.Windows.Forms.Button();
            this.dtpDTE = new System.Windows.Forms.DateTimePicker();
            this.tbEN = new System.Windows.Forms.TextBox();
            this.lbEN = new System.Windows.Forms.Label();
            this.dtpDSD = new System.Windows.Forms.DateTimePicker();
            this.lbDataSlowDown = new System.Windows.Forms.Label();
            this.nudPycheck = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPycheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(89, 10);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(146, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 39);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Imię:";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(89, 62);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(146, 20);
            this.tbSurname.TabIndex = 5;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(13, 65);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(56, 13);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "Nazwisko:";
            // 
            // lbDateToEmploy
            // 
            this.lbDateToEmploy.AutoSize = true;
            this.lbDateToEmploy.Location = new System.Drawing.Point(13, 91);
            this.lbDateToEmploy.Name = "lbDateToEmploy";
            this.lbDateToEmploy.Size = new System.Drawing.Size(52, 13);
            this.lbDateToEmploy.TabIndex = 6;
            this.lbDateToEmploy.Text = "Data Zat:";
            // 
            // lbPycheck
            // 
            this.lbPycheck.AutoSize = true;
            this.lbPycheck.Location = new System.Drawing.Point(13, 117);
            this.lbPycheck.Name = "lbPycheck";
            this.lbPycheck.Size = new System.Drawing.Size(51, 13);
            this.lbPycheck.TabIndex = 8;
            this.lbPycheck.Text = "Wypłata:";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(13, 167);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 10;
            this.lbComments.Text = "Uwagi:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(89, 167);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(146, 75);
            this.rtbComments.TabIndex = 11;
            this.rtbComments.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(205, 290);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Potwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnNoConfirm
            // 
            this.btnNoConfirm.Location = new System.Drawing.Point(124, 290);
            this.btnNoConfirm.Name = "btnNoConfirm";
            this.btnNoConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNoConfirm.TabIndex = 13;
            this.btnNoConfirm.Text = "Anuluj";
            this.btnNoConfirm.UseVisualStyleBackColor = true;
            this.btnNoConfirm.Click += new System.EventHandler(this.btnNoConfirm_Click);
            // 
            // dtpDTE
            // 
            this.dtpDTE.Location = new System.Drawing.Point(89, 89);
            this.dtpDTE.Name = "dtpDTE";
            this.dtpDTE.Size = new System.Drawing.Size(146, 20);
            this.dtpDTE.TabIndex = 14;
            // 
            // tbEN
            // 
            this.tbEN.Location = new System.Drawing.Point(89, 141);
            this.tbEN.Name = "tbEN";
            this.tbEN.Size = new System.Drawing.Size(146, 20);
            this.tbEN.TabIndex = 16;
            this.tbEN.Tag = "Telefon";
            this.tbEN.Leave += new System.EventHandler(this.tbEN_Leave);
            // 
            // lbEN
            // 
            this.lbEN.AutoSize = true;
            this.lbEN.Location = new System.Drawing.Point(13, 144);
            this.lbEN.Name = "lbEN";
            this.lbEN.Size = new System.Drawing.Size(46, 13);
            this.lbEN.TabIndex = 15;
            this.lbEN.Text = "Telefon:";
            // 
            // dtpDSD
            // 
            this.dtpDSD.Enabled = false;
            this.dtpDSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDSD.Location = new System.Drawing.Point(89, 248);
            this.dtpDSD.Name = "dtpDSD";
            this.dtpDSD.Size = new System.Drawing.Size(146, 20);
            this.dtpDSD.TabIndex = 18;
            // 
            // lbDataSlowDown
            // 
            this.lbDataSlowDown.AutoSize = true;
            this.lbDataSlowDown.Location = new System.Drawing.Point(13, 250);
            this.lbDataSlowDown.Name = "lbDataSlowDown";
            this.lbDataSlowDown.Size = new System.Drawing.Size(57, 13);
            this.lbDataSlowDown.TabIndex = 17;
            this.lbDataSlowDown.Text = "Data Zwo:";
            // 
            // nudPycheck
            // 
            this.nudPycheck.DecimalPlaces = 2;
            this.nudPycheck.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPycheck.Location = new System.Drawing.Point(89, 115);
            this.nudPycheck.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudPycheck.Name = "nudPycheck";
            this.nudPycheck.Size = new System.Drawing.Size(146, 20);
            this.nudPycheck.TabIndex = 19;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 325);
            this.Controls.Add(this.nudPycheck);
            this.Controls.Add(this.dtpDSD);
            this.Controls.Add(this.lbDataSlowDown);
            this.Controls.Add(this.tbEN);
            this.Controls.Add(this.lbEN);
            this.Controls.Add(this.dtpDTE);
            this.Controls.Add(this.btnNoConfirm);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbPycheck);
            this.Controls.Add(this.lbDateToEmploy);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.MaximumSize = new System.Drawing.Size(308, 364);
            this.MinimumSize = new System.Drawing.Size(308, 364);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.nudPycheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbDateToEmploy;
        private System.Windows.Forms.Label lbPycheck;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnNoConfirm;
        private System.Windows.Forms.DateTimePicker dtpDTE;
        private System.Windows.Forms.TextBox tbEN;
        private System.Windows.Forms.Label lbEN;
        private System.Windows.Forms.DateTimePicker dtpDSD;
        private System.Windows.Forms.Label lbDataSlowDown;
        private System.Windows.Forms.NumericUpDown nudPycheck;
    }
}