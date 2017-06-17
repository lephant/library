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
            this.AuthorsListBox = new System.Windows.Forms.ListBox();
            this.PublishersListBox = new System.Windows.Forms.ListBox();
            this.PlacesListBox = new System.Windows.Forms.ListBox();
            this.UsageCategoriesListBox = new System.Windows.Forms.ListBox();
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
            this.SearchFlowLayoutPanel.Controls.Add(this.AuthorsListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.PublishersListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.PlacesListBox);
            this.SearchFlowLayoutPanel.Controls.Add(this.UsageCategoriesListBox);
            this.SearchFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchFlowLayoutPanel.Name = "SearchFlowLayoutPanel";
            this.SearchFlowLayoutPanel.Size = new System.Drawing.Size(183, 428);
            this.SearchFlowLayoutPanel.TabIndex = 0;
            this.SearchFlowLayoutPanel.WrapContents = false;
            this.SearchFlowLayoutPanel.Resize += new System.EventHandler(this.SearchFlowLayoutPanel_Resize);
            // 
            // AuthorsListBox
            // 
            this.AuthorsListBox.FormattingEnabled = true;
            this.AuthorsListBox.Location = new System.Drawing.Point(6, 6);
            this.AuthorsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorsListBox.Name = "AuthorsListBox";
            this.AuthorsListBox.Size = new System.Drawing.Size(171, 95);
            this.AuthorsListBox.TabIndex = 1;
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.Location = new System.Drawing.Point(6, 113);
            this.PublishersListBox.Margin = new System.Windows.Forms.Padding(6);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.Size = new System.Drawing.Size(171, 95);
            this.PublishersListBox.TabIndex = 2;
            // 
            // PlacesListBox
            // 
            this.PlacesListBox.FormattingEnabled = true;
            this.PlacesListBox.Location = new System.Drawing.Point(6, 220);
            this.PlacesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.PlacesListBox.Name = "PlacesListBox";
            this.PlacesListBox.Size = new System.Drawing.Size(171, 95);
            this.PlacesListBox.TabIndex = 0;
            // 
            // UsageCategoriesListBox
            // 
            this.UsageCategoriesListBox.Location = new System.Drawing.Point(6, 327);
            this.UsageCategoriesListBox.Margin = new System.Windows.Forms.Padding(6);
            this.UsageCategoriesListBox.Name = "UsageCategoriesListBox";
            this.UsageCategoriesListBox.Size = new System.Drawing.Size(171, 95);
            this.UsageCategoriesListBox.TabIndex = 0;
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
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.SearchFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.FlowLayoutPanel SearchFlowLayoutPanel;
        private System.Windows.Forms.ListBox PlacesListBox;
        private System.Windows.Forms.ListBox UsageCategoriesListBox;
        private System.Windows.Forms.ListBox AuthorsListBox;
        private System.Windows.Forms.ListBox PublishersListBox;
    }
}

