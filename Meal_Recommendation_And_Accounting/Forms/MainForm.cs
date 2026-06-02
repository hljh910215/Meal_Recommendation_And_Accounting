using Meal_Recommendation_And_Accounting.Models;
using Meal_Recommendation_And_Accounting.Services;
using Meal_Recommendation_And_Accounting.Services.Meal_Recommendation_And_Accounting.Services;
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
    public partial class MainForm : Form
    {
        private User currentUser;
        private MealService mealService = new MealService();
        private Meal? currentMeal;
        private OrderRecordService orderRecordService = new OrderRecordService();

        public MainForm(User user)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            currentUser = user;
            this.Text = "餐點產生";

            SetDataGridViewStyle();
            InitComboBox();
        }
        private void SetDataGridViewStyle()
        {
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvResult.AllowUserToAddRows = false;
            dgvResult.ReadOnly = true;
            dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResult.MultiSelect = false;
        }

        private void InitComboBox()
        {
            cboArea.Items.Clear();
            cboArea.Items.Add("不限");
            cboArea.Items.Add("新竹");
            cboArea.Items.Add("竹北");
            cboArea.Items.Add("苗栗");
            cboArea.SelectedIndex = 0;

            cboMealTime.Items.Clear();
            cboMealTime.Items.Add("不限");
            cboMealTime.Items.Add("早餐");
            cboMealTime.Items.Add("午餐");
            cboMealTime.Items.Add("晚餐");
            cboMealTime.Items.Add("宵夜");
            cboMealTime.SelectedIndex = 0;

            cboRestaurantType.Items.Clear();
            cboRestaurantType.Items.Add("不限");
            cboRestaurantType.Items.Add("便當店");
            cboRestaurantType.Items.Add("麵店");
            cboRestaurantType.Items.Add("早餐店");
            cboRestaurantType.Items.Add("火鍋店");
            cboRestaurantType.Items.Add("咖哩店");
            cboRestaurantType.SelectedIndex = 0;

            cboMealType.Items.Clear();
            cboMealType.Items.Add("不限");
            cboMealType.Items.Add("飯類");
            cboMealType.Items.Add("麵類");
            cboMealType.Items.Add("蛋餅");
            cboMealType.Items.Add("鍋類");
            cboMealType.SelectedIndex = 0;

            cboPriceRange.Items.Clear();
            cboPriceRange.Items.Add("不限");
            cboPriceRange.Items.Add("100元以下");
            cboPriceRange.Items.Add("101~150元");
            cboPriceRange.Items.Add("151~200元");
            cboPriceRange.Items.Add("201元以上");
            cboPriceRange.SelectedIndex = 0;
        }

        private void ClearResult()
        {
            dgvResult.Text = "尚未產生餐點";
            currentMeal = null;
        }

        private void btnGenerateMeal_Click(object sender, EventArgs e)
        {
            string area = cboArea.Text;
            string mealTime = cboMealTime.Text;
            string restaurantType = cboRestaurantType.Text;
            string mealType = cboMealType.Text;
            string priceRange = cboPriceRange.Text;

            Meal? meal = mealService.GenerateMeal(
                area,
                mealTime,
                restaurantType,
                mealType,
                priceRange);

            if (meal == null)
            {
                MessageBox.Show("找不到符合條件的餐點，請調整篩選條件。");

                dgvResult.DataSource = null;
                currentMeal = null;
                return;
            }

            currentMeal = meal;

            List<Meal> result = new List<Meal>();
            result.Add(meal);

            dgvResult.DataSource = null;
            dgvResult.DataSource = result;
            SetResultColumnHeaders();
        }

        private void btnAddOrderRecord_Click(object sender, EventArgs e)
        {           

            if (currentMeal == null)
            {
                MessageBox.Show("請先產生餐點，再加入訂單紀錄。");
                return;
            }            

            OrderRecordService orderRecordService = new OrderRecordService();

            OrderRecord record = new OrderRecord
            {
                UserId = currentUser.Id,
                MealId = currentMeal.Id,
                MealName = currentMeal.MealName,
                RestaurantName = currentMeal.RestaurantName,
                Amount = currentMeal.Price,
                OrderDate = DateTime.Now,
                Note = "由餐點產生功能加入"
            };

            orderRecordService.AddOrderRecord(record);

            MessageBox.Show("已加入訂單紀錄。");
        }

        private void btnMemberManage_Click(object sender, EventArgs e)
        {
            MemberManageForm form = new MemberManageForm(currentUser);
            form.ShowDialog(this);
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
             {
                dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dgvResult.AllowUserToAddRows = false;
                dgvResult.ReadOnly = true;
                dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvResult.MultiSelect = false;
             }
        }
        private void SetResultColumnHeaders()
        {
            if (dgvResult.Columns["Id"] != null)
            {
                dgvResult.Columns["Id"].HeaderText = "編號";
                dgvResult.Columns["Id"].FillWeight = 50;
            }

            if (dgvResult.Columns["RestaurantId"] != null)
            {
                dgvResult.Columns["RestaurantId"].Visible = false;
            }

            if (dgvResult.Columns["Area"] != null)
            {
                dgvResult.Columns["Area"].HeaderText = "地區";
                dgvResult.Columns["Area"].FillWeight = 80;
            }

            if (dgvResult.Columns["MealTime"] != null)
            {
                dgvResult.Columns["MealTime"].HeaderText = "用餐時段";
                dgvResult.Columns["MealTime"].FillWeight = 90;
            }

            if (dgvResult.Columns["RestaurantType"] != null)
            {
                dgvResult.Columns["RestaurantType"].HeaderText = "餐點類型";
                dgvResult.Columns["RestaurantType"].FillWeight = 100;
            }

            if (dgvResult.Columns["MealType"] != null)
            {
                dgvResult.Columns["MealType"].HeaderText = "品項類型";
                dgvResult.Columns["MealType"].FillWeight = 100;
            }

            if (dgvResult.Columns["RestaurantName"] != null)
            {
                dgvResult.Columns["RestaurantName"].HeaderText = "餐廳名稱";
                dgvResult.Columns["RestaurantName"].FillWeight = 120;
            }

            if (dgvResult.Columns["MealName"] != null)
            {
                dgvResult.Columns["MealName"].HeaderText = "餐點名稱";
                dgvResult.Columns["MealName"].FillWeight = 120;
            }

            if (dgvResult.Columns["Price"] != null)
            {
                dgvResult.Columns["Price"].HeaderText = "價格";
                dgvResult.Columns["Price"].FillWeight = 70;
            }

            if (dgvResult.Columns["Note"] != null)
            {
                dgvResult.Columns["Note"].HeaderText = "備註";
                dgvResult.Columns["Note"].FillWeight = 150;
            }
        }

    }

    
}



