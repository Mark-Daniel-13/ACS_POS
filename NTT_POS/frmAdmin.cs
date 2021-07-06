using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS
{
    public partial class frmAdmin : Form
    {

        private string selected = "";
        private Color HoverColor;
        bool drag = false;
        Point start = new Point(0, 0);
        // Avoid screen flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        int grip = 16;//for borderless winforms movement
        int caption = 40;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);

                if (p.Y <= caption && p.Y >= grip)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - grip && p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
                if (p.X <= grip && p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)16;
                    return;
                }
                if (p.X <= grip)
                {
                    m.Result = (IntPtr)10;
                    return;
                }
                if (p.X >= ClientSize.Width - grip)
                {
                    m.Result = (IntPtr)11;
                    return;
                }
                if (p.Y <= grip)
                {
                    m.Result = (IntPtr)12;
                    return;
                }
                if (p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)15;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        public frmAdmin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true); //for borderless winforms movement
            var unit = Business.Facades.Security.GetUnitData(Business.Globals.UnitName);
            if (unit.Activate)
            {
                tblpnlSubsNotif.Hide();
            }
            else {
                lblNotif.Text = string.Format("Your free trial ends in {0} days.", Business.Facades.Security.GetRemainingDays(Business.Globals.UnitName));
            }

            SetTheme();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Welcome, {Business.Globals.UserFirstName ?? "User"}";
            LoadButtonClick("Dashboard");
            //tblpnlSupplier.Visible = false;
        }


        private void LoadButtonClick(string name)
        {
            if (name != selected)
            {
                selected = name;
                switch (name)
                {
                    case "Dashboard":
                        LoadDashboard();
                        break;
                    case "Inventory":
                        LoadInvetory();
                        break;
                    case "Report":
                        LoadReport();
                        break;
                    case "Purchase":
                        LoadPurchase();
                        break;
                    case "PurchaseOrder":
                        LoadPurchaseOrder();
                        break;
                    case "PurchaseHistory":
                        LoadPurchaseHistory();
                        break;
                    case "Settings":
                        LoadSetting();
                        break;
                    case "Barcode":
                        LoadBarcode();
                        break;
                }
            }
            else if (name == "Purchase" && selected == "Purchase")
            {
                LoadPurchase();
            }
        }
        private void DisposeChildSubForms() {
            foreach (Control ctrl in pnlMain.Controls)
            {
                if (ctrl.Name != "pnlSubSideBarPurchase")
                {
                    if (ctrl.Controls.Count >= 1) //dispose sub controls
                    {
                        DisposeSubControls(ctrl);
                    }
                    ctrl.Controls.Clear();
                    ctrl.Dispose();
                }
                else
                {
                    if (pnlSubSideBarPurchase.Visible)
                        pnlSubSideBarPurchase.Visible = false;
                }
            }
        }
        private bool DisposeSubControls(Control mainControl) {
            try
            {
                for (int x = mainControl.Controls.Count - 1; x >= 0; --x)
                {
                    var subControl = mainControl.Controls[x];

                    if (subControl.Controls.Count > 1)
                    {
                        foreach (Control ctrl in subControl.Controls)
                        {
                            DisposeSubControls(ctrl);
                        }
                    }

                    subControl.Dispose();
                }
                return true;
            }
            catch {
                return false;
            }
        }
        private void LoadDashboard()
        {
            DisposeChildSubForms();

            SubForms.Admin.frmDashboard frmDashboard = new SubForms.Admin.frmDashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),
            };
            pnlMain.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }
        private void LoadInvetory() {
            DisposeChildSubForms();

            SubForms.Admin.frmInventories frmInventories = new SubForms.Admin.frmInventories
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),

            };

            pnlMain.Controls.Add(frmInventories);
            frmInventories.Show();
        }
        private void LoadReport() {
            DisposeChildSubForms();
            SubForms.Admin.frmReports frmReports = new SubForms.Admin.frmReports
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),
            };
            pnlMain.Controls.Add(frmReports);
            frmReports.Show();
        }
        private void LoadPurchaseOrder()
        {
            DisposeChildSubForms();

            SubForms.Admin.frmPurchaseOrder frmPurchaseOrder = new SubForms.Admin.frmPurchaseOrder
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),
            };
            pnlMain.Controls.Add(frmPurchaseOrder);
            frmPurchaseOrder.Show();
        }
        private void LoadPurchaseHistory()
        {
            DisposeChildSubForms();

            SubForms.Admin.frmPurchaseHistory frmPurchaseHistory = new SubForms.Admin.frmPurchaseHistory
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),
            };
            pnlMain.Controls.Add(frmPurchaseHistory);
            frmPurchaseHistory.Show();
        }
        private void LoadSetting()
        {
            DisposeChildSubForms();

            SubForms.Admin.frmSetting frmSetting = new SubForms.Admin.frmSetting
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),

            };

            pnlMain.Controls.Add(frmSetting);
            frmSetting.Show();
        }
        private void LoadBarcode()
        {
            DisposeChildSubForms();

            SubForms.Admin.frmBarcodeGen frmBarcodeGen = new SubForms.Admin.frmBarcodeGen
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlMain.Size.Width, pnlMain.Size.Height),

            };

            pnlMain.Controls.Add(frmBarcodeGen);
            frmBarcodeGen.Show();
        }
        private void LoadPurchase()
        {
            pnlSubSideBarPurchase.Visible = (pnlSubSideBarPurchase.Visible) ? false : true;
        }
        private void LogOut() {
            // Save Login activity
            var loginHistory = Business.Facades.LoginHistory.UpdateLoginHistory(Business.Globals.LoginHistoryId, true);

            // Open Login Form
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "frmLogin"))
            {
                var frmLogin = (frmLogin)Application.OpenForms["frmLogin"];
                frmLogin.clearFields();
                frmLogin.Show();
                frmLogin.txtUsername.Focus();
            }

            //setting is logged out to true
            Business.Globals.IsLoggedOut = true;

            // Close all forms
            var formsList = Application.OpenForms.Cast<Form>().Where(w => w.Name != "frmLogin").ToList();
            formsList.ForEach(form =>
            {
                form.Close();
            });
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadButtonClick("Dashboard");
            pbTest.BackgroundImage = pbDashboard.BackgroundImage;
            lblButtonName.Text = "Dashboard";
        }
        private void btnInventories_Click(object sender, EventArgs e)
        {
            LoadButtonClick("Inventory");
            pbTest.BackgroundImage = pbProduct.BackgroundImage;
            lblButtonName.Text = "Item List";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadButtonClick("Report");
            pbTest.BackgroundImage = pbReports.BackgroundImage;
            lblButtonName.Text = "Reports";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            LoadButtonClick("Purchase");
            pbTest.BackgroundImage = pbPurchase.BackgroundImage;
            lblButtonName.Text = "Purchase";
        }
        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            LoadPurchaseOrder();
            pbTest.BackgroundImage = pbPurchaseOrder.BackgroundImage;
            lblButtonName.Text = "Purchase Order";
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            LoadPurchaseHistory();
            pbTest.BackgroundImage = pbPurchaseHistory.BackgroundImage;
            lblButtonName.Text = "Purchase History";
        }
        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginHistory = Business.Facades.LoginHistory.UpdateLoginHistory(Business.Globals.LoginHistoryId, true);
            if (loginHistory && !Business.Globals.IsLoggedOut)
            {
                Application.Exit();
            }
        }

        #region HighlightBtn


        private void Highlight(Button btn, PictureBox pb, bool hoverIn = false)
        {
            //hovering done- next click
            var color = (hoverIn) ? HoverColor : Color.Transparent;
            pb.BackColor = color;
            btn.BackColor = color;
            btn.FlatAppearance.MouseOverBackColor = color;
            btn.FlatAppearance.MouseDownBackColor = color;
        }

            #region Button Mouse Enter && Leave
            private void btnInventories_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnInventories,pbProduct, true);
            }

            private void btnReports_MouseEnter(object sender, EventArgs e)
            {
                 Highlight(btnReports,pbReports, true);
            }
            private void btnLogout_MouseEnter(object sender, EventArgs e)
            {
                 Highlight(btnLogout,pbLogout, true);
            }
            private void btnInventories_MouseLeave(object sender, EventArgs e)
            {
                 Highlight(btnInventories,pbProduct);
            }
            private void btnReports_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnReports, pbReports);
            }
            private void btnLogout_MouseLeave(object sender, EventArgs e)
            {
                 Highlight(btnLogout, pbLogout);
            }
            private void btnPurchase_MouseEnter(object sender, EventArgs e)
            {
                 Highlight(btnPurchase, pbPurchase,true);
            }

            private void btnPurchase_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnPurchase, pbPurchase);
            }
            private void btnPurchaseOrder_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnPurchaseOrder, pbPurchaseOrder,true);
            }

            private void btnPurchaseOrder_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnPurchaseOrder, pbPurchaseOrder);
            }

            private void btnPurchaseHistory_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnPurchaseHistory, pbPurchaseHistory,true);
            }

            private void btnPurchaseHistory_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnPurchaseHistory, pbPurchaseHistory);
            }
            private void btnDashboard_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnDashboard, pbDashboard,true);
            }

            private void btnDashboard_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnDashboard, pbDashboard);
            }
            private void btnDatas_MouseLeave(object sender, EventArgs e)
            {
                Highlight(btnSettings, pbSettings);
            }

            private void btnDatas_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnSettings, pbSettings,true);
            }

            private void btnDatas_Click(object sender, EventArgs e)
            {
                LoadButtonClick("Settings");
                pbTest.BackgroundImage = pbSettings.BackgroundImage;
                lblButtonName.Text = "Data Maintenance";
            }

            private void btnBarcode_MouseEnter(object sender, EventArgs e)
            {
                Highlight(btnBarcode, pbBarcode,true);
            }

            private void btnBarcode_MouseLeave(object sender, EventArgs e)
            {
                 Highlight(btnBarcode, pbBarcode);
            }
            private void btnBarcode_Click(object sender, EventArgs e)
            {
                LoadButtonClick("Barcode");
                pbTest.BackgroundImage = pbBarcode.BackgroundImage;
                lblButtonName.Text = "Barcode";
            }


        #endregion

        //Icon Hover
        #region Icon Hover && Click
            private void pbBarcode_MouseLeave(object sender, EventArgs e)
            {
                btnBarcode_MouseLeave(sender,e);
            }

            private void pbBarcode_MouseEnter(object sender, EventArgs e)
            {
                btnBarcode_MouseEnter(sender,e);
            }
            private void pbProduct_MouseEnter(object sender, EventArgs e)
            {
                btnInventories_MouseEnter(sender,e);
            }

            private void pbReports_MouseEnter(object sender, EventArgs e)
            {
                btnReports_MouseEnter(sender,e);
            }
            private void pbLogout_MouseEnter(object sender, EventArgs e)
            {
               btnLogout_MouseEnter(sender, e);
            }

            private void pbProduct_MouseLeave(object sender, EventArgs e)
            {
               btnInventories_MouseLeave(sender,e);
            }

            private void pbReports_MouseLeave(object sender, EventArgs e)
            {
                btnReports_MouseLeave(sender,e);
            }

            private void pbLogout_MouseLeave(object sender, EventArgs e)
            {
                btnLogout_MouseLeave(sender,e);
            }

            private void pbProduct_Click(object sender, EventArgs e)
            {
                LoadInvetory();
            }

            private void pbReports_Click(object sender, EventArgs e)
            {
                LoadReport();
            }
            private void pbPurchaseOrder_Click(object sender, EventArgs e)
            {
                LoadPurchaseOrder();
            }
            private void pbPurchaseHistory_Click(object sender, EventArgs e)
            {
                LoadPurchaseHistory();
            }
            private void pbLogout_Click(object sender, EventArgs e)
            {
                LogOut();
            }
            private void pbPurchase_MouseEnter(object sender, EventArgs e)
            {
                btnPurchase_MouseEnter(sender,e);
            }

            private void pbPurchase_MouseLeave(object sender, EventArgs e)
            {
                btnPurchaseHistory_MouseLeave(sender,e);
            }

            private void pbPurchase_Click(object sender, EventArgs e)
            {
                LoadButtonClick("Purchase");
            }

            private void pbPurchaseOrder_MouseEnter(object sender, EventArgs e)
            {
                btnPurchaseOrder_MouseEnter(sender,e);
            }
            private void pbPurchaseOrder_MouseLeave(object sender, EventArgs e)
            {
               btnPurchaseOrder_MouseLeave(sender,e);
            }
            private void pbPurchaseHistory_MouseEnter(object sender, EventArgs e)
            {
                btnPurchaseHistory_MouseEnter(sender,e);
            }

            private void pbPurchaseHistory_MouseLeave(object sender, EventArgs e)
            {
                btnPurchaseHistory_MouseLeave(sender,e);
            }

            private void pbDashboard_MouseEnter(object sender, EventArgs e)
            {
                btnDashboard_MouseEnter(sender,e);
            }

            private void pbDashboard_MouseLeave(object sender, EventArgs e)
            {
                btnDashboard_MouseLeave(sender,e);
            }

            private void pbDashboard_Click(object sender, EventArgs e)
            {
                LoadDashboard();
            }
            private void pbDatas_Click(object sender, EventArgs e)
            {
                LoadButtonClick("Settings");
            }
            private void pbDatas_MouseEnter(object sender, EventArgs e)
            {
                btnDatas_MouseEnter(sender,e);
            }
            private void pbDatas_MouseLeave(object sender, EventArgs e)
            {
                btnDatas_MouseLeave(sender,e);
            }
            private void pbBarcode_Click(object sender, EventArgs e)
            {
                LoadButtonClick("Barcode");
            }

        #endregion

        #endregion

        #region Custom Titlebar
        private void btnMinimize_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnHide_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void btnMaxMin_Click(object sender, EventArgs e)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.btnMaxMin.Image = Properties.Resources.icons8_restore_down_96;
                    this.WindowState = FormWindowState.Maximized;
                    this.Padding = new Padding(0);
                }
                else {
                    this.btnMaxMin.Image = Properties.Resources.icons8_maximize_window_96;
                    this.WindowState = FormWindowState.Normal;

                    //add border to give user ability resize the form
                    this.Padding = new Padding(2);
                }
            }
            private void pnlNav_MouseUp(object sender, MouseEventArgs e)
            {
                drag = false;
            }
            private void pnlNav_MouseDown(object sender, MouseEventArgs e)
            {
                drag = true;
                start = new Point(e.X, e.Y);
            }

            private void pnlNav_MouseMove(object sender, MouseEventArgs e)
            {
                if (drag) {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - start.X, p.Y - start.Y);
                }
            }


        #endregion

        private void lbActivate_MouseEnter(object sender, EventArgs e)
        {
            lbActivate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void lbActivate_MouseLeave(object sender, EventArgs e)
        {
            lbActivate.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void lbActivate_Click(object sender, EventArgs e)
        {
            using (SubForms.Admin.frmActivatePremium ap = new SubForms.Admin.frmActivatePremium()) {
                if (ap.ShowDialog() == DialogResult.OK) {
                    Helpers.MessageBoxHelper.ShowInformationDialog("You have successfully updated product to PREMIUM!, Please restart your application for the changes to take effect.", "Activation Success!");
                }
            }
        }
        public void SetTheme() {
            if (Business.Globals.LightTheme)
            {
                //panels
                pnlSidebar.BackColor = this.BackColor = Business.Globals.lightButtoncolor;
                pnlNav.BackColor = this.BackColor = Business.Globals.lightButtoncolor;
                pnlSubSideBarPurchase.BackColor = this.BackColor = Business.Globals.lightButtoncolor;
                pnlHeader.BackColor = Color.FromArgb(20, 90, 189);

                btntheme.Text = "Switch to: Dark Theme";
                btntheme.BackColor = Business.Globals.lightButtoncolor;
                
                //buttons
                btnDashboard.BackColor = Color.Transparent;
                btnInventories.BackColor = Color.Transparent;
                btnPurchase.BackColor = Color.Transparent;
                btnReports.BackColor = Color.Transparent;
                btnBarcode.BackColor = Color.Transparent;
                btnSettings.BackColor = Color.Transparent;
                btnLogout.BackColor = Color.Transparent;
                //dashbord
                pbDashboard.BackColor = Color.Transparent;
                pbProduct.BackColor = Color.Transparent;
                pbPurchase.BackColor = Color.Transparent;
                pbReports.BackColor = Color.Transparent;
                pbBarcode.BackColor = Color.Transparent;
                pbSettings.BackColor = Color.Transparent;
                pbLogout.BackColor = Color.Transparent;
                HoverColor = Business.Globals.lightHovercolor;
            }
            else
            {
                //panels
                pnlSidebar.BackColor = this.BackColor = Business.Globals.PanelThemeColorDark;
                pnlNav.BackColor = this.BackColor = Business.Globals.PanelThemeColorDark;
                pnlSubSideBarPurchase.BackColor = this.BackColor = Business.Globals.PanelThemeColorDark;
                pnlHeader.BackColor = Color.DimGray;

                btntheme.Text = "Switch to: Light Theme";
                btntheme.BackColor = Business.Globals.PanelThemeColorDark;
                btnDashboard.BackColor = Color.Transparent;
                btnInventories.BackColor = Color.Transparent;
                btnPurchase.BackColor = Color.Transparent;
                btnReports.BackColor = Color.Transparent;
                btnBarcode.BackColor = Color.Transparent;
                btnSettings.BackColor = Color.Transparent;
                btnLogout.BackColor = Color.Transparent;
                //dashbord
                pbDashboard.BackColor = Color.Transparent;
                pbProduct.BackColor = Color.Transparent;
                pbPurchase.BackColor = Color.Transparent;
                pbReports.BackColor = Color.Transparent;
                pbBarcode.BackColor = Color.Transparent;
                pbSettings.BackColor = Color.Transparent;
                pbLogout.BackColor = Color.Transparent;
                HoverColor = Business.Globals.BackgroundThemeColor;
            }
        }

        private void Btntheme_Click(object sender, EventArgs e)
        {
            Business.Globals.LightTheme = !Business.Globals.LightTheme;
            //update app.config values LightTheme
            if (Business.Globals.LightTheme)
            {
                Business.Helpers.AppSettings.SetSetting("LightTheme", "true");
            }
            else {
                Business.Helpers.AppSettings.SetSetting("LightTheme", "false");
            }

            //reload child form and their siblings if any
            var subFormsList = Application.OpenForms.Cast<Form>().ToList();
            subFormsList.ForEach(form =>
            {
                RefreshChildForm(form.Name);
            });
        }
        private void RefreshChildForm(string formName) {
            switch (formName) {
                case "frmLogin":
                    ((frmLogin)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmAdmin":
                    ((frmAdmin)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmDashboard":
                    ((SubForms.Admin.frmDashboard)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmInventories":
                    ((SubForms.Admin.frmInventories)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmBarcodeGen":
                    ((SubForms.Admin.frmBarcodeGen)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmReports":
                    ((SubForms.Admin.frmReports)Application.OpenForms[formName]).SetTheme();
                    break;
                /////////////////////////////SUBFORMS//////////////////////////////////////////////
                case "frmSetting":
                    ((SubForms.Admin.frmSetting)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmUsers":
                    ((SubForms.Admin.frmUsers)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmSupplier":
                    ((SubForms.Admin.frmSupplier)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmCustomer":
                    ((SubForms.Admin.frmCustomer)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmCategories":
                    ((SubForms.Admin.frmCategories)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmImportExport":
                    ((SubForms.Admin.frmImportExport)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmSales":
                    ((SubForms.Admin.frmSales)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmReceiptTemplateControl":
                    ((SubForms.Admin.frmReceiptTemplateControl)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmReturns":
                    ((SubForms.Admin.frmReturns)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmPurchaseOrder":
                    ((SubForms.Admin.frmPurchaseOrder)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmPurchaseHistory":
                    ((SubForms.Admin.frmPurchaseHistory)Application.OpenForms[formName]).SetTheme();
                    break;
                /////////////////////////////REPORTS//////////////////////////////////////////////
                default:
                    break;
            }
            
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
