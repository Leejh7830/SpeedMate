
namespace WindowsFormsApp9.UI
{
    partial class ReceiptView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rclistView = new System.Windows.Forms.ListView();
            this.rcCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcCustTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcCarNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcRepairChk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcGridView = new Sunny.UI.UIDataGridView();
            this.ri_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.rcSelect = new Sunny.UI.UIComboBox();
            this.rcSearch = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.rcSearchItem = new Sunny.UI.UITextBox();
            this.rcFix = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.rcGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rclistView
            // 
            this.rclistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rcCount,
            this.rcData,
            this.rcTotalPrice,
            this.rcStaffName,
            this.rcCustName,
            this.rcCustTel,
            this.rcCarNum,
            this.rcRepairChk});
            this.rclistView.FullRowSelect = true;
            this.rclistView.GridLines = true;
            this.rclistView.HideSelection = false;
            this.rclistView.Location = new System.Drawing.Point(11, 165);
            this.rclistView.Name = "rclistView";
            this.rclistView.Size = new System.Drawing.Size(644, 139);
            this.rclistView.TabIndex = 0;
            this.rclistView.UseCompatibleStateImageBehavior = false;
            this.rclistView.View = System.Windows.Forms.View.Details;
            this.rclistView.SelectedIndexChanged += new System.EventHandler(this.rclistView_SelectedIndexChanged);
            // 
            // rcCount
            // 
            this.rcCount.Text = "번호";
            this.rcCount.Width = 40;
            // 
            // rcData
            // 
            this.rcData.Text = "접수날짜";
            this.rcData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcData.Width = 120;
            // 
            // rcTotalPrice
            // 
            this.rcTotalPrice.Text = "총금액";
            this.rcTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcTotalPrice.Width = 100;
            // 
            // rcStaffName
            // 
            this.rcStaffName.Text = "담당자";
            this.rcStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcStaffName.Width = 80;
            // 
            // rcCustName
            // 
            this.rcCustName.Text = "고객명";
            this.rcCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcCustName.Width = 80;
            // 
            // rcCustTel
            // 
            this.rcCustTel.Text = "고객전화";
            this.rcCustTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcCustTel.Width = 100;
            // 
            // rcCarNum
            // 
            this.rcCarNum.Text = "차량번호";
            this.rcCarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rcRepairChk
            // 
            this.rcRepairChk.Text = "수리상태";
            this.rcRepairChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rcGridView
            // 
            this.rcGridView.AllowUserToAddRows = false;
            this.rcGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rcGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rcGridView.BackgroundColor = System.Drawing.Color.White;
            this.rcGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rcGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rcGridView.ColumnHeadersHeight = 32;
            this.rcGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rcGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ri_count,
            this.ri_item,
            this.ri_price});
            this.rcGridView.EnableHeadersVisualStyles = false;
            this.rcGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rcGridView.Location = new System.Drawing.Point(12, 409);
            this.rcGridView.Name = "rcGridView";
            this.rcGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rcGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.rcGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.rcGridView.RowTemplate.Height = 23;
            this.rcGridView.SelectedIndex = -1;
            this.rcGridView.ShowGridLine = true;
            this.rcGridView.Size = new System.Drawing.Size(643, 165);
            this.rcGridView.TabIndex = 1;
            // 
            // ri_count
            // 
            this.ri_count.HeaderText = "번호";
            this.ri_count.Name = "ri_count";
            this.ri_count.ReadOnly = true;
            // 
            // ri_item
            // 
            this.ri_item.HeaderText = "수리항목";
            this.ri_item.Name = "ri_item";
            this.ri_item.ReadOnly = true;
            // 
            // ri_price
            // 
            this.ri_price.HeaderText = "수리가격";
            this.ri_price.Name = "ri_price";
            this.ri_price.ReadOnly = true;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.exit.Location = new System.Drawing.Point(266, 583);
            this.exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 48);
            this.exit.Style = Sunny.UI.UIStyle.Custom;
            this.exit.Symbol = 61453;
            this.exit.TabIndex = 2;
            this.exit.Text = "닫 기";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(556, 580);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(95, 48);
            this.uiSymbolButton2.Symbol = 61470;
            this.uiSymbolButton2.TabIndex = 3;
            this.uiSymbolButton2.Text = "초기화";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 126);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(142, 33);
            this.uiSymbolLabel1.Symbol = 61508;
            this.uiSymbolLabel1.TabIndex = 4;
            this.uiSymbolLabel1.Text = "접수 현황";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(12, 370);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(177, 33);
            this.uiSymbolLabel2.Symbol = 61613;
            this.uiSymbolLabel2.TabIndex = 5;
            this.uiSymbolLabel2.Text = "상세 수리내역";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(2, 72);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.uiSymbolLabel3.RectSize = 2;
            this.uiSymbolLabel3.Size = new System.Drawing.Size(80, 36);
            this.uiSymbolLabel3.Symbol = 61778;
            this.uiSymbolLabel3.SymbolSize = 15;
            this.uiSymbolLabel3.TabIndex = 6;
            this.uiSymbolLabel3.Text = "검색항목";
            // 
            // rcSelect
            // 
            this.rcSelect.DataSource = null;
            this.rcSelect.FillColor = System.Drawing.Color.White;
            this.rcSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSelect.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.rcSelect.Items.AddRange(new object[] {
            "담당자",
            "접수고객명",
            "접수차량번호"});
            this.rcSelect.Location = new System.Drawing.Point(89, 74);
            this.rcSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rcSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.rcSelect.Name = "rcSelect";
            this.rcSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.rcSelect.Size = new System.Drawing.Size(169, 34);
            this.rcSelect.TabIndex = 7;
            this.rcSelect.Text = "선택";
            this.rcSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rcSearch
            // 
            this.rcSearch.BackColor = System.Drawing.Color.Transparent;
            this.rcSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcSearch.FillColor = System.Drawing.Color.Transparent;
            this.rcSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSearch.ForeColor = System.Drawing.Color.Black;
            this.rcSearch.Location = new System.Drawing.Point(451, 74);
            this.rcSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcSearch.Name = "rcSearch";
            this.rcSearch.Size = new System.Drawing.Size(95, 34);
            this.rcSearch.Style = Sunny.UI.UIStyle.Custom;
            this.rcSearch.Symbol = 61442;
            this.rcSearch.SymbolColor = System.Drawing.Color.Black;
            this.rcSearch.TabIndex = 9;
            this.rcSearch.Text = "검색";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolButton3.Location = new System.Drawing.Point(552, 74);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.Red;
            this.uiSymbolButton3.Size = new System.Drawing.Size(99, 34);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61454;
            this.uiSymbolButton3.SymbolColor = System.Drawing.Color.DarkRed;
            this.uiSymbolButton3.TabIndex = 10;
            this.uiSymbolButton3.Text = "전체검색";
            // 
            // rcSearchItem
            // 
            this.rcSearchItem.ButtonSymbol = 61761;
            this.rcSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rcSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSearchItem.Location = new System.Drawing.Point(266, 74);
            this.rcSearchItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rcSearchItem.Maximum = 2147483647D;
            this.rcSearchItem.Minimum = -2147483648D;
            this.rcSearchItem.MinimumSize = new System.Drawing.Size(1, 16);
            this.rcSearchItem.Name = "rcSearchItem";
            this.rcSearchItem.Size = new System.Drawing.Size(178, 34);
            this.rcSearchItem.TabIndex = 11;
            this.rcSearchItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rcFix
            // 
            this.rcFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcFix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rcFix.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcFix.Location = new System.Drawing.Point(534, 310);
            this.rcFix.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcFix.Name = "rcFix";
            this.rcFix.Size = new System.Drawing.Size(117, 47);
            this.rcFix.Style = Sunny.UI.UIStyle.Custom;
            this.rcFix.TabIndex = 12;
            this.rcFix.Text = "수리완료";
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 643);
            this.ControlBox = false;
            this.Controls.Add(this.rcFix);
            this.Controls.Add(this.rcSearchItem);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.rcSearch);
            this.Controls.Add(this.rcSelect);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rcGridView);
            this.Controls.Add(this.rclistView);
            this.Name = "ReceiptView";
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView rclistView;
        private Sunny.UI.UIDataGridView rcGridView;
        private Sunny.UI.UISymbolButton exit;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private System.Windows.Forms.ColumnHeader rcCount;
        private System.Windows.Forms.ColumnHeader rcData;
        private System.Windows.Forms.ColumnHeader rcTotalPrice;
        private System.Windows.Forms.ColumnHeader rcStaffName;
        private System.Windows.Forms.ColumnHeader rcCustName;
        private System.Windows.Forms.ColumnHeader rcCustTel;
        private System.Windows.Forms.ColumnHeader rcCarNum;
        private System.Windows.Forms.ColumnHeader rcRepairChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_price;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIComboBox rcSelect;
        private Sunny.UI.UISymbolButton rcSearch;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UITextBox rcSearchItem;
        private Sunny.UI.UISymbolButton rcFix;
    }
}