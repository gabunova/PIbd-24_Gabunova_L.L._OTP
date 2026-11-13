namespace ProjectFuelAccounting.Forms;

partial class FormRoute
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
        labelName = new Label();
        labelDistance = new Label();
        textBoxName = new TextBox();
        numericUpDownDistance = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(29, 33);
        labelName.Name = "labelName";
        labelName.Size = new Size(80, 20);
        labelName.TabIndex = 0;
        labelName.Text = "Название:";
        // 
        // labelDistance
        // 
        labelDistance.AutoSize = true;
        labelDistance.Location = new Point(29, 87);
        labelDistance.Name = "labelDistance";
        labelDistance.Size = new Size(123, 20);
        labelDistance.TabIndex = 2;
        labelDistance.Text = "Расстояние (км):";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(171, 29);
        textBoxName.Margin = new Padding(3, 4, 3, 4);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(239, 27);
        textBoxName.TabIndex = 1;
        // 
        // numericUpDownDistance
        // 
        numericUpDownDistance.DecimalPlaces = 2;
        numericUpDownDistance.Location = new Point(171, 83);
        numericUpDownDistance.Margin = new Padding(3, 4, 3, 4);
        numericUpDownDistance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numericUpDownDistance.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        numericUpDownDistance.Name = "numericUpDownDistance";
        numericUpDownDistance.Size = new Size(137, 27);
        numericUpDownDistance.TabIndex = 3;
        numericUpDownDistance.Value = new decimal(new int[] { 1, 0, 0, 65536 });
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(80, 160);
        buttonSave.Margin = new Padding(3, 4, 3, 4);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(114, 40);
        buttonSave.TabIndex = 4;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(246, 160);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(114, 40);
        buttonCancel.TabIndex = 5;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormRoute
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 233);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(numericUpDownDistance);
        Controls.Add(labelDistance);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormRoute";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Маршрут";
        ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private Label labelDistance;
    private TextBox textBoxName;
    private NumericUpDown numericUpDownDistance;
    private Button buttonSave;
    private Button buttonCancel;
}