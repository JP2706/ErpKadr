namespace ErpKadr
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.dgvKadr = new System.Windows.Forms.DataGridView();
            this.cbKadr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Zwolnij";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(392, 12);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "Odśwież";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // dgvKadr
            // 
            this.dgvKadr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKadr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKadr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadr.Location = new System.Drawing.Point(13, 51);
            this.dgvKadr.Name = "dgvKadr";
            this.dgvKadr.ReadOnly = true;
            this.dgvKadr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKadr.Size = new System.Drawing.Size(775, 387);
            this.dgvKadr.TabIndex = 4;
            // 
            // cbKadr
            // 
            this.cbKadr.FormattingEnabled = true;
            this.cbKadr.Items.AddRange(new object[] {
            "Wszyscy",
            "Zatrudnieni",
            "Zwolnieni"});
            this.cbKadr.Location = new System.Drawing.Point(256, 13);
            this.cbKadr.Name = "cbKadr";
            this.cbKadr.Size = new System.Drawing.Size(130, 21);
            this.cbKadr.TabIndex = 5;
            this.cbKadr.Text = "Wszyscy";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbKadr);
            this.Controls.Add(this.dgvKadr);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.DataGridView dgvKadr;
        private System.Windows.Forms.ComboBox cbKadr;
    }
}

