namespace ProjectFuelAccounting.Forms;

partial class FormRefuel
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
        labelCar = new Label();
        labelDriver = new Label();
        labelFuelAmount = new Label();
        comboBoxCar = new ComboBox();
        comboBoxDriver = new ComboBox();
        numericUpDownFuelAmount = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownFuelAmount).BeginInit();
        SuspendLayout();
        // 
        // labelCar
        // 
        labelCar.AutoSize = true;
        labelCar.Location = new Point(29, 33);
        labelCar.Name = "labelCar";
        labelCar.Size = new Size(99, 20);
        labelCar.TabIndex = 0;
        labelCar.Text = "Автомобиль:";
        // 
        // labelDriver
        // 
        labelDriver.AutoSize = true;
        labelDriver.Location = new Point(29, 87);
        labelDriver.Name = "labelDriver";
        labelDriver.Size = new Size(77, 20);
        labelDriver.TabIndex = 2;
        labelDriver.Text = "Водитель:";
        // 
        // labelFuelAmount
        // 
        labelFuelAmount.AutoSize = true;
        labelFuelAmount.Location = new Point(29, 140);
        labelFuelAmount.Name = "labelFuelAmount";
        labelFuelAmount.Size = new Size(115, 20);
        labelFuelAmount.TabIndex = 4;
        labelFuelAmount.Text = "Объем ГСМ (л):";
        // 
        // comboBoxCar
        // 
        comboBoxCar.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCar.FormattingEnabled = true;
        comboBoxCar.Location = new Point(171, 29);
        comboBoxCar.Margin = new Padding(3, 4, 3, 4);
        comboBoxCar.Name = "comboBoxCar";
        comboBoxCar.Size = new Size(239, 28);
        comboBoxCar.TabIndex = 1;
        // 
        // comboBoxDriver
        // 
        comboBoxDriver.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDriver.FormattingEnabled = true;
        comboBoxDriver.Location = new Point(171, 83);
        comboBoxDriver.Margin = new Padding(3, 4, 3, 4);
        comboBoxDriver.Name = "comboBoxDriver";
        comboBoxDriver.Size = new Size(239, 28);
        comboBoxDriver.TabIndex = 3;
        // 
        // numericUpDownFuelAmount
        // 
        numericUpDownFuelAmount.DecimalPlaces = 2;
        numericUpDownFuelAmount.Location = new Point(171, 136);
        numericUpDownFuelAmount.Margin = new Padding(3, 4, 3, 4);
        numericUpDownFuelAmount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numericUpDownFuelAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownFuelAmount.Name = "numericUpDownFuelAmount";
        numericUpDownFuelAmount.Size = new Size(137, 27);
        numericUpDownFuelAmount.TabIndex = 5;
        numericUpDownFuelAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(80, 207);
        buttonSave.Margin = new Padding(3, 4, 3, 4);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(114, 40);
        buttonSave.TabIndex = 6;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(246, 207);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(114, 40);
        buttonCancel.TabIndex = 7;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormRefuel
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 280);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(numericUpDownFuelAmount);
        Controls.Add(labelFuelAmount);
        Controls.Add(comboBoxDriver);
        Controls.Add(labelDriver);
        Controls.Add(comboBoxCar);
        Controls.Add(labelCar);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormRefuel";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Заправка ГСМ";
        ((System.ComponentModel.ISupportInitialize)numericUpDownFuelAmount).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelCar;
    private Label labelDriver;
    private Label labelFuelAmount;
    private ComboBox comboBoxCar;
    private ComboBox comboBoxDriver;
    private NumericUpDown numericUpDownFuelAmount;
    private Button buttonSave;
    private Button buttonCancel;
}