namespace RecipeApp
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
            System.Windows.Forms.Label lblRecipeName;
            this.gvRecipe = new System.Windows.Forms.DataGridView();
            this.viewbtn = new System.Windows.Forms.Button();
            this.sqLiteConnection = new System.Data.SQLite.SQLiteConnection();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtNumServings = new System.Windows.Forms.TextBox();
            this.txtPrepTime = new System.Windows.Forms.TextBox();
            this.lblNumServings = new System.Windows.Forms.Label();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.btnaddrecipe = new System.Windows.Forms.Button();
            lblRecipeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRecipe
            // 
            this.gvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecipe.Location = new System.Drawing.Point(420, 49);
            this.gvRecipe.Name = "gvRecipe";
            this.gvRecipe.Size = new System.Drawing.Size(474, 398);
            this.gvRecipe.TabIndex = 0;
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(13, 13);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 1;
            this.viewbtn.Text = "View Recipe";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // sqLiteConnection
            // 
            this.sqLiteConnection.BusyTimeout = 0;
            this.sqLiteConnection.ConnectionString = "data source=C:\\Users\\Maria\\sqlite_databases\\recipes.db";
            this.sqLiteConnection.DefaultDbType = null;
            this.sqLiteConnection.DefaultTimeout = 30;
            this.sqLiteConnection.DefaultTypeName = null;
            this.sqLiteConnection.Flags = System.Data.SQLite.SQLiteConnectionFlags.None;
            this.sqLiteConnection.ParseViaFramework = false;
            this.sqLiteConnection.PrepareRetries = 3;
            this.sqLiteConnection.ProgressOps = 0;
            this.sqLiteConnection.VfsName = null;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(122, 99);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(270, 20);
            this.txtRecipeName.TabIndex = 3;
            // 
            // txtNumServings
            // 
            this.txtNumServings.Location = new System.Drawing.Point(122, 125);
            this.txtNumServings.Name = "txtNumServings";
            this.txtNumServings.Size = new System.Drawing.Size(270, 20);
            this.txtNumServings.TabIndex = 4;
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(122, 151);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(270, 20);
            this.txtPrepTime.TabIndex = 5;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new System.Drawing.Point(16, 99);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new System.Drawing.Size(72, 13);
            lblRecipeName.TabIndex = 6;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblNumServings
            // 
            this.lblNumServings.AutoSize = true;
            this.lblNumServings.Location = new System.Drawing.Point(16, 125);
            this.lblNumServings.Name = "lblNumServings";
            this.lblNumServings.Size = new System.Drawing.Size(100, 13);
            this.lblNumServings.TabIndex = 7;
            this.lblNumServings.Text = "Number of Servings";
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Location = new System.Drawing.Point(16, 151);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(87, 13);
            this.lblPrepTime.TabIndex = 8;
            this.lblPrepTime.Text = "Preparation Time";
            // 
            // btnaddrecipe
            // 
            this.btnaddrecipe.Location = new System.Drawing.Point(217, 177);
            this.btnaddrecipe.Name = "btnaddrecipe";
            this.btnaddrecipe.Size = new System.Drawing.Size(75, 23);
            this.btnaddrecipe.TabIndex = 9;
            this.btnaddrecipe.Text = "Add Recipe";
            this.btnaddrecipe.UseVisualStyleBackColor = true;
            this.btnaddrecipe.Click += new System.EventHandler(this.btnaddrecipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 457);
            this.Controls.Add(this.btnaddrecipe);
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.lblNumServings);
            this.Controls.Add(lblRecipeName);
            this.Controls.Add(this.txtPrepTime);
            this.Controls.Add(this.txtNumServings);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.gvRecipe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRecipe;
        private System.Windows.Forms.Button viewbtn;
        private System.Data.SQLite.SQLiteConnection sqLiteConnection;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtNumServings;
        private System.Windows.Forms.TextBox txtPrepTime;
        private System.Windows.Forms.Label lblNumServings;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Button btnaddrecipe;
    }
}

