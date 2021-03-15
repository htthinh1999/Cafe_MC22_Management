
namespace Cafe_MC22_Management
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCL = new DevExpress.Utils.ImageCollection(this.components);
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnInformation = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnTutorial = new DevExpress.XtraBars.BarButtonItem();
            this.btnSoftwareInfo = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnTableManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnRevenue = new DevExpress.XtraBars.BarButtonItem();
            this.btnFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnTable = new DevExpress.XtraBars.BarButtonItem();
            this.barAccount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgHelp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgAdmin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabMDI = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMDI)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AutoHideEmptyItems = true;
            this.ribbon.AutoSizeItems = true;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageCL;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogin,
            this.btnChangePass,
            this.btnLogout,
            this.btnInformation,
            this.btnBackup,
            this.btnRestore,
            this.btnTutorial,
            this.btnSoftwareInfo,
            this.skinRibbonGalleryBarItem1,
            this.btnTableManager,
            this.btnRevenue,
            this.btnFood,
            this.btnCategory,
            this.btnTable,
            this.barAccount});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.ShowItemCaptionsInPageHeader = true;
            this.ribbon.Size = new System.Drawing.Size(1094, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // imageCL
            // 
            this.imageCL.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCL.ImageStream")));
            this.imageCL.Images.SetKeyName(0, "add_16x16.png");
            this.imageCL.Images.SetKeyName(1, "add_32x32.png");
            this.imageCL.Images.SetKeyName(2, "clear_16x16.png");
            this.imageCL.Images.SetKeyName(3, "clear_32x32.png");
            this.imageCL.Images.SetKeyName(4, "editname_16x16.png");
            this.imageCL.Images.SetKeyName(5, "editname_32x32.png");
            this.imageCL.Images.SetKeyName(6, "refresh2_32x32.png");
            this.imageCL.Images.SetKeyName(7, "search.png");
            this.imageCL.Images.SetKeyName(8, "search-7-16.png");
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 2;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Enabled = false;
            this.btnChangePass.Id = 3;
            this.btnChangePass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangePass.ImageOptions.SvgImage")));
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 4;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnInformation
            // 
            this.btnInformation.Caption = "Thông tin tài khoản";
            this.btnInformation.Enabled = false;
            this.btnInformation.Id = 5;
            this.btnInformation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInformation.ImageOptions.Image")));
            this.btnInformation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInformation.ImageOptions.LargeImage")));
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInformation_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Enabled = false;
            this.btnBackup.Id = 6;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi dữ liệu";
            this.btnRestore.Enabled = false;
            this.btnRestore.Id = 7;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Caption = "Hướng dẫn";
            this.btnTutorial.Id = 9;
            this.btnTutorial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTutorial.ImageOptions.Image")));
            this.btnTutorial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTutorial.ImageOptions.LargeImage")));
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTutorial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTutorial_ItemClick);
            // 
            // btnSoftwareInfo
            // 
            this.btnSoftwareInfo.Caption = "Thông tin phần mềm";
            this.btnSoftwareInfo.Id = 10;
            this.btnSoftwareInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftwareInfo.ImageOptions.Image")));
            this.btnSoftwareInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoftwareInfo.ImageOptions.LargeImage")));
            this.btnSoftwareInfo.Name = "btnSoftwareInfo";
            this.btnSoftwareInfo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSoftwareInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoftwareInfo_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 12;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnTableManager
            // 
            this.btnTableManager.Caption = "Danh sách các bàn";
            this.btnTableManager.Enabled = false;
            this.btnTableManager.Id = 13;
            this.btnTableManager.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableManager.ImageOptions.Image")));
            this.btnTableManager.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTableManager.ImageOptions.LargeImage")));
            this.btnTableManager.Name = "btnTableManager";
            this.btnTableManager.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTableManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTableManager_ItemClick);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Caption = "Doanh thu";
            this.btnRevenue.Enabled = false;
            this.btnRevenue.Id = 14;
            this.btnRevenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.ImageOptions.Image")));
            this.btnRevenue.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRevenue.ImageOptions.LargeImage")));
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRevenue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRevenue_ItemClick);
            // 
            // btnFood
            // 
            this.btnFood.Caption = "Món ăn";
            this.btnFood.Enabled = false;
            this.btnFood.Id = 15;
            this.btnFood.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFood.ImageOptions.SvgImage")));
            this.btnFood.Name = "btnFood";
            this.btnFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFood_ItemClick);
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Danh mục";
            this.btnCategory.Enabled = false;
            this.btnCategory.Id = 16;
            this.btnCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.Image")));
            this.btnCategory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.LargeImage")));
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFoodCategory_ItemClick);
            // 
            // btnTable
            // 
            this.btnTable.Caption = "Bàn ăn";
            this.btnTable.Enabled = false;
            this.btnTable.Id = 17;
            this.btnTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.ImageOptions.Image")));
            this.btnTable.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTable.ImageOptions.LargeImage")));
            this.btnTable.Name = "btnTable";
            this.btnTable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTableFood_ItemClick);
            // 
            // barAccount
            // 
            this.barAccount.Caption = "Tài khoản";
            this.barAccount.Enabled = false;
            this.barAccount.Id = 18;
            this.barAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAccount.ImageOptions.Image")));
            this.barAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAccount.ImageOptions.LargeImage")));
            this.barAccount.Name = "barAccount";
            this.barAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccount_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.rbpgHelp});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePass);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInformation);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Dữ liệu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Giao diện";
            // 
            // rbpgHelp
            // 
            this.rbpgHelp.ItemLinks.Add(this.btnTutorial);
            this.rbpgHelp.ItemLinks.Add(this.btnSoftwareInfo);
            this.rbpgHelp.Name = "rbpgHelp";
            this.rbpgHelp.Text = "Trợ giúp";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.rbpgAdmin});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTableManager);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nhân viên";
            // 
            // rbpgAdmin
            // 
            this.rbpgAdmin.ItemLinks.Add(this.btnRevenue);
            this.rbpgAdmin.ItemLinks.Add(this.btnFood);
            this.rbpgAdmin.ItemLinks.Add(this.btnCategory);
            this.rbpgAdmin.ItemLinks.Add(this.btnTable);
            this.rbpgAdmin.ItemLinks.Add(this.barAccount);
            this.rbpgAdmin.Name = "rbpgAdmin";
            this.rbpgAdmin.Text = "Quản trị viên";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 600);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1094, 24);
            // 
            // tabMDI
            // 
            this.tabMDI.MdiParent = this;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 624);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "fMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE MC22";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMDI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnInformation;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnTutorial;
        private DevExpress.XtraBars.BarButtonItem btnSoftwareInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgHelp;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.Utils.ImageCollection imageCL;
        private DevExpress.XtraBars.BarButtonItem btnTableManager;
        private DevExpress.XtraBars.BarButtonItem btnRevenue;
        private DevExpress.XtraBars.BarButtonItem btnFood;
        private DevExpress.XtraBars.BarButtonItem btnCategory;
        private DevExpress.XtraBars.BarButtonItem btnTable;
        private DevExpress.XtraBars.BarButtonItem barAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgAdmin;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMDI;
    }
}