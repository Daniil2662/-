namespace Индивидуалка_Форма
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фИОВкладчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозватаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отметкаОВозвратеВкладаDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вкладчикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idzDataSet = new Индивидуалка_Форма.idzDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.вкладчикиTableAdapter = new Индивидуалка_Форма.idzDataSetTableAdapters.ВкладчикиTableAdapter();
            this.tableAdapterManager = new Индивидуалка_Форма.idzDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idzDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОВкладчикаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.паспортныеДанныеDataGridViewTextBoxColumn,
            this.датаВкладаDataGridViewTextBoxColumn,
            this.датаВозватаDataGridViewTextBoxColumn,
            this.кодВкладаDataGridViewTextBoxColumn,
            this.суммаВкладаDataGridViewTextBoxColumn,
            this.суммаВозвратаDataGridViewTextBoxColumn,
            this.отметкаОВозвратеВкладаDataGridViewCheckBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вкладчикиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // фИОВкладчикаDataGridViewTextBoxColumn
            // 
            this.фИОВкладчикаDataGridViewTextBoxColumn.DataPropertyName = "ФИО вкладчика";
            this.фИОВкладчикаDataGridViewTextBoxColumn.HeaderText = "ФИО вкладчика";
            this.фИОВкладчикаDataGridViewTextBoxColumn.Name = "фИОВкладчикаDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // паспортныеДанныеDataGridViewTextBoxColumn
            // 
            this.паспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.Name = "паспортныеДанныеDataGridViewTextBoxColumn";
            // 
            // датаВкладаDataGridViewTextBoxColumn
            // 
            this.датаВкладаDataGridViewTextBoxColumn.DataPropertyName = "Дата вклада";
            this.датаВкладаDataGridViewTextBoxColumn.HeaderText = "Дата вклада";
            this.датаВкладаDataGridViewTextBoxColumn.Name = "датаВкладаDataGridViewTextBoxColumn";
            // 
            // датаВозватаDataGridViewTextBoxColumn
            // 
            this.датаВозватаDataGridViewTextBoxColumn.DataPropertyName = "Дата возвата";
            this.датаВозватаDataGridViewTextBoxColumn.HeaderText = "Дата возвата";
            this.датаВозватаDataGridViewTextBoxColumn.Name = "датаВозватаDataGridViewTextBoxColumn";
            // 
            // кодВкладаDataGridViewTextBoxColumn
            // 
            this.кодВкладаDataGridViewTextBoxColumn.DataPropertyName = "Код вклада";
            this.кодВкладаDataGridViewTextBoxColumn.HeaderText = "Код вклада";
            this.кодВкладаDataGridViewTextBoxColumn.Name = "кодВкладаDataGridViewTextBoxColumn";
            // 
            // суммаВкладаDataGridViewTextBoxColumn
            // 
            this.суммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "Сумма вклада";
            this.суммаВкладаDataGridViewTextBoxColumn.HeaderText = "Сумма вклада";
            this.суммаВкладаDataGridViewTextBoxColumn.Name = "суммаВкладаDataGridViewTextBoxColumn";
            // 
            // суммаВозвратаDataGridViewTextBoxColumn
            // 
            this.суммаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Сумма возврата";
            this.суммаВозвратаDataGridViewTextBoxColumn.HeaderText = "Сумма возврата";
            this.суммаВозвратаDataGridViewTextBoxColumn.Name = "суммаВозвратаDataGridViewTextBoxColumn";
            // 
            // отметкаОВозвратеВкладаDataGridViewCheckBoxColumn
            // 
            this.отметкаОВозвратеВкладаDataGridViewCheckBoxColumn.DataPropertyName = "Отметка о возврате вклада";
            this.отметкаОВозвратеВкладаDataGridViewCheckBoxColumn.HeaderText = "Отметка о возврате вклада";
            this.отметкаОВозвратеВкладаDataGridViewCheckBoxColumn.Name = "отметкаОВозвратеВкладаDataGridViewCheckBoxColumn";
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // вкладчикиBindingSource
            // 
            this.вкладчикиBindingSource.DataMember = "Вкладчики";
            this.вкладчикиBindingSource.DataSource = this.idzDataSet;
            // 
            // idzDataSet
            // 
            this.idzDataSet.DataSetName = "idzDataSet";
            this.idzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // вкладчикиTableAdapter
            // 
            this.вкладчикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Индивидуалка_Форма.idzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВалютаTableAdapter = null;
            this.tableAdapterManager.ВкладчикиTableAdapter = this.вкладчикиTableAdapter;
            this.tableAdapterManager.ВкладыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладчикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idzDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private idzDataSet idzDataSet;
        private System.Windows.Forms.BindingSource вкладчикиBindingSource;
        private idzDataSetTableAdapters.ВкладчикиTableAdapter вкладчикиTableAdapter;
        private idzDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВкладчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеДанныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозватаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn отметкаОВозвратеВкладаDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
    }
}