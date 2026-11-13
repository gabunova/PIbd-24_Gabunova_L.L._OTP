namespace ProjectFuelAccounting.Forms;

partial class FormCar
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
        labelBrand = new Label();
        labelCarNumber = new Label();
        labelFuelRate = new Label();
        labelCategory = new Label();
        textBoxBrand = new TextBox();
        textBoxCarNumber = new TextBox();
        numericUpDownFuelRate = new NumericUpDown();
        comboBoxCategory = new ComboBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownFuelRate).BeginInit();
        SuspendLayout();
        // 
        // labelBrand
        // 
        labelBrand.AutoSize = true;
        labelBrand.Location = new Point(29, 33);
        labelBrand.Name = "labelBrand";
        labelBrand.Size = new Size(57, 20);
        labelBrand.TabIndex = 0;
        labelBrand.Text = "Марка:";
        // 
        // labelCarNumber
        // 
        labelCarNumber.AutoSize = true;
        labelCarNumber.Location = new Point(29, 87);
        labelCarNumber.Name = "labelCarNumber";
        labelCarNumber.Size = new Size(81, 20);
        labelCarNumber.TabIndex = 2;
        labelCarNumber.Text = "Госномер:";
        // 
        // labelFuelRate
        // 
        labelFuelRate.AutoSize = true;
        labelFuelRate.Location = new Point(29, 140);
        labelFuelRate.Name = "labelFuelRate";
        labelFuelRate.Size = new Size(142, 20);
        labelFuelRate.TabIndex = 4;
        labelFuelRate.Text = "Норма расхода (л):";
        // 
        // labelCategory
        // 
        labelCategory.AutoSize = true;
        labelCategory.Location = new Point(29, 193);
        labelCategory.Name = "labelCategory";
        labelCategory.Size = new Size(105, 20);
        labelCategory.TabIndex = 6;
        labelCategory.Text = "Категория ТС:";
        // 
        // textBoxBrand
        // 
        textBoxBrand.Location = new Point(183, 26);
        textBoxBrand.Margin = new Padding(3, 4, 3, 4);
        textBoxBrand.Name = "textBoxBrand";
        textBoxBrand.Size = new Size(228, 27);
        textBoxBrand.TabIndex = 1;
        // 
        // textBoxCarNumber
        // 
        textBoxCarNumber.Location = new Point(183, 80);
        textBoxCarNumber.Margin = new Padding(3, 4, 3, 4);
        textBoxCarNumber.Name = "textBoxCarNumber";
        textBoxCarNumber.Size = new Size(228, 27);
        textBoxCarNumber.TabIndex = 3;
        // 
        // numericUpDownFuelRate
        // 
        numericUpDownFuelRate.DecimalPlaces = 2;
        numericUpDownFuelRate.Location = new Point(183, 136);
        numericUpDownFuelRate.Margin = new Padding(3, 4, 3, 4);
        numericUpDownFuelRate.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        numericUpDownFuelRate.Name = "numericUpDownFuelRate";
        numericUpDownFuelRate.Size = new Size(137, 27);
        numericUpDownFuelRate.TabIndex = 5;
        numericUpDownFuelRate.Value = new decimal(new int[] { 1, 0, 0, 65536 });
        // 
        // comboBoxCategory
        // 
        comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCategory.FormattingEnabled = true;
        comboBoxCategory.Location = new Point(183, 189);
        comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
        comboBoxCategory.Name = "comboBoxCategory";
        comboBoxCategory.Size = new Size(228, 28);
        comboBoxCategory.TabIndex = 7;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(80, 260);
        buttonSave.Margin = new Padding(3, 4, 3, 4);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(114, 40);
        buttonSave.TabIndex = 8;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(246, 260);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(114, 40);
        buttonCancel.TabIndex = 9;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormCar
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(446, 333);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(comboBoxCategory);
        Controls.Add(labelCategory);
        Controls.Add(numericUpDownFuelRate);
        Controls.Add(labelFuelRate);
        Controls.Add(textBoxCarNumber);
        Controls.Add(labelCarNumber);
        Controls.Add(textBoxBrand);
        Controls.Add(labelBrand);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormCar";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Автомобиль";
        ((System.ComponentModel.ISupportInitialize)numericUpDownFuelRate).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelBrand;
    private Label labelCarNumber;
    private Label labelFuelRate;
    private Label labelCategory;
    private TextBox textBoxBrand;
    private TextBox textBoxCarNumber;
    private NumericUpDown numericUpDownFuelRate;
    private ComboBox comboBoxCategory;
    private Button buttonSave;
    private Button buttonCancel;
}