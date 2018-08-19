namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.lblDUserFullName = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblDUserCode = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblDUserType = new System.Windows.Forms.Label();
            this.lblUserRegion = new System.Windows.Forms.Label();
            this.lblDUserRegion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDUserFullName
            // 
            this.lblDUserFullName.AutoSize = true;
            this.lblDUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUserFullName.Location = new System.Drawing.Point(421, 9);
            this.lblDUserFullName.Name = "lblDUserFullName";
            this.lblDUserFullName.Size = new System.Drawing.Size(65, 12);
            this.lblDUserFullName.TabIndex = 0;
            this.lblDUserFullName.Text = "USERNAME: ";
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.Location = new System.Drawing.Point(344, 9);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(78, 12);
            this.lblUserFullName.TabIndex = 2;
            this.lblUserFullName.Text = "USER NAME :";
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCode.Location = new System.Drawing.Point(518, 9);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(76, 12);
            this.lblUserCode.TabIndex = 3;
            this.lblUserCode.Text = "USER CODE :";
            // 
            // lblDUserCode
            // 
            this.lblDUserCode.AutoSize = true;
            this.lblDUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUserCode.Location = new System.Drawing.Point(591, 9);
            this.lblDUserCode.Name = "lblDUserCode";
            this.lblDUserCode.Size = new System.Drawing.Size(58, 12);
            this.lblDUserCode.TabIndex = 4;
            this.lblDUserCode.Text = "USERCODE";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(660, 9);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(38, 12);
            this.lblUserType.TabIndex = 5;
            this.lblUserType.Text = "TYPE :";
            // 
            // lblDUserType
            // 
            this.lblDUserType.AutoSize = true;
            this.lblDUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUserType.Location = new System.Drawing.Point(698, 9);
            this.lblDUserType.Name = "lblDUserType";
            this.lblDUserType.Size = new System.Drawing.Size(21, 12);
            this.lblDUserType.TabIndex = 6;
            this.lblDUserType.Text = "TYP";
            // 
            // lblUserRegion
            // 
            this.lblUserRegion.AutoSize = true;
            this.lblUserRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRegion.Location = new System.Drawing.Point(727, 9);
            this.lblUserRegion.Name = "lblUserRegion";
            this.lblUserRegion.Size = new System.Drawing.Size(55, 12);
            this.lblUserRegion.TabIndex = 7;
            this.lblUserRegion.Text = "REGION :";
            // 
            // lblDUserRegion
            // 
            this.lblDUserRegion.AutoSize = true;
            this.lblDUserRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUserRegion.Location = new System.Drawing.Point(781, 9);
            this.lblDUserRegion.Name = "lblDUserRegion";
            this.lblDUserRegion.Size = new System.Drawing.Size(12, 12);
            this.lblDUserRegion.TabIndex = 8;
            this.lblDUserRegion.Text = "R";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 290);
            this.dataGridView1.TabIndex = 9;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDUserRegion);
            this.Controls.Add(this.lblUserRegion);
            this.Controls.Add(this.lblDUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblDUserCode);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.lblDUserFullName);
            this.Name = "MainMenu";
            this.Text = "Arcturus - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDUserFullName;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblDUserCode;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblDUserType;
        private System.Windows.Forms.Label lblUserRegion;
        private System.Windows.Forms.Label lblDUserRegion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}