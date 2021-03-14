using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Cafe_MC22_Management
{
    public partial class fFoodCategory : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bindingSource = new BindingSource();

        public fFoodCategory()
        {
            InitializeComponent();
            Init();
        }

        #region Methods

        void Init()
        {
            LoadData();
            BindingData();
        }

        void LoadData()
        {
            gridControl.DataSource = bindingSource;
            bindingSource.DataSource = DAL_FoodCategory.Instance.LoadFoodCategoryList();
            gridView.Columns["ID"].Caption = "Mã danh mục";
            gridView.Columns["Name"].Caption = "Tên danh mục";
        }

        void BindingData()
        {
            txtID.DataBindings.Add(new Binding("Text", bindingSource, "ID"));
            txtCategoryName.DataBindings.Add(new Binding("Text", bindingSource, "Name"));
        }

        bool DataAvailable(bool mustExistCategory)
        {
            if (txtCategoryName.Text.Equals(""))
            {
                XtraMessageBox.Show("Bạn cần phải nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return false;
            }

            if (mustExistCategory != DAL_FoodCategory.Instance.ExistCategory(txtCategoryName.Text))
            {
                XtraMessageBox.Show("Danh mục " + txtCategoryName.Text + ((mustExistCategory) ? " không" : " đã") + " tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Events

        private void fFoodCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DataAvailable(false) && XtraMessageBox.Show("Bạn có muốn thêm danh mục " + txtCategoryName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAL_FoodCategory.Instance.AddFoodCategory(txtCategoryName.Text);
                LoadData();
                XtraMessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DataAvailable(true) && XtraMessageBox.Show("Bạn có muốn sửa danh mục " + txtCategoryName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAL_FoodCategory.Instance.UpdateFoodCategory(txtID.Text, txtCategoryName.Text);
                LoadData();
                XtraMessageBox.Show("Cập nhật thông tin danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DataAvailable(true) && XtraMessageBox.Show("Bạn có muốn xóa danh mục " + txtCategoryName.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAL_FoodCategory.Instance.DeleteFoodCategory(txtID.Text);
                LoadData();
                XtraMessageBox.Show("Xóa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}