﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using library.Controls;
using library.DAO.Impl;
using library.Model;
using library.SearchCriteries;

namespace library.Forms
{
    public partial class ShowBooksForm : Form
    {
        public ShowBooksForm()
        {
            InitializeComponent();

            MenuItem editAuthorMenuItem = new MenuItem("Редактировать");
            editAuthorMenuItem.Click += EditAuthorMenuItemOnClick;
            MenuItem deleteAuthorMenuItem = new MenuItem("Удалить");
            deleteAuthorMenuItem.Click += DeleteAuthorMenuItemOnClick;
            ContextMenu authorContextMenu = new ContextMenu(new[]
            {
                editAuthorMenuItem,
                deleteAuthorMenuItem
            });
            AuthorsListBox.ContextMenu = authorContextMenu;

            MenuItem editPublisherMenuItem = new MenuItem("Редактировать");
            editPublisherMenuItem.Click += EditPublisherMenuItemOnClick;
            MenuItem deletePublisherMenuItem = new MenuItem("Удалить");
            deletePublisherMenuItem.Click += DeletePublisherMenuItemOnClick;
            ContextMenu publisherContextMenu = new ContextMenu(new[]
            {
                editPublisherMenuItem,
                deletePublisherMenuItem
            });
            PublishersListBox.ContextMenu = publisherContextMenu;

            MenuItem editPlaceMenuItem = new MenuItem("Редактировать");
            editPlaceMenuItem.Click += EditPlaceMenuItemOnClick;
            MenuItem deletePlaceMenuItem = new MenuItem("Удалить");
            deletePlaceMenuItem.Click += DeletePlaceMenuItemOnClick;
            ContextMenu placeContextMenu = new ContextMenu(new[]
            {
                editPlaceMenuItem,
                deletePlaceMenuItem
            });
            PlacesListBox.ContextMenu = placeContextMenu;

            MenuItem editUsageCategoryMenuItem = new MenuItem("Редактировать");
            editUsageCategoryMenuItem.Click += EditUsageCategoryMenuItemOnClick;
            MenuItem deleteUsageCategoryMenuItem = new MenuItem("Удалить");
            deleteUsageCategoryMenuItem.Click += DeleteUsageCategoryMenuItemOnClick;
            ContextMenu usageCategoryContextMenu = new ContextMenu(new []
            {
                editUsageCategoryMenuItem,
                deleteUsageCategoryMenuItem
            });
            UsageCategoriesListBox.ContextMenu = usageCategoryContextMenu;
        }

        private void ShowBooksForm_Load(object sender, EventArgs e)
        {
            AuthorsListBox.DataSource = new AuthorDao().GetList();
            PublishersListBox.DataSource = new PublisherDao().GetList();
            PlacesListBox.DataSource = new PlaceDao().GetList();
            UsageCategoriesListBox.DataSource = new UsageCategoryDao().GetList();
            BookDataGrid.DataSource = new BookDao().GetList().ToTable();
            ChangeColumnNames();
        }

        private void ChangeColumnNames()
        {
            foreach (DataGridViewColumn column in BookDataGrid.Columns)
            {
                switch (column.HeaderText)
                {
                    case "Id":
                        column.Visible = false;
                        break;
                    case "Name":
                        column.HeaderText = "Название";
                        break;
                    case "AuthorName":
                        column.HeaderText = "Автор";
                        break;
                    case "PlaceName":
                        column.HeaderText = "Место";
                        break;
                    case "UsageCategoryName":
                        column.HeaderText = "Цель";
                        break;
                    case "CountOfPages":
                        column.HeaderText = "Стр.";
                        break;
                }
            }
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание автора";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                Author author = new Author();
                author.Name = textDialog.EditedText;
                AuthorDao authorDao = new AuthorDao();
                authorDao.Insert(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void EditAuthorMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = AuthorsListBox.ContextMenuItemIndex;
            Author author = (Author)AuthorsListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.EditedText = author.Name;
            textDialog.FormText = "Редактирование автора";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                author.Name = textDialog.EditedText;
                AuthorDao authorDao = new AuthorDao();
                authorDao.Update(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void DeleteAuthorMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = AuthorsListBox.ContextMenuItemIndex;
            Author author = (Author)AuthorsListBox.Items[clickedIndex];
            DialogResult dialogResult = MessageBox.Show(this,
                "Вы уверены, что хотите удалить автора \"" + author.Name + "\"?",
                "Удаление автора",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                AuthorDao authorDao = new AuthorDao();
                authorDao.Delete(author);
                AuthorsListBox.DataSource = authorDao.GetList();
            }
        }

        private void AddPublisherButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание издательства";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                Publisher publisher = new Publisher();
                publisher.Name = textDialog.EditedText;
                PublisherDao publisherDao = new PublisherDao();
                publisherDao.Insert(publisher);
                PublishersListBox.DataSource = publisherDao.GetList();
            }
        }

