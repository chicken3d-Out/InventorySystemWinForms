
namespace Beverages_Inventory_System
{
    partial class OverviewSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewOverview = new System.Windows.Forms.DataGridView();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.overviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewPanel
            // 
            this.overviewPanel.Controls.Add(this.btn_search);
            this.overviewPanel.Controls.Add(this.label9);
            this.overviewPanel.Controls.Add(this.searchBy);
            this.overviewPanel.Controls.Add(this.txtSearch);
            this.overviewPanel.Controls.Add(this.btnRefresh);
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewPanel.ForeColor = System.Drawing.Color.White;
            this.overviewPanel.Location = new System.Drawing.Point(0, 0);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(1064, 50);
            this.overviewPanel.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRefresh.Location = new System.Drawing.Point(80, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewOverview
            // 
            this.dataGridViewOverview.AllowUserToAddRows = false;
            this.dataGridViewOverview.AllowUserToOrderColumns = true;
            this.dataGridViewOverview.AllowUserToResizeColumns = false;
            this.dataGridViewOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOverview.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOverview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOverview.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOverview.EnableHeadersVisualStyles = false;
            this.dataGridViewOverview.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewOverview.Name = "dataGridViewOverview";
            this.dataGridViewOverview.RowHeadersVisible = false;
            this.dataGridViewOverview.RowHeadersWidth = 51;
            this.dataGridViewOverview.RowTemplate.Height = 24;
            this.dataGridViewOverview.ShowEditingIcon = false;
            this.dataGridViewOverview.Size = new System.Drawing.Size(1064, 540);
            this.dataGridViewOverview.TabIndex = 6;
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 35;
            this.btn_search.Location = new System.Drawing.Point(992, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 44);
            this.btn_search.TabIndex = 14;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(614, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Search By:";
            // 
            // searchBy
            // 
            this.searchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.searchBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Items.AddRange(new object[] {
            "p.ProductID",
            "Product",
            "Size",
            "Price",
            "Stock",
            "SupplierName",
            "Date_Added"});
            this.searchBy.Location = new System.Drawing.Point(709, 11);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(121, 36);
            this.searchBy.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(836, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 36);
            this.txtSearch.TabIndex = 11;
            // 
            // OverviewSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewOverview);
            this.Controls.Add(this.overviewPanel);
            this.Name = "OverviewSection";
            this.Size = new System.Drawing.Size(1064, 590);
            this.Load += new System.EventHandler(this.OverviewSection_Load);
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewOverview;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
