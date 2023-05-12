using DocumentFormat.OpenXml.Office2010.ExcelAc;
using GymManagement.DataSource;
using GymManagement.Model;
using GymManagement.Tools;
using GymManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class TransactionList_UserControl : UserControl
    {
        private readonly GymContext _context = new GymContext();
        public TransactionList_UserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            IQueryable<Transaction> query = _context.Transactions.Include(i => i.User).Include(i => i.Admin).AsNoTracking();
            if (MonthCheck.Checked)
            {
                DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                query = query.Where(i => i.Time >= date);
            }
            if (CurrentYearCheck.Checked)
            {
                DateTime date = new DateTime(DateTime.Now.Year, 1, 1);

                query = query.Where(i => i.Time >= date);
            }

            if (FromDatePicker.GeorgianDate != null)
            {
                var todate = ToDatePicker.GeorgianDate == null ? DateTime.Now : ToDatePicker.GeorgianDate;

                query = query.Where(i => i.Time <= FromDatePicker.GeorgianDate && i.Time >= todate);
            }
            var list = query.ToList();
            var result = list.Select(i => new TransactionViewModel
            {
                UserName = i.User.Name + " " + i.User.Family,
                AdminName = i.Admin.Name + " " + i.Admin.Family,
                Description = i.Description,
                Price = i.Price,
                Time = i.Time.ToPersianDate(),
            }).ToList();

            TransactionGird.DataSource = result;

            TransactionGird.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionGird.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionGird.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionGird.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TransactionGird.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ExcelReport_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PathBox.Text))
            {
                MessageBox.Show("لطفا یک مسیر برای ذخیره سازی وارد کنید.");
                return;
            }
            if(Directory.Exists(PathBox.Text) == false)
            {
                MessageBox.Show("مسیر نامعتبر");
                return;
            }
            if (TransactionGird.Columns.Count == 0)
                return;

            var transaction = new TransactionViewModel();

            var list = new List<TransactionViewModel>();

            for (int i = 0; i < TransactionGird.Rows.Count; i++)
            {
                transaction.UserName = TransactionGird.Rows[i].Cells[0].Value.ToString();
                transaction.Price = double.Parse(TransactionGird.Rows[i].Cells[1].Value.ToString());
                transaction.AdminName = TransactionGird.Rows[i].Cells[2].Value.ToString();
                transaction.Time = TransactionGird.Rows[i].Cells[3].Value.ToString();
                transaction.Description = TransactionGird.Rows[i].Cells[4].Value.ToString();

                list.Add(transaction);
            }

            var result = ExcelReport.GetTransactionReport(list,PathBox.Text);
            MessageBox.Show(result);
        }

        private void PathBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.V && e.Modifiers == Keys.Control)
            {
                (sender as TextBox).Paste();
            }
        }
    }
}
