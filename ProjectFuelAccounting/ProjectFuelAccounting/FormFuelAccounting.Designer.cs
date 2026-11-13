namespace ProjectFuelAccounting;

partial class FormFuelAccounting
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        menuStripMain = new MenuStrip();
        DirectoriesToolStripMenuItem = new ToolStripMenuItem();
        DriversToolStripMenuItem = new ToolStripMenuItem();
        CarsToolStripMenuItem = new ToolStripMenuItem();
        RoutesToolStripMenuItem = new ToolStripMenuItem();
        OperationsToolStripMenuItem = new ToolStripMenuItem();
        RefuelsToolStripMenuItem = new ToolStripMenuItem();
        ShiftsToolStripMenuItem = new ToolStripMenuItem();
        ReportsToolStripMenuItem = new ToolStripMenuItem();
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.ImageScalingSize = new Size(20, 20);
        menuStripMain.Items.AddRange(new ToolStripItem[] { DirectoriesToolStripMenuItem, OperationsToolStripMenuItem, ReportsToolStripMenuItem });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Padding = new Padding(7, 3, 0, 3);
        menuStripMain.Size = new Size(914, 30);
        menuStripMain.TabIndex = 0;
        menuStripMain.Text = "menuStripMain";
        // 
        // DirectoriesToolStripMenuItem
        // 
        DirectoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DriversToolStripMenuItem, CarsToolStripMenuItem, RoutesToolStripMenuItem });
        DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem";
        DirectoriesToolStripMenuItem.Size = new Size(117, 24);
        DirectoriesToolStripMenuItem.Text = "Справочники";
        // 
        // DriversToolStripMenuItem
        // 
        DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
        DriversToolStripMenuItem.Size = new Size(180, 26);
        DriversToolStripMenuItem.Text = "Водители";
        DriversToolStripMenuItem.Click += DriversToolStripMenuItem_Click;
        // 
        // CarsToolStripMenuItem
        // 
        CarsToolStripMenuItem.Name = "CarsToolStripMenuItem";
        CarsToolStripMenuItem.Size = new Size(180, 26);
        CarsToolStripMenuItem.Text = "Автомобили";
        CarsToolStripMenuItem.Click += CarsToolStripMenuItem_Click;
        // 
        // RoutesToolStripMenuItem
        // 
        RoutesToolStripMenuItem.Name = "RoutesToolStripMenuItem";
        RoutesToolStripMenuItem.Size = new Size(180, 26);
        RoutesToolStripMenuItem.Text = "Маршруты";
        RoutesToolStripMenuItem.Click += RoutesToolStripMenuItem_Click;
        // 
        // OperationsToolStripMenuItem
        // 
        OperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RefuelsToolStripMenuItem, ShiftsToolStripMenuItem });
        OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
        OperationsToolStripMenuItem.Size = new Size(95, 24);
        OperationsToolStripMenuItem.Text = "Операции";
        // 
        // RefuelsToolStripMenuItem
        // 
        RefuelsToolStripMenuItem.Name = "RefuelsToolStripMenuItem";
        RefuelsToolStripMenuItem.Size = new Size(158, 26);
        RefuelsToolStripMenuItem.Text = "Заправки";
        RefuelsToolStripMenuItem.Click += RefuelsToolStripMenuItem_Click;
        // 
        // ShiftsToolStripMenuItem
        // 
        ShiftsToolStripMenuItem.Name = "ShiftsToolStripMenuItem";
        ShiftsToolStripMenuItem.Size = new Size(158, 26);
        ShiftsToolStripMenuItem.Text = "Смены";
        ShiftsToolStripMenuItem.Click += ShiftsToolStripMenuItem_Click;
        // 
        // ReportsToolStripMenuItem
        // 
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
        ReportsToolStripMenuItem.Size = new Size(73, 24);
        ReportsToolStripMenuItem.Text = "Отчеты";
        // 
        // FormFuelAccounting
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(menuStripMain);
        MainMenuStrip = menuStripMain;
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormFuelAccounting";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Учет ГСМ";
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStripMain;
    private ToolStripMenuItem DirectoriesToolStripMenuItem;
    private ToolStripMenuItem DriversToolStripMenuItem;
    private ToolStripMenuItem CarsToolStripMenuItem;
    private ToolStripMenuItem RoutesToolStripMenuItem;
    private ToolStripMenuItem OperationsToolStripMenuItem;
    private ToolStripMenuItem RefuelsToolStripMenuItem;
    private ToolStripMenuItem ShiftsToolStripMenuItem;
    private ToolStripMenuItem ReportsToolStripMenuItem;
}