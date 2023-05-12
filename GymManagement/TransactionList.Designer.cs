namespace GymManagement
{
    partial class TransactionList_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TransactionGird = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentYearCheck = new System.Windows.Forms.CheckBox();
            this.MonthCheck = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.ToDatePicker = new System.Windows.Forms.PersianDatePicker();
            this.ExcelReportButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGird)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionGird
            // 
            this.TransactionGird.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.TransactionGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionGird.DefaultCellStyle = dataGridViewCellStyle4;
            this.TransactionGird.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TransactionGird.Location = new System.Drawing.Point(3, 310);
            this.TransactionGird.Name = "TransactionGird";
            this.TransactionGird.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TransactionGird.RowHeadersWidth = 51;
            this.TransactionGird.RowTemplate.Height = 24;
            this.TransactionGird.Size = new System.Drawing.Size(1265, 301);
            this.TransactionGird.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1084, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "از تاریخ";
            // 
            // CurrentYearCheck
            // 
            this.CurrentYearCheck.AutoSize = true;
            this.CurrentYearCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentYearCheck.Location = new System.Drawing.Point(458, 160);
            this.CurrentYearCheck.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentYearCheck.Name = "CurrentYearCheck";
            this.CurrentYearCheck.Size = new System.Drawing.Size(157, 29);
            this.CurrentYearCheck.TabIndex = 4;
            this.CurrentYearCheck.Text = "تراکنش های امسال";
            this.CurrentYearCheck.UseVisualStyleBackColor = true;
            // 
            // MonthCheck
            // 
            this.MonthCheck.AutoSize = true;
            this.MonthCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCheck.Location = new System.Drawing.Point(458, 82);
            this.MonthCheck.Margin = new System.Windows.Forms.Padding(4);
            this.MonthCheck.Name = "MonthCheck";
            this.MonthCheck.Size = new System.Drawing.Size(163, 29);
            this.MonthCheck.TabIndex = 3;
            this.MonthCheck.Text = "تراکنش های این ماه";
            this.MonthCheck.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Location = new System.Drawing.Point(714, 225);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(327, 65);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1084, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "تا تاریخ";
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.AutoSize = true;
            this.FromDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FromDatePicker.BackColor = System.Drawing.Color.White;
            this.FromDatePicker.GeorgianDate = null;
            this.FromDatePicker.Location = new System.Drawing.Point(714, 86);
            this.FromDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.PersianDate.Day = 0;
            this.FromDatePicker.PersianDate.Month = 0;
            this.FromDatePicker.PersianDate.Year = 0;
            this.FromDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromDatePicker.Size = new System.Drawing.Size(327, 25);
            this.FromDatePicker.TabIndex = 1;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.AutoSize = true;
            this.ToDatePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToDatePicker.BackColor = System.Drawing.Color.White;
            this.ToDatePicker.GeorgianDate = null;
            this.ToDatePicker.Location = new System.Drawing.Point(714, 164);
            this.ToDatePicker.Margin = new System.Windows.Forms.Padding(0);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.PersianDate.Day = 0;
            this.ToDatePicker.PersianDate.Month = 0;
            this.ToDatePicker.PersianDate.Year = 0;
            this.ToDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToDatePicker.Size = new System.Drawing.Size(327, 25);
            this.ToDatePicker.TabIndex = 2;
            // 
            // ExcelReportButton
            // 
            this.ExcelReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.ExcelReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelReportButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExcelReportButton.Location = new System.Drawing.Point(34, 160);
            this.ExcelReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExcelReportButton.Name = "ExcelReportButton";
            this.ExcelReportButton.Size = new System.Drawing.Size(259, 45);
            this.ExcelReportButton.TabIndex = 44;
            this.ExcelReportButton.Text = "گزارش گیری";
            this.ExcelReportButton.UseVisualStyleBackColor = false;
            this.ExcelReportButton.Click += new System.EventHandler(this.ExcelReport_Click);
            // 
            // PathBox
            // 
            this.PathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathBox.Location = new System.Drawing.Point(34, 86);
            this.PathBox.Margin = new System.Windows.Forms.Padding(4);
            this.PathBox.MaxLength = 100;
            this.PathBox.Multiline = true;
            this.PathBox.Name = "PathBox";
            this.PathBox.ShortcutsEnabled = false;
            this.PathBox.Size = new System.Drawing.Size(259, 51);
            this.PathBox.TabIndex = 45;
            this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PathBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PathBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 46;
            this.label2.Text = "مسیر ";
            // 
            // TransactionList_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.ExcelReportButton);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CurrentYearCheck);
            this.Controls.Add(this.MonthCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactionGird);
            this.Name = "TransactionList_UserControl";
            this.Size = new System.Drawing.Size(1268, 611);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CurrentYearCheck;
        private System.Windows.Forms.CheckBox MonthCheck;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView TransactionGird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PersianDatePicker FromDatePicker;
        private System.Windows.Forms.PersianDatePicker ToDatePicker;
        private System.Windows.Forms.Button ExcelReportButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label2;
    }
}
