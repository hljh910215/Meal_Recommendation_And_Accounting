using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal_Recommendation_And_Accounting.Forms
{
    public partial class OrderRecordForm : Form
    {
        private User currentUser;
        private OrderRecordService orderRecordService = new OrderRecordService();

        public OrderRecordForm(User user)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            currentUser = user;
            this.Text = "歷史訂單紀錄 - " + currentUser.Name;

            SetDataGridViewStyle();
            LoadOrderRecords();
        }

        private void SetDataGridViewStyle()
        {
            dgvOrderRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderRecords.AllowUserToAddRows = false;
            dgvOrderRecords.ReadOnly = true;
            dgvOrderRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderRecords.MultiSelect = false;
        }

        private void LoadOrderRecords()
        {
            List<OrderRecord> records = orderRecordService.GetByUserId(currentUser.Id);

            ShowRecords(records);
        }

        private void ShowRecords(List<OrderRecord> records)
        {
            dgvOrderRecords.DataSource = null;
            dgvOrderRecords.DataSource = records;

            SetColumnHeaders();
        }

        private void SetColumnHeaders()
        {
            if (dgvOrderRecords.Columns["Id"] != null)
            {
                dgvOrderRecords.Columns["Id"].HeaderText = "編號";
            }

            if (dgvOrderRecords.Columns["UserId"] != null)
            {
                dgvOrderRecords.Columns["UserId"].Visible = false;
            }

            if (dgvOrderRecords.Columns["MealName"] != null)
            {
                dgvOrderRecords.Columns["MealName"].HeaderText = "餐點名稱";
            }

            if (dgvOrderRecords.Columns["RestaurantName"] != null)
            {
                dgvOrderRecords.Columns["RestaurantName"].HeaderText = "餐廳名稱";
            }

            if (dgvOrderRecords.Columns["Amount"] != null)
            {
                dgvOrderRecords.Columns["Amount"].HeaderText = "金額";
            }

            if (dgvOrderRecords.Columns["OrderDate"] != null)
            {
                dgvOrderRecords.Columns["OrderDate"].HeaderText = "訂單日期";
                dgvOrderRecords.Columns["OrderDate"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm";
            }

            if (dgvOrderRecords.Columns["Note"] != null)
            {
                dgvOrderRecords.Columns["Note"].HeaderText = "備註";
            }

            if (dgvOrderRecords.Columns["IsDeleted"] != null)
            {
                dgvOrderRecords.Columns["IsDeleted"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputDate = txtSearchDate.Text.Trim();

            if (inputDate == "")
            {
                LoadOrderRecords();
                MessageBox.Show("已顯示全部訂單紀錄");
                return;
            }

            DateTime searchDate;

            bool isDate = DateTime.TryParse(inputDate, out searchDate);

            if (isDate == false)
            {
                MessageBox.Show("日期格式錯誤，請輸入例如：2026/06/02");
                return;
            }

            List<OrderRecord> records = orderRecordService.GetByUserIdAndDate(
                currentUser.Id,
                searchDate);

            ShowRecords(records);

            if (records.Count == 0)
            {
                MessageBox.Show("查無搜尋結果");
                return;
            }

            MessageBox.Show("查詢完成，共找到 " + records.Count + " 筆資料");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderRecords.CurrentRow == null)
            {
                MessageBox.Show("請先選擇要刪除的訂單紀錄");
                return;
            }

            OrderRecord record = (OrderRecord)dgvOrderRecords.CurrentRow.DataBoundItem;

            DialogResult confirmResult = MessageBox.Show(
                "確定要刪除這筆訂單紀錄嗎？",
                "刪除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            bool isDeleted = orderRecordService.DeleteOrderRecord(record.Id);

            if (isDeleted)
            {
                MessageBox.Show("刪除成功，畫面將不再顯示這筆資料。");
                LoadOrderRecords();
            }
            else
            {
                MessageBox.Show("刪除失敗，找不到這筆資料。");
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}