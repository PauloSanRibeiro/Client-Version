
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BntSearchVersionClient = new System.Windows.Forms.Button();
            this.txtBoxDirectory = new System.Windows.Forms.TextBox();
            this.LblQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLblTitle
            // 
            resources.ApplyResources(this.txtLblTitle, "txtLblTitle");
            this.txtLblTitle.Name = "txtLblTitle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.Url,
            this.Version});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ClientName, "ClientName");
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Url, "Url");
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Version, "Version");
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // BntSearchVersionClient
            // 
            this.BntSearchVersionClient.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BntSearchVersionClient, "BntSearchVersionClient");
            this.BntSearchVersionClient.Name = "BntSearchVersionClient";
            this.BntSearchVersionClient.UseVisualStyleBackColor = false;
            this.BntSearchVersionClient.Click += new System.EventHandler(this.BntSearchVersionClient_Click_1);
            // 
            // txtBoxDirectory
            // 
            resources.ApplyResources(this.txtBoxDirectory, "txtBoxDirectory");
            this.txtBoxDirectory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBoxDirectory.Name = "txtBoxDirectory";
            // 
            // LblQuestion
            // 
            resources.ApplyResources(this.LblQuestion, "LblQuestion");
            this.LblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Click += new System.EventHandler(this.LblQuestion_Click);
            // 
            // VersionClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.txtBoxDirectory);
            this.Controls.Add(this.BntSearchVersionClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VersionClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BntSearchVersionClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.TextBox txtBoxDirectory;
        private System.Windows.Forms.Label LblQuestion;
    }
}

