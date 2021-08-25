
namespace Beverages_Inventory_System
{
    partial class AddStock
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSection = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.usernameNew = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAdd.Location = new System.Drawing.Point(184, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 42);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewStock
            // 
            this.txtNewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewStock.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtNewStock.Location = new System.Drawing.Point(184, 301);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(147, 36);
            this.txtNewStock.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(99, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Stock";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.AutoSize = true;
            this.txtCurrentStock.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtCurrentStock.Location = new System.Drawing.Point(190, 100);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.Size = new System.Drawing.Size(141, 37);
            this.txtCurrentStock.TabIndex = 18;
            this.txtCurrentStock.Text = "ProductID";
            this.txtCurrentStock.Visible = false;
            // 
            // txtProductID
            // 
            this.txtProductID.AutoSize = true;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtProductID.Location = new System.Drawing.Point(177, 189);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(141, 37);
            this.txtProductID.TabIndex = 19;
            this.txtProductID.Text = "ProductID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "ProductID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblSection);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 58);
            this.panel1.TabIndex = 16;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSection.Location = new System.Drawing.Point(12, 9);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(141, 37);
            this.lblSection.TabIndex = 7;
            this.lblSection.Text = "Add Stock";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Exit.IconColor = System.Drawing.Color.Black;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 35;
            this.btn_Exit.Location = new System.Drawing.Point(391, 11);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(45, 36);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // usernameNew
            // 
            this.usernameNew.AutoSize = true;
            this.usernameNew.Location = new System.Drawing.Point(56, 85);
            this.usernameNew.Name = "usernameNew";
            this.usernameNew.Size = new System.Drawing.Size(71, 17);
            this.usernameNew.TabIndex = 23;
            this.usernameNew.Text = "username";
            this.usernameNew.Visible = false;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(439, 467);
            this.Controls.Add(this.usernameNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentStock);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txtCurrentStock;
        public System.Windows.Forms.Label txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSection;
        private FontAwesome.Sharp.IconButton btn_Exit;
        public System.Windows.Forms.Label usernameNew;
    }
}