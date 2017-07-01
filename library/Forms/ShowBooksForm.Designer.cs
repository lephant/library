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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AuthorsListBox = new ScrollableListBox();
            this.PublishersListBox = new ScrollableListBox();
            this.PlacesListBox = new ScrollableListBox();
            this.UsageCategoriesListBox = new ScrollableListBox();
            this.PublisherListLabel = new System.Windows.Forms.Label();
            this.AuthorListLabel = new System.Windows.Forms.Label();
            this.PlaceListLabel = new System.Windows.Forms.Label();
            this.UsageCategoryListLabel = new System.Windows.Forms.Label();
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
            this.ResultPanel.Location = new System.Drawing.Point(220, 12);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(409, 366);
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
            this.SearchPanel.Size = new System.Drawing.Size(202, 366);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchFlowLayoutPanel
            // 
            this.SearchFlowLayoutPanel.AutoSize = true;
            this.SearchFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.SearchFlowLayoutPanel.Size = new System.Drawing.Size(183, 504);
            this.SearchFlowLayoutPanel.TabIndex = 0;
            this.SearchFlowLayoutPanel.WrapContents = false;
            this.SearchFlowLayoutPanel.Resize += new System.EventHandler(this.SearchFlowLayoutPanel_Resize);
            // 
            // AuthorsListBox
            // 
            this.AuthorsListBox.DisplayMember = "name";
            this.AuthorsListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsListBox.FormattingEnabled = true;
            this.AuthorsListBox.ItemHeight = 17;
            this.AuthorsListBox.Location = new System.Drawing.Point(6, 25);
            this.AuthorsListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.AuthorsListBox.Name = "AuthorsListBox";
            this.AuthorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AuthorsListBox.Size = new System.Drawing.Size(171, 89);
            this.AuthorsListBox.TabIndex = 1;
            this.AuthorsListBox.ValueMember = "id";
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.DisplayMember = "name";
            this.PublishersListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.ItemHeight = 17;
            this.PublishersListBox.Location = new System.Drawing.Point(6, 151);
            this.PublishersListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PublishersListBox.Size = new System.Drawing.Size(171, 89);
            this.PublishersListBox.TabIndex = 2;
            this.PublishersListBox.ValueMember = "id";
            // 
            // PlacesListBox
            // 
            this.PlacesListBox.DisplayMember = "name";
            this.PlacesListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesListBox.FormattingEnabled = true;
            this.PlacesListBox.ItemHeight = 17;
            this.PlacesListBox.Location = new System.Drawing.Point(6, 277);
            this.PlacesListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.PlacesListBox.Name = "PlacesListBox";
            this.PlacesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PlacesListBox.Size = new System.Drawing.Size(171, 89);
            this.PlacesListBox.TabIndex = 0;
            this.PlacesListBox.ValueMember = "id";
            // 
            // UsageCategoriesListBox
            // 
            this.UsageCategoriesListBox.DisplayMember = "name";
            this.UsageCategoriesListBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsageCategoriesListBox.ItemHeight = 17;
            this.UsageCategoriesListBox.Location = new System.Drawing.Point(6, 403);
            this.UsageCategoriesListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.UsageCategoriesListBox.Name = "UsageCategoriesListBox";
            this.UsageCategoriesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.UsageCategoriesListBox.Size = new System.Drawing.Size(171, 89);
            this.UsageCategoriesListBox.TabIndex = 0;
            this.UsageCategoriesListBox.ValueMember = "id";
            // 
            // PublisherListLabel
            // 
            this.PublisherListLabel.AutoSize = true;
            this.PublisherListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PublisherListLabel.Location = new System.Drawing.Point(6, 132);
            this.PublisherListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.PublisherListLabel.Name = "PublisherListLabel";
            this.PublisherListLabel.Size = new System.Drawing.Size(98, 18);
            this.PublisherListLabel.TabIndex = 3;
            this.PublisherListLabel.Text = Resources.PublisherListLabelText;
            // 
            // AuthorListLabel
            // 
            this.AuthorListLabel.AutoSize = true;
            this.AuthorListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorListLabel.Location = new System.Drawing.Point(6, 6);
            this.AuthorListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.AuthorListLabel.Name = "AuthorListLabel";
            this.AuthorListLabel.Size = new System.Drawing.Size(59, 18);
            this.AuthorListLabel.TabIndex = 4;
            this.AuthorListLabel.Text = Resources.AuthorListLabelText;
            // 
            // PlaceListLabel
            // 
            this.PlaceListLabel.AutoSize = true;
            this.PlaceListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceListLabel.Location = new System.Drawing.Point(6, 258);
            this.PlaceListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.PlaceListLabel.Name = "PlaceListLabel";
            this.PlaceListLabel.Size = new System.Drawing.Size(49, 18);
            this.PlaceListLabel.TabIndex = 5;
            this.PlaceListLabel.Text = Resources.PlaceListLabelText;
            // 
            // UsageCategoryListLabel
            // 
            this.UsageCategoryListLabel.AutoSize = true;
            this.UsageCategoryListLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsageCategoryListLabel.Location = new System.Drawing.Point(6, 384);
            this.UsageCategoryListLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 1);
            this.UsageCategoryListLabel.Name = "UsageCategoryListLabel";
            this.UsageCategoryListLabel.Size = new System.Drawing.Size(42, 18);
            this.UsageCategoryListLabel.TabIndex = 6;
            this.UsageCategoryListLabel.Text = Resources.UsageCategoryListLabelText;
            // 
            // ShowBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 390);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ResultPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 420);
            this.Name = "ShowBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Resources.ApplicationName;
            this.Load += new System.EventHandler(this.ShowBooksForm_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.SearchFlowLayoutPanel.ResumeLayout(false);
            this.SearchFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.FlowLayoutPanel SearchFlowLayoutPanel;
        private ScrollableListBox PlacesListBox;
        private ScrollableListBox UsageCategoriesListBox;
        private ScrollableListBox AuthorsListBox;
        private ScrollableListBox PublishersListBox;
        private System.Windows.Forms.Label AuthorListLabel;
        private System.Windows.Forms.Label PublisherListLabel;
        private System.Windows.Forms.Label PlaceListLabel;
        private System.Windows.Forms.Label UsageCategoryListLabel;
    }
}

