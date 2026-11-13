namespace ProjectFuelAccounting.Forms;

partial class FormDriver
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
        labelFullName = new Label();
        labelLicenseNumber = new Label();
        labelExperience = new Label();
        labelCategories = new Label();
        textBoxFullName = new TextBox();
        textBoxLicenseNumber = new TextBox();
        numericUpDownExperience = new NumericUpDown();
        checkedListBoxCategories = new CheckedListBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownExperience).BeginInit();
        SuspendLayout();
        // 
        // labelFullName
        // 
        labelFullName.AutoSize = true;
        labelFullName.Location = new Point(29, 33);
        labelFullName.Name = "labelFullName";
        labelFullName.Size = new Size(45, 20);
        labelFullName.TabIndex = 0;
        labelFullName.Text = "ФИО:";
        // 
        // labelLicenseNumber
        // 
        labelLicenseNumber.AutoSize = true;
        labelLicenseNumber.Location = new Point(29, 87);
        labelLicenseNumber.Name = "labelLicenseNumber";
        labelLicenseNumber.Size = new Size(82, 20);
        labelLicenseNumber.TabIndex = 2;
        labelLicenseNumber.Text = "Номер ВУ:";
        // 
        // labelExperience
        // 
        labelExperience.AutoSize = true;
        labelExperience.Location = new Point(29, 140);
        labelExperience.Name = "labelExperience";
        labelExperience.Size = new Size(82, 20);
        labelExperience.TabIndex = 4;
        labelExperience.Text = "Стаж (лет):";
        // 
        // labelCategories
        // 
        labelCategories.AutoSize = true;
        labelCategories.Location = new Point(29, 193);
        labelCategories.Name = "labelCategories";
        labelCategories.Size = new Size(85, 20);
        labelCategories.TabIndex = 6;
        labelCategories.Text = "Категории:";
        // 
        // textBoxFullName
        // 
        textBoxFullName.Location = new Point(171, 29);
        textBoxFullName.Margin = new Padding(3, 4, 3, 4);
        textBoxFullName.Name = "textBoxFullName";
        textBoxFullName.Size = new Size(251, 27);
        textBoxFullName.TabIndex = 1;
        // 
        // textBoxLicenseNumber
        // 
        textBoxLicenseNumber.Location = new Point(171, 83);
        textBoxLicenseNumber.Margin = new Padding(3, 4, 3, 4);
        textBoxLicenseNumber.Name = "textBoxLicenseNumber";
        textBoxLicenseNumber.Size = new Size(251, 27);
        textBoxLicenseNumber.TabIndex = 3;
        // 
        // numericUpDownExperience
        // 
        numericUpDownExperience.Location = new Point(171, 136);
        numericUpDownExperience.Margin = new Padding(3, 4, 3, 4);
        numericUpDownExperience.Name = "numericUpDownExperience";
        numericUpDownExperience.Size = new Size(137, 27);
        numericUpDownExperience.TabIndex = 5;
        // 
        // checkedListBoxCategories
        // 
        checkedListBoxCategories.FormattingEnabled = true;
        checkedListBoxCategories.Location = new Point(171, 193);
        checkedListBoxCategories.Margin = new Padding(3, 4, 3, 4);
        checkedListBoxCategories.Name = "checkedListBoxCategories";
        checkedListBoxCategories.Size = new Size(251, 114);
        checkedListBoxCategories.TabIndex = 7;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(86, 353);
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
        buttonCancel.Location = new Point(257, 353);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(114, 40);
        buttonCancel.TabIndex = 9;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormDriver
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(457, 427);
        Controls.Add(buttonCancel);
        Controls.Add(buttonSave);
        Controls.Add(checkedListBoxCategories);
        Controls.Add(labelCategories);
        Controls.Add(numericUpDownExperience);
        Controls.Add(labelExperience);
        Controls.Add(textBoxLicenseNumber);
        Controls.Add(labelLicenseNumber);
        Controls.Add(textBoxFullName);
        Controls.Add(labelFullName);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormDriver";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Водитель";
        ((System.ComponentModel.ISupportInitialize)numericUpDownExperience).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelFullName;
    private Label labelLicenseNumber;
    private Label labelExperience;
    private Label labelCategories;
    private TextBox textBoxFullName;
    private TextBox textBoxLicenseNumber;
    private NumericUpDown numericUpDownExperience;
    private CheckedListBox checkedListBoxCategories;
    private Button buttonSave;
    private Button buttonCancel;
}