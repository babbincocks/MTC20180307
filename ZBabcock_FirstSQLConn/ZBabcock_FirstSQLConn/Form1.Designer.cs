namespace ZBabcock_FirstSQLConn
{
    partial class frmVendor
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
            this.dataGridVend = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVend)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVend
            // 
            this.dataGridVend.AllowUserToOrderColumns = true;
            this.dataGridVend.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridVend.Location = new System.Drawing.Point(12, 12);
            this.dataGridVend.Name = "dataGridVend";
            this.dataGridVend.ReadOnly = true;
            this.dataGridVend.Size = new System.Drawing.Size(694, 341);
            this.dataGridVend.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(580, 359);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 28);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 399);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridVend);
            this.Name = "frmVendor";
            this.Text = "AW Vendor Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVend;
        private System.Windows.Forms.Button btnLoad;
    }
}

