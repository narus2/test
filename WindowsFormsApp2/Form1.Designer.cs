namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.salesTableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.SalesTableAdapter();
            this.listColums = new System.Windows.Forms.ListView();
            this.DateDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateDoc,
            this.Firm,
            this.City,
            this.Contry,
            this.Manager,
            this.Counts,
            this.Sums});
            this.dataGridView.DataSource = this.salesBindingSource;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(13, 60);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(625, 327);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.VirtualMode = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // listColums
            // 
            this.listColums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listColums.CheckBoxes = true;
            this.listColums.Location = new System.Drawing.Point(644, 60);
            this.listColums.Name = "listColums";
            this.listColums.Size = new System.Drawing.Size(187, 327);
            this.listColums.TabIndex = 2;
            this.listColums.UseCompatibleStateImageBehavior = false;
            this.listColums.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listColums_ItemChecked);
            // 
            // DateDoc
            // 
            this.DateDoc.DataPropertyName = "DateDoc";
            this.DateDoc.HeaderText = "DateDoc";
            this.DateDoc.Name = "DateDoc";
            // 
            // Firm
            // 
            this.Firm.DataPropertyName = "Firm";
            this.Firm.HeaderText = "Firm";
            this.Firm.Name = "Firm";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Contry
            // 
            this.Contry.DataPropertyName = "Contry";
            this.Contry.HeaderText = "Contry";
            this.Contry.Name = "Contry";
            // 
            // Manager
            // 
            this.Manager.DataPropertyName = "Manager";
            this.Manager.HeaderText = "Manager";
            this.Manager.Name = "Manager";
            // 
            // Counts
            // 
            this.Counts.DataPropertyName = "Counts";
            this.Counts.HeaderText = "Counts";
            this.Counts.Name = "Counts";
            // 
            // Sums
            // 
            this.Sums.DataPropertyName = "Sums";
            this.Sums.HeaderText = "Sums";
            this.Sums.Name = "Sums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.listColums);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Тест Носенко";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DataSet1TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView listColums;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sums;
    }
}

