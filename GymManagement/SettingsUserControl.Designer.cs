namespace GymManagement
{
    partial class SettingsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SettingGrid = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateSettingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SettingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingGrid
            // 
            this.SettingGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.SettingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SettingGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SettingGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingGrid.Location = new System.Drawing.Point(3, 292);
            this.SettingGrid.Name = "SettingGrid";
            this.SettingGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SettingGrid.RowHeadersWidth = 51;
            this.SettingGrid.RowTemplate.Height = 24;
            this.SettingGrid.Size = new System.Drawing.Size(1265, 319);
            this.SettingGrid.TabIndex = 1;
            this.SettingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SettingGrid_CellContentClick);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(717, 79);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.ShortcutsEnabled = false;
            this.NameBox.Size = new System.Drawing.Size(327, 37);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(717, 173);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.MaxLength = 100;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ShortcutsEnabled = false;
            this.PriceBox.Size = new System.Drawing.Size(327, 37);
            this.PriceBox.TabIndex = 2;
            this.PriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1072, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "نام";
            // 
            // UpdateSettingButton
            // 
            this.UpdateSettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.UpdateSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSettingButton.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateSettingButton.Location = new System.Drawing.Point(214, 110);
            this.UpdateSettingButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateSettingButton.Name = "UpdateSettingButton";
            this.UpdateSettingButton.Size = new System.Drawing.Size(327, 65);
            this.UpdateSettingButton.TabIndex = 3;
            this.UpdateSettingButton.Text = "ثبت";
            this.UpdateSettingButton.UseVisualStyleBackColor = false;
            this.UpdateSettingButton.Click += new System.EventHandler(this.UpdateSettingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1072, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "قیمت";
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateSettingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SettingGrid);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1268, 611);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SettingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SettingGrid;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateSettingButton;
        private System.Windows.Forms.Label label1;
    }
}
