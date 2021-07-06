using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Admin
{
    public partial class frmCategories : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        #region Form Field Properties
        private string fCategoryId
        {
            get { return lblCategoryIdValue.Text; }
            set { lblCategoryIdValue.Text = value; }
        }

        private string fCategoryName
        {
            get { return txtCategoryName.Text; }
            set { txtCategoryName.Text = value; }
        }

        private string fCategoryDescription
        {
            get { return txtCategoryDesc.Text; }
            set { txtCategoryDesc.Text = value; }
        }

        private string fSearchText
        {
            get { return txtCategorySearch.Text; }
            set { txtCategorySearch.Text = value; }
        }
        #endregion

        #region Helpers
        private void LoadCategories()
        {
            var categories = Business.Facades.Categories.GetAll();
            if (categories != null)
            {
                dgvCategories.AutoGenerateColumns = false;
                dgvCategories.DataSource = categories.Select(c => new { c.CategoryId, c.Name, c.Description }).ToList();
            }
        }

        private void SearchCategories()
        {
            var categories = Business.Facades.Categories.Search(fSearchText);
            if (categories != null)
            {
                dgvCategories.AutoGenerateColumns = false;
                dgvCategories.DataSource = categories;
            }
        }

        private void ClearFields()
        {
            fCategoryId = string.Empty;
            fCategoryName = string.Empty;
            fCategoryDescription = string.Empty;
        }

        private bool CheckFields(bool checkId = false)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(fCategoryName))
            {
                if (checkId)
                {
                    if (!string.IsNullOrEmpty(fCategoryId))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(fCategoryId))
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        #endregion

        #region Form Events
        public frmCategories()
        {
            InitializeComponent();
            //Set theme
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;
                //Datagrid
                dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvCategories.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvCategories.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //Panel
                panel1.BackColor = Business.Globals.BackgroundThemeColorLight;
                panel2.BackColor = Business.Globals.lightDgvHeadercolor;
                //fonts
                lblCategorySearch.ForeColor = Business.Globals.darkLabelcolor;
                grpCategoryInfo.ForeColor = Business.Globals.darkLabelcolor;
                grpCategoryData.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnUpdateCategory.BackColor = Business.Globals.lightButtoncolor;
                btnAddnewcategory.BackColor = Business.Globals.lightButtoncolor;
                btnAddCategory.BackColor = Business.Globals.lightButtoncolor;
                
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvCategories.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvCategories.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //Panel
                panel1.BackColor = Color.DimGray;
                panel2.BackColor = Business.Globals.PanelThemeColorDark;
                //font
                lblCategorySearch.ForeColor = Business.Globals.lightLabelcolor;
                grpCategoryInfo.ForeColor = Business.Globals.lightLabelcolor;
                grpCategoryData.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnUpdateCategory.BackColor = Business.Globals.darkButtoncolor;
                btnAddnewcategory.BackColor = Business.Globals.darkButtoncolor;
                btnAddCategory.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
            dgvCategories.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
            panel1.Visible = false;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
            //btnAddCategory.Enabled = true;//enable add button
        }
        private bool checkCategoryname(int? CategoryId = null)
        {
            var isCategorynameExist = (CategoryId == null) ? Business.Facades.Categories.CheckcategorynameExist(fCategoryName) : Business.Facades.Categories.CheckcategorynameExist(fCategoryName, Convert.ToInt32(CategoryId));

            if (isCategorynameExist != null) return false;
            return true;
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            bool valid = CheckFields();
            if (valid)
            {
                if (checkCategoryname())
                {

                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the category?", "Confirmation"))
                    {
                        var category = new Business.Models.Categories()
                        {
                            Name = fCategoryName,
                            Description = fCategoryDescription
                        };
                        bool success = Business.Facades.Categories.AddCategory(category);
                        if (success)
                        {
                            LoadCategories();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully added.", "Success");
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error adding category. Please contact your administrator.");
                        }

                    }
                    //Duplicate categoryname
                    
                }
                else
                {
                    string msg = string.Format("Category name {0} is already used! Please try another category name.", fCategoryName);
                    Helpers.MessageBoxHelper.ShowErrorDialog(msg);
                }
            }
           

            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct category information.");
            }
        }

        

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            bool valid = CheckFields(true);
            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update the category?", "Confirmation"))
                {
                    var category = new Business.Models.Categories()
                    {
                        CategoryId = Convert.ToInt32(fCategoryId),
                        Name = fCategoryName,
                        Description = fCategoryDescription
                    };
                    bool success = Business.Facades.Categories.UpdateCategory(category);
                    if (success)
                    {
                        LoadCategories();
                        ClearFields();
                        Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully updated.", "Success");
                        //btnAddCategory.Enabled = true;//enable add button
                        btnAddnewcategory.Visible = true;
                        panel1.Visible = false;
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error updating category. Please contact your Administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct category information.");
            }
           
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fCategoryId))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete the category?", "Confirmation"))
                {
                    bool success = Business.Facades.Categories.DeleteCategory(Convert.ToInt32(fCategoryId));
                    if (success)
                    {
                        if (Business.Facades.Products.RemoveProductRelation(Convert.ToInt32(fCategoryId)))
                        {
                            LoadCategories();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully deleted.", "Success");
                            //btnAddCategory.Enabled = true;//enable add button
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully deleted. But failed to update product relationship.", "Warning");
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting category. Please contact your administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select the category to delete.");
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            //btnAddCategory.Enabled = false; //Disable add button
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    panel1.Visible = true;
                    btnUpdateCategory.Visible = true;
                    btnAddnewcategory.Visible = false;
                    var selectedRow = this.dgvCategories.Rows[e.RowIndex];

                    fCategoryId = selectedRow.Cells["CategoryId"].Value.ToString();
                    fCategoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                    fCategoryDescription = selectedRow.Cells["CategoryDesc"].Value != null ? selectedRow.Cells["CategoryDesc"].Value.ToString() : null;

                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (e.RowIndex >= 0)
                {

                    var selectedRow = this.dgvCategories.Rows[e.RowIndex];

                    fCategoryId = selectedRow.Cells["CategoryId"].Value.ToString();
                    fCategoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                    fCategoryDescription = selectedRow.Cells["CategoryDesc"].Value != null ? selectedRow.Cells["CategoryDesc"].Value.ToString() : null;

                    if (!string.IsNullOrEmpty(fCategoryId))
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete the category?", "Confirmation"))
                        {
                            bool success = Business.Facades.Categories.DeleteCategory(Convert.ToInt32(fCategoryId));
                            if (success)
                            {
                                if (Business.Facades.Products.RemoveProductRelation(Convert.ToInt32(fCategoryId)))
                                {
                                    LoadCategories();
                                    ClearFields();
                                    Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully deleted.", "Success");
                                    //btnAddCategory.Enabled = true;//enable add button
                                }
                                else
                                {
                                    Helpers.MessageBoxHelper.ShowInformationDialog("Category has been successfully deleted. But failed to update product relationship.", "Warning");
                                }
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting category. Please contact your administrator.");
                            }
                        }

                    }
                }
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnAddCategory.Enabled = false; //Disable add button
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvCategories.Rows[e.RowIndex];

                fCategoryId = selectedRow.Cells["CategoryId"].Value.ToString();
                fCategoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                fCategoryDescription = selectedRow.Cells["CategoryDesc"].Value != null ? selectedRow.Cells["CategoryDesc"].Value.ToString() : null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvCategories);
            if (!string.IsNullOrEmpty(fSearchText))
            {
                SearchCategories();
            }
            else
            {
                LoadCategories();
            }
        }

        #endregion

        private void FrmCategories_Resize(object sender, EventArgs e)
        {
            pnlCategories.Left = (this.Width - pnlCategories.Width) / 2;
        }

        private void BtnAddnewcustomer_Click(object sender, EventArgs e)
        {
            btnAddCategory.Visible = true;
            btnUpdateCategory.Visible = false;
            panel1.Visible = !panel1.Visible;
            ClearFields();
            btnAddnewcategory.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            btnAddnewcategory.Visible = true;
        }
    }
}
