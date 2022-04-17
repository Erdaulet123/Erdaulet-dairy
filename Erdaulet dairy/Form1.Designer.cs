
namespace Erdaulet_dairy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label fullNameLabel;
            this.database = new Erdaulet_dairy.Database();
            this.phoneBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.phoneBooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            mobileLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingNavigator)).BeginInit();
            this.phoneBooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneBooksBindingSource
            // 
            this.phoneBooksBindingSource.DataMember = "PhoneBooks";
            this.phoneBooksBindingSource.DataSource = this.database;
            // 
            // phoneBooksBindingNavigator
            // 
            this.phoneBooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phoneBooksBindingNavigator.BindingSource = this.phoneBooksBindingSource;
            this.phoneBooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phoneBooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phoneBooksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phoneBooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phoneBooksBindingNavigatorSaveItem});
            this.phoneBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phoneBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phoneBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phoneBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phoneBooksBindingNavigator.Name = "phoneBooksBindingNavigator";
            this.phoneBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phoneBooksBindingNavigator.Size = new System.Drawing.Size(1231, 27);
            this.phoneBooksBindingNavigator.TabIndex = 0;
            this.phoneBooksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // phoneBooksBindingNavigatorSaveItem
            // 
            this.phoneBooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneBooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneBooksBindingNavigatorSaveItem.Image")));
            this.phoneBooksBindingNavigatorSaveItem.Name = "phoneBooksBindingNavigatorSaveItem";
            this.phoneBooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.phoneBooksBindingNavigatorSaveItem.Text = "Save Data";
            this.phoneBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneBooksBindingNavigatorSaveItem_Click);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(106, 371);
            this.mobileTextBox.Multiline = true;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(300, 22);
            this.mobileTextBox.TabIndex = 6;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(12, 374);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(53, 17);
            mobileLabel.TabIndex = 15;
            mobileLabel.Text = "Mobile:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(306, 338);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 22);
            this.countryTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(212, 341);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 13;
            countryLabel.Text = "Country:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(106, 338);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postalCodeTextBox.TabIndex = 4;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(12, 341);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(88, 17);
            postalCodeLabel.TabIndex = 11;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(306, 307);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(100, 22);
            this.regionTextBox.TabIndex = 3;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(212, 310);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(57, 17);
            regionLabel.TabIndex = 9;
            regionLabel.Text = "Region:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(106, 307);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 2;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 310);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(106, 214);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(300, 87);
            this.adressTextBox.TabIndex = 1;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(12, 217);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(56, 17);
            adressLabel.TabIndex = 5;
            adressLabel.Text = "Adress:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBooksBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(106, 186);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(12, 189);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(75, 17);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name:";
            // 
            // phoneBooksDataGridView
            // 
            this.phoneBooksDataGridView.AutoGenerateColumns = false;
            this.phoneBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.phoneBooksDataGridView.DataSource = this.phoneBooksBindingSource;
            this.phoneBooksDataGridView.Location = new System.Drawing.Point(454, 58);
            this.phoneBooksDataGridView.Name = "phoneBooksDataGridView";
            this.phoneBooksDataGridView.RowHeadersWidth = 51;
            this.phoneBooksDataGridView.RowTemplate.Height = 24;
            this.phoneBooksDataGridView.Size = new System.Drawing.Size(765, 335);
            this.phoneBooksDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn5.HeaderText = "Region";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PostalCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "PostalCode";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn7.HeaderText = "Country";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mobile";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Erdaulet_dairy.Properties.Resources.phone_icon_vector_illustration_KJ6XAN;
            this.pictureBox1.Location = new System.Drawing.Point(106, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.phoneBooksDataGridView);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.phoneBooksBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Diary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksBindingNavigator)).EndInit();
            this.phoneBooksBindingNavigator.ResumeLayout(false);
            this.phoneBooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database database;
        private System.Windows.Forms.BindingSource phoneBooksBindingSource;
        private System.Windows.Forms.BindingNavigator phoneBooksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phoneBooksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DataGridView phoneBooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

