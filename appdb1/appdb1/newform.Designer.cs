namespace appdb1
{
    partial class newform
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
            this.deleterec = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.newrec = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // deleterec
            // 
            this.deleterec.Location = new System.Drawing.Point(202, 12);
            this.deleterec.Name = "deleterec";
            this.deleterec.Size = new System.Drawing.Size(75, 23);
            this.deleterec.TabIndex = 0;
            this.deleterec.Text = "Delete record";
            this.deleterec.UseVisualStyleBackColor = true;
            this.deleterec.Click += new System.EventHandler(this.deleterec_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(13, 12);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 1;
            this.load.Text = "load data";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 109);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(589, 150);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // newrec
            // 
            this.newrec.Location = new System.Drawing.Point(491, 12);
            this.newrec.Name = "newrec";
            this.newrec.Size = new System.Drawing.Size(75, 23);
            this.newrec.TabIndex = 3;
            this.newrec.Text = "new record";
            this.newrec.UseVisualStyleBackColor = true;
            this.newrec.Click += new System.EventHandler(this.back_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(333, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 4;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // newform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 262);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.newrec);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.load);
            this.Controls.Add(this.deleterec);
            this.Name = "newform";
            this.Text = "newform";
            this.Load += new System.EventHandler(this.newform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleterec;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button newrec;
        private System.Windows.Forms.Button edit;
    }
}