namespace ProjectFuelAccounting.Forms;

partial class FormShift
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
        labelDriver = new Label();
        labelCar = new Label();
        labelShiftType = new Label();
        comboBoxDriver = new ComboBox();
        comboBoxCar = new ComboBox();
        comboBoxShiftType = new ComboBox();
        groupBoxRoutes = new GroupBox();
        dataGridViewRoutes = new DataGridView();
        ColumnRoute = new DataGridViewComboBoxColumn();
        ColumnFuelSpent = new DataGridViewTextBoxColumn();
        buttonSave = new Button();
        buttonCancel = new Button();
        groupBoxRoutes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).BeginInit();
        SuspendLayout();
        // 
        // labelDriver
        // 
        labelDriver.AutoSize = true;
        labelDriver.Location = new Point(29, 33);
        labelDriver.Name = "labelDriver";
        labelDriver.Size = new Size(77, 20);
        labelDriver.TabIndex = 0;
        labelDriver.Text = "Водитель:";
        // 
        // labelCar
        // 
        labelCar.AutoSize = true;
        labelCar.Location = new Point(29, 87);
        labelCar.Name = "labelCar";
        labelCar.Size = new Size(99, 20);
        labelCar.TabIndex = 2;
        labelCar.Text = "Автомобиль:";
        // 
        // labelShiftType
        // 
        labelShiftType.AutoSize = true;
        labelShiftType.Location = new Point(29, 140);
        labelShiftType.Name = "labelShiftType";
        labelShiftType.Size = new Size(57, 20);
        labelShiftType.TabIndex = 4;
        labelShiftType.Text = "Смена:";
        // 
        // comboBoxDriver
        // 
        comboBoxDriver.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDriver.FormattingEnabled = true;
        comboBoxDriver.Location = new Point(160, 29);
        comboBoxDriver.Margin = new Padding(3, 4, 3, 4);
        comboBoxDriver.Name = "comboBoxDriver";
        comboBoxDriver.Size = new Size(262, 28);
        comboBoxDriver.TabIndex = 1;
        // 
        // comboBoxCar
        // 
        comboBoxCar.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCar.FormattingEnabled = true;
        comboBoxCar.Location = new Point(160, 83);
        comboBoxCar.Margin = new Padding(3, 4, 3, 4);
        comboBoxCar.Name = "comboBoxCar";
        comboBoxCar.Size = new Size(262, 28);
        comboBoxCar.TabIndex = 3;
        // 
        // comboBoxShiftType
        // 
        comboBoxShiftType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxShiftType.FormattingEnabled = true;
        comboBoxShiftType.Location = new Point(160, 136);
        comboBoxShiftType.Margin = new Padding(3, 4, 3, 4);
        comboBoxShiftType.Name = "comboBoxShiftType";
        comboBoxShiftType.Size = new Size(262, 28);
        comboBoxShiftType.TabIndex = 5;
        // 
        // groupBoxRoutes
        // 
        groupBoxRoutes.Controls.Add(dataGridViewRoutes);
        groupBoxRoutes.Location = new Point(29, 187);
        groupBoxRoutes.Margin = new Padding(3, 4, 3, 4);
        groupBoxRoutes.Name = "groupBoxRoutes";
        groupBoxRoutes.Padding = new Padding(3, 4, 3, 4);
        groupBoxRoutes.Size = new Size(394, 293);
        groupBoxRoutes.TabIndex = 6;
        groupBoxRoutes.TabStop = false;
        groupBoxRoutes.Text = "Маршруты и расход ГСМ";
        // 
        // dataGridViewRoutes
        // 
        dataGridViewRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewRoutes.Columns.AddRange(new DataGridViewColumn[] { ColumnRoute, ColumnFuelSpent });
        dataGridViewRoutes.Dock = DockStyle.Fill;
        dataGridViewRoutes.Location = new Point(3, 24);
        dataGridViewRoutes.Margin = new Padding(3, 4, 3, 4);
        dataGridViewRoutes.Name = "dataGridViewRoutes";
        dataGridViewRoutes.RowHeadersVisible = false;
        dataGridViewRoutes.RowHeadersWidth = 51;
        dataGridViewRoutes.Size = new Size(388, 265);
        dataGridViewRoutes.TabIndex = 0;
        // 
        // ColumnRoute
        // 
        ColumnRoute.HeaderText = "Маршрут";
        ColumnRoute.MinimumWidth = 6;
        ColumnRoute.Name = "ColumnRoute";
        // 
        // ColumnFuelSpent
        // 
        ColumnFuelSpent.HeaderText = "Потрачено (л)";
        ColumnFuelSpent.MinimumWidth = 6;
        ColumnFuelSpent.Name = "ColumnFuelSpent";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(86, 500);
        buttonSave.Margin = new Padding(3, 4, 3, 4);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(114, 40);
        buttonSave.TabIndex = 7;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(251, 500);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(114, 40);
        buttonCancel.TabIndex = 8;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormShift
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(451, 567);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(groupBoxRoutes);
        Controls.Add(comboBoxShiftType);
        Controls.Add(labelShiftType);
        Controls.Add(comboBoxCar);
        Controls.Add(labelCar);
        Controls.Add(comboBoxDriver);
        Controls.Add(labelDriver);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormShift";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Смена";
        groupBoxRoutes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelDriver;
    private Label labelCar;
    private Label labelShiftType;
    private ComboBox comboBoxDriver;
    private ComboBox comboBoxCar;
    private ComboBox comboBoxShiftType;
    private GroupBox groupBoxRoutes;
    private DataGridView dataGridViewRoutes;
    private DataGridViewComboBoxColumn ColumnRoute;
    private DataGridViewTextBoxColumn ColumnFuelSpent;
    private Button buttonSave;
    private Button buttonCancel;
}