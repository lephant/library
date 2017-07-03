using library.Controls;
using library.Properties;

namespace library.Forms
{
    partial class ShowBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBooksForm));
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new library.Controls.ScrollablePanel();
            this.SearchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchStringLabel = new System.Windows.Forms.Label();
            this.SearchStringTextBox = new System.Windows.Forms.TextBox();
            this.AuthorListLabel = new System.Windows.Forms.Label();
            this.AuthorsListBox = new library.Controls.ScrollableListBox();
            this.PublisherListLabel = new System.Windows.Forms.Label();
            this.PublishersListBox = new library.Controls.ScrollableListBox();
            this.PlaceListLabel = new System.Windows.Forms.Label();
            this.PlacesListBox = new library.Controls.ScrollableListBox();
            this.UsageCategoryListLabel = new System.Windows.Forms.Label();
            this.UsageCategoriesListBox = new library.Controls.ScrollableListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            this.SearchFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultPanel
            // 
            this.ResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPanel.Location = new System.Drawing.Point(220, 13);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(409, 396);
            this.ResultPanel.TabIndex = 1;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchPanel.AutoScroll = true;
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SearchFlowLayoutPanel);
            this.SearchPanel.Location = new System.Drawing.Point(12, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(202, 348);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchFlowLayoutPanel
            // 
            this.SearchFlowLayoutPanel.AutoSize = true;
            this.SearchFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchFlowLayoutPanel.Controls.Add(this.SearchStringLabel);
            this.SearchFlowLayoutPanel.Controls.Add(this.SearchStringTextBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.AuthorListLabel);
            this.SearchFlowLayoutPanel.Controls.Add(this.AuthorsListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.PublisherListLabel);
            this.SearchFlowLayoutPanel.Controls.Add(this.PublishersListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.PlaceListLabel);
            this.SearchFlowLayoutPanel.Controls.Add(this.PlacesListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.UsageCategoryListLabel);
            this.SearchFlowLayoutPanel.Controls.Add(this.UsageCategoriesListBox);
            this.SearchFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchFlowLayoutPanel.Name = "SearchFlowLayoutPanel";
            this.SearchFlowLayoutPanel.Size = new System.Drawing.Size(183, 536);
            this.SearchFlowLayoutPanel.TabIndex = 0;
            this.SearchFlowLayoutPanel.WrapContents = false;
            this.SearchFlowLayoutPanel.Resize += new System.EventHandler(this.SearchFlowLayoutPanel_Resize);
            // 
            // SearchStringLabel
            // 
            this.SearchStringLabel.AutoSize = true;
            this.SearchStringLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchStringLabel.Location = new System.Drawing.Point(6, 6);
            this.SearchStringLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.SearchStringLabel.Name = "SearchStringLabel";
            this.SearchStringLabel.Size = new System.Drawing.Size(51, 18);
            this.SearchStringLabel.TabIndex = 7;
            this.SearchStringLabel.Text = "Поиск";
            // 
            // SearchStringTextBox
            // 
            this.SearchStringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchStringTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchStringTextBox.Location = new System.Drawing.Point(6, 25);
            this.SearchStringTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.SearchStringTextBox.Name = "SearchStringTextBox";
            this.SearchStringTextBox.Size = new System.Drawing.Size(171, 25);
            this.SearchStringTextBox.TabIndex = 8;
            // 
            // AuthorListLabel
            // 
            this.AuthorListLabel.AutoSize = true;
            this.AuthorListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorListLabel.Location = new System.Drawing.Point(6, 62);
            this.AuthorListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.AuthorListLabel.Name = "AuthorListLabel";
            this.AuthorListLabel.Size = new System.Drawing.Size(59, 18);
            this.AuthorListLabel.TabIndex = 4;
            this.AuthorListLabel.Text = "Авторы";
            // 
            // AuthorsListBox
            // 
            this.AuthorsListBox.DisplayMember = "name";
            this.AuthorsListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsListBox.FormattingEnabled = true;
            this.AuthorsListBox.ItemHeight = 17;
            this.AuthorsListBox.Location = new System.Drawing.Point(6, 81);
            this.AuthorsListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.AuthorsListBox.Name = "AuthorsListBox";
            this.AuthorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AuthorsListBox.Size = new System.Drawing.Size(171, 89);
            this.AuthorsListBox.TabIndex = 1;
            this.AuthorsListBox.ValueMember = "id";
            // 
            // PublisherListLabel
            // 
            this.PublisherListLabel.AutoSize = true;
            this.PublisherListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublisherListLabel.Location = new System.Drawing.Point(6, 182);
            this.PublisherListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.PublisherListLabel.Name = "PublisherListLabel";
            this.PublisherListLabel.Size = new System.Drawing.Size(98, 18);
            this.PublisherListLabel.TabIndex = 3;
            this.PublisherListLabel.Text = "Издательства";
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.DisplayMember = "name";
            this.PublishersListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.ItemHeight = 17;
            this.PublishersListBox.Location = new System.Drawing.Point(6, 201);
            this.PublishersListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PublishersListBox.Size = new System.Drawing.Size(171, 89);
            this.PublishersListBox.TabIndex = 2;
            this.PublishersListBox.ValueMember = "id";
            // 
            // PlaceListLabel
            // 
            this.PlaceListLabel.AutoSize = true;
            this.PlaceListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceListLabel.Location = new System.Drawing.Point(6, 302);
            this.PlaceListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.PlaceListLabel.Name = "PlaceListLabel";
            this.PlaceListLabel.Size = new System.Drawing.Size(49, 18);
            this.PlaceListLabel.TabIndex = 5;
            this.PlaceListLabel.Text = "Места";
            // 
            // PlacesListBox
            // 
            this.PlacesListBox.DisplayMember = "name";
            this.PlacesListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesListBox.FormattingEnabled = true;
            this.PlacesListBox.ItemHeight = 17;
            this.PlacesListBox.Location = new System.Drawing.Point(6, 321);
            this.PlacesListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.PlacesListBox.Name = "PlacesListBox";
            this.PlacesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PlacesListBox.Size = new System.Drawing.Size(171, 89);
            this.PlacesListBox.TabIndex = 0;
            this.PlacesListBox.ValueMember = "id";
            // 
            // UsageCategoryListLabel
            // 
            this.UsageCategoryListLabel.AutoSize = true;
            this.UsageCategoryListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsageCategoryListLabel.Location = new System.Drawing.Point(6, 422);
            this.UsageCategoryListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.UsageCategoryListLabel.Name = "UsageCategoryListLabel";
            this.UsageCategoryListLabel.Size = new System.Drawing.Size(42, 18);
            this.UsageCategoryListLabel.TabIndex = 6;
            this.UsageCategoryListLabel.Text = "Цель";
            // 
            // UsageCategoriesListBox
            // 
            this.UsageCategoriesListBox.DisplayMember = "name";
            this.UsageCategoriesListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsageCategoriesListBox.ItemHeight = 17;
            this.UsageCategoriesListBox.Location = new System.Drawing.Point(6, 441);
            this.UsageCategoriesListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.UsageCategoriesListBox.Name = "UsageCategoriesListBox";
            this.UsageCategoriesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsageCategoriesListBox.Size = new System.Drawing.Size(171, 89);
            this.UsageCategoriesListBox.TabIndex = 0;
            this.UsageCategoriesListBox.ValueMember = "id";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(22, 377);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(174, 32);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Искать";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // ShowBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 421);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ResultPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 420);
            this.Name = "ShowBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронная библиотека \"Мармыш\"";
            this.Load += new System.EventHandler(this.ShowBooksForm_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.SearchFlowLayoutPanel.ResumeLayout(false);
            this.SearchFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ResultPanel;
        private ScrollablePanel SearchPanel;
        private System.Windows.Forms.FlowLayoutPanel SearchFlowLayoutPanel;
        private ScrollableListBox PlacesListBox;
        private ScrollableListBox UsageCategoriesListBox;
        private ScrollableListBox AuthorsListBox;
        private ScrollableListBox PublishersListBox;
        private System.Windows.Forms.Label AuthorListLabel;
        private System.Windows.Forms.Label PublisherListLabel;
        private System.Windows.Forms.Label PlaceListLabel;
        private System.Windows.Forms.Label UsageCategoryListLabel;
        private System.Windows.Forms.Label SearchStringLabel;
        private System.Windows.Forms.TextBox SearchStringTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}

