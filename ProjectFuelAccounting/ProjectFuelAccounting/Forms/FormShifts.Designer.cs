namespace ProjectFuelAccounting.Forms;

partial class FormShifts
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
        dataGridViewData = new DataGridView();
        panelButtons = new Panel();
        buttonDel = new Button();
        buttonAdd = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
        panelButtons.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridViewData
        // 
        dataGridViewData.AllowUserToAddRows = false;
        dataGridViewData.AllowUserToDeleteRows = false;
        dataGridViewData.AllowUserToResizeColumns = false;
        dataGridViewData.AllowUserToResizeRows = false;
        dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewData.Dock = DockStyle.Fill;
        dataGridViewData.Location = new Point(0, 0);
        dataGridViewData.Margin = new Padding(3, 4, 3, 4);
        dataGridViewData.MultiSelect = false;
        dataGridViewData.Name = "dataGridViewData";
        dataGridViewData.ReadOnly = true;
        dataGridViewData.RowHeadersVisible = false;
        dataGridViewData.RowHeadersWidth = 51;
        dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewData.Size = new Size(777, 600);
        dataGridViewData.TabIndex = 0;
        // 
        // panelButtons
        // 
        panelButtons.Controls.Add(buttonDel);
        panelButtons.Controls.Add(buttonAdd);
        panelButtons.Dock = DockStyle.Right;
        panelButtons.Location = new Point(777, 0);
        panelButtons.Margin = new Padding(3, 4, 3, 4);
        panelButtons.Name = "panelButtons";
        panelButtons.Size = new Size(137, 600);
        panelButtons.TabIndex = 1;
        // 
        // buttonDel
        // 
        buttonDel.Location = new Point(11, 93);
        buttonDel.Margin = new Padding(3, 4, 3, 4);
        buttonDel.Name = "buttonDel";
        buttonDel.Size = new Size(114, 53);
        buttonDel.TabIndex = 1;
        buttonDel.Text = "Удалить";
        buttonDel.UseVisualStyleBackColor = true;
        buttonDel.Click += ButtonDel_Click;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(11, 20);
        buttonAdd.Margin = new Padding(3, 4, 3, 4);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(114, 53);
        buttonAdd.TabIndex = 0;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += ButtonAdd_Click;
        // 
        // FormShifts
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(dataGridViewData);
        Controls.Add(panelButtons);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormShifts";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Смены";
        Load += FormShifts_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
        panelButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewData;
    private Panel panelButtons;
    private Button buttonDel;
    private Button buttonAdd;
}