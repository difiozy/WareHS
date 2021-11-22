
namespace WareHS
{
    partial class MainForm
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Named = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisposalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.chooseDate = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SearcheButton = new System.Windows.Forms.Button();
            this.Searche = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Named,
            this.Price,
            this.ReceiptDate,
            this.ShippingDate,
            this.DisposalDate});
            this.DataTable.Location = new System.Drawing.Point(12, 12);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(643, 397);
            this.DataTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Named
            // 
            this.Named.HeaderText = "name";
            this.Named.Name = "Named";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.HeaderText = "ReceiptDate";
            this.ReceiptDate.Name = "ReceiptDate";
            // 
            // ShippingDate
            // 
            this.ShippingDate.HeaderText = "ShippingDate";
            this.ShippingDate.Name = "ShippingDate";
            // 
            // DisposalDate
            // 
            this.DisposalDate.HeaderText = "DisposalDate";
            this.DisposalDate.Name = "DisposalDate";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(701, 411);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(179, 27);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 415);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // chooseDate
            // 
            this.chooseDate.AllowDrop = true;
            this.chooseDate.FormattingEnabled = true;
            this.chooseDate.Items.AddRange(new object[] {
            "All",
            "Receipt Date",
            "Shipping Date",
            "Disposal Date"});
            this.chooseDate.Location = new System.Drawing.Point(680, 44);
            this.chooseDate.Name = "chooseDate";
            this.chooseDate.Size = new System.Drawing.Size(178, 21);
            this.chooseDate.TabIndex = 5;
            this.chooseDate.Text = "All";
            this.chooseDate.SelectedIndexChanged += new System.EventHandler(this.chooseDate_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(679, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // SearcheButton
            // 
            this.SearcheButton.Location = new System.Drawing.Point(679, 97);
            this.SearcheButton.Name = "SearcheButton";
            this.SearcheButton.Size = new System.Drawing.Size(178, 26);
            this.SearcheButton.TabIndex = 7;
            this.SearcheButton.Text = "Searche";
            this.SearcheButton.UseVisualStyleBackColor = true;
            this.SearcheButton.Click += new System.EventHandler(this.SearcheButton_Click);
            // 
            // Searche
            // 
            this.Searche.AutoSize = true;
            this.Searche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searche.Location = new System.Drawing.Point(729, 12);
            this.Searche.Name = "Searche";
            this.Searche.Size = new System.Drawing.Size(81, 24);
            this.Searche.TabIndex = 9;
            this.Searche.Text = "Searche";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(580, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(174, 415);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 11;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Searche);
            this.Controls.Add(this.SearcheButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chooseDate);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.DataTable);
            this.Name = "MainForm";
            this.Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox chooseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SearcheButton;
        private System.Windows.Forms.Label Searche;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Named;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisposalDate;
    }
}