        private void EditPublisherMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = PublishersListBox.ContextMenuItemIndex;
            Publisher publisher = (Publisher)PublishersListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Редактирование издательства";
            textDialog.EditedText = publisher.Name;
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                publisher.Name = textDialog.EditedText;
                PublisherDao publisherDao = new PublisherDao();
                publisherDao.Update(publisher);
                PublishersListBox.DataSource = publisherDao.GetList();
            }
        }

        private void DeletePublisherMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = PublishersListBox.ContextMenuItemIndex;
            Publisher publisher = (Publisher) PublishersListBox.Items[clickedIndex];
            DialogResult dialogResult = MessageBox.Show(this,
                "Вы уверены, что хотите удалить издательство \"" + publisher.Name + "\"?",
                "Удаление издательства",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                PublisherDao publisherDao = new PublisherDao();
                publisherDao.Delete(publisher);
                PublishersListBox.DataSource = publisherDao.GetList();
            }
        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание места";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                Place place = new Place();
                place.Name = textDialog.EditedText;
                PlaceDao placeDao = new PlaceDao();
                placeDao.Insert(place);
                PlacesListBox.DataSource = placeDao.GetList();
            }
        }

        private void EditPlaceMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = PlacesListBox.ContextMenuItemIndex;
            Place place = (Place)PlacesListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Редактирование места";
            textDialog.EditedText = place.Name;
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                place.Name = textDialog.EditedText;
                PlaceDao placeDao = new PlaceDao();
                placeDao.Update(place);
                PlacesListBox.DataSource = placeDao.GetList();
            }
        }

        private void DeletePlaceMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = PlacesListBox.ContextMenuItemIndex;
            Place place = (Place) PlacesListBox.Items[clickedIndex];
            DialogResult dialogResult = MessageBox.Show(this,
                "Вы уверены, что хотите удалить место \"" + place.Name + "\"?",
                "Удаление места",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                PlaceDao placeDao = new PlaceDao();
                placeDao.Delete(place);
                PlacesListBox.DataSource = placeDao.GetList();
            }
        }

        private void AddUsageCategoryButton_Click(object sender, EventArgs e)
        {
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Создание категории использования";
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                UsageCategory usageCategory = new UsageCategory();
                usageCategory.Name = textDialog.EditedText;
                UsageCategoryDao usageCategoryDao = new UsageCategoryDao();
                usageCategoryDao.Insert(usageCategory);
                UsageCategoriesListBox.DataSource = usageCategoryDao.GetList();
            }
        }

        private void EditUsageCategoryMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = UsageCategoriesListBox.ContextMenuItemIndex;
            UsageCategory usageCategory = (UsageCategory)UsageCategoriesListBox.Items[clickedIndex];
            TextDialog textDialog = new TextDialog();
            textDialog.FormText = "Редактирование категории использования";
            textDialog.EditedText = usageCategory.Name;
            textDialog.ShowDialog(this);
            if (textDialog.OkResult)
            {
                usageCategory.Name = textDialog.EditedText;
                UsageCategoryDao usageCategoryDao = new UsageCategoryDao();
                usageCategoryDao.Update(usageCategory);
                UsageCategoriesListBox.DataSource = usageCategoryDao.GetList();
            }
        }

        private void DeleteUsageCategoryMenuItemOnClick(object sender, EventArgs eventArgs)
        {
            int clickedIndex = UsageCategoriesListBox.ContextMenuItemIndex;
            UsageCategory usageCategory = (UsageCategory)UsageCategoriesListBox.Items[clickedIndex];
            DialogResult dialogResult = MessageBox.Show(this,
                "Вы уверены, что хотите удалить категорию использования \"" + usageCategory.Name + "\"?",
                "Удаление категории использования",
                MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                UsageCategoryDao usageCategoryDao = new UsageCategoryDao();
                usageCategoryDao.Delete(usageCategory);
                UsageCategoriesListBox.DataSource = usageCategoryDao.GetList();
            }
        }

        private void DelegateMouseEnterToPanel(object sender, EventArgs e)
        {
            SearchPanel.Focus();
        }

        private void SearchFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            int searchStringPaddings = SearchStringTextBox.Margin.Left + SearchStringTextBox.Margin.Right;
            int searchStringWidth = SearchFlowLayoutPanel.Width - searchStringPaddings;

            int authorsHeaderPaddings = AuthorsHeaderPanel.Margin.Left + AuthorsHeaderPanel.Margin.Right;
            int authorsHeaderWidth = SearchFlowLayoutPanel.Width - authorsHeaderPaddings;

            int authorsPaddings = AuthorsListBox.Margin.Left + AuthorsListBox.Margin.Right;
            int authorsWidth = SearchFlowLayoutPanel.Width - authorsPaddings;

            int publishersHeaderPaddings = PublishersHeaderPanel.Margin.Left + PublishersHeaderPanel.Margin.Right;
            int publishersHeaderWidth = SearchFlowLayoutPanel.Width - publishersHeaderPaddings;

            int publishersPaddings = PublishersListBox.Margin.Left + PublishersListBox.Margin.Right;
            int publishersWidth = SearchFlowLayoutPanel.Width - publishersPaddings;

            int placesHeaderPaddings = PlacesHeaderPanel.Margin.Left + PlacesHeaderPanel.Margin.Right;
            int placesHeaderWidth = SearchFlowLayoutPanel.Width - placesHeaderPaddings;

            int placesPaddings = PlacesListBox.Margin.Left + PlacesListBox.Margin.Right;
            int placesWidth = SearchFlowLayoutPanel.Width - placesPaddings;

            int usageCategoriesHeaderPaddings = UsageCategoriesHeaderPanel.Margin.Left + UsageCategoriesHeaderPanel.Margin.Right;
            int usageCategoriesHeaderWidth = SearchFlowLayoutPanel.Width - usageCategoriesHeaderPaddings;

            int usageCategoriesPaddings = UsageCategoriesListBox.Margin.Left + UsageCategoriesListBox.Margin.Right;
            int usageCategoriesWidth = SearchFlowLayoutPanel.Width - usageCategoriesPaddings;

            SearchStringTextBox.Width = searchStringWidth;
            AuthorsHeaderPanel.Width = authorsHeaderWidth;
            AuthorsListBox.Width = authorsWidth;
            PublishersHeaderPanel.Width = publishersHeaderWidth;
            PublishersListBox.Width = publishersWidth;
            PlacesHeaderPanel.Width = placesHeaderWidth;
            PlacesListBox.Width = placesWidth;
            UsageCategoriesHeaderPanel.Width = usageCategoriesHeaderWidth;
            UsageCategoriesListBox.Width = usageCategoriesWidth;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BookSearchCriteria criteria = new BookSearchCriteria();

            criteria.Text = SearchStringTextBox.Text;

            List<Author> authors = new List<Author>();
            foreach (var selectedItem in AuthorsListBox.SelectedItems)
            {
                authors.Add(selectedItem as Author);
            }
            criteria.Authors = authors;

            List<Publisher> publishers = new List<Publisher>();
            foreach (var selectedItem in PublishersListBox.SelectedItems)
            {
                publishers.Add(selectedItem as Publisher);
            }
            criteria.Publishers = publishers;

            List<Place> places = new List<Place>();
            foreach (var selectedItem in PlacesListBox.SelectedItems)
            {
                places.Add(selectedItem as Place);
            }
            criteria.Places = places;

            List<UsageCategory> usageCategories = new List<UsageCategory>();
            foreach (var selectedItem in UsageCategoriesListBox.SelectedItems)
            {
                usageCategories.Add(selectedItem as UsageCategory);
            }
            criteria.UsageCategories = usageCategories;

            BookDataGrid.DataSource = new BookDao().GetListByCriteria(criteria);
        }
    }
}