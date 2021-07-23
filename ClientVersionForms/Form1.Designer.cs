
namespace ClientVersionForms
{
    partial class VersionClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionClient));
            this.txtLblTitle = new System.Windows.Forms.Label();
            this.txtLblNameClient = new System.Windows.Forms.Label();
            this.txtLblClientVersion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLblTitle
            // 
            this.txtLblTitle.AutoSize = true;
            this.txtLblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtLblTitle.Location = new System.Drawing.Point(232, 9);
            this.txtLblTitle.Name = "txtLblTitle";
            this.txtLblTitle.Size = new System.Drawing.Size(136, 24);
            this.txtLblTitle.TabIndex = 0;
            this.txtLblTitle.Text = "Version Query";
            this.txtLblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLblNameClient
            // 
            this.txtLblNameClient.AutoSize = true;
            this.txtLblNameClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtLblNameClient.Location = new System.Drawing.Point(54, 58);
            this.txtLblNameClient.Name = "txtLblNameClient";
            this.txtLblNameClient.Size = new System.Drawing.Size(112, 22);
            this.txtLblNameClient.TabIndex = 1;
            this.txtLblNameClient.Text = "Client Name";
            this.txtLblNameClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLblClientVersion
            // 
            this.txtLblClientVersion.AutoSize = true;
            this.txtLblClientVersion.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtLblClientVersion.Location = new System.Drawing.Point(419, 58);
            this.txtLblClientVersion.Name = "txtLblClientVersion";
            this.txtLblClientVersion.Size = new System.Drawing.Size(125, 22);
            this.txtLblClientVersion.TabIndex = 2;
            this.txtLblClientVersion.Text = "Client Version";
            this.txtLblClientVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 247);
            this.dataGridView1.TabIndex = 3;
            // 
            // VersionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLblClientVersion);
            this.Controls.Add(this.txtLblNameClient);
            this.Controls.Add(this.txtLblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VersionClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Version";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLblTitle;
        private System.Windows.Forms.Label txtLblNameClient;
        private System.Windows.Forms.Label txtLblClientVersion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

