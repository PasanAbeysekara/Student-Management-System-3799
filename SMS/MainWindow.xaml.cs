using SMS.MVVM.ViewModels;
using SMS.MVVM.Views.UserGuides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SMS
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private void Border_Mousedown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}
		private bool isMaximized = false;
		private void Border_MouseLeftButtondown(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2)
			{
				if (isMaximized)
				{
					this.WindowState = WindowState.Normal;
					this.Width = 1080;
					this.Height = 720;

					isMaximized = false;
				}
				else
				{
					this.WindowState = WindowState.Maximized;
					isMaximized = true;
				}
			}
		}

		private void DataGridCell_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			e.Handled = true;
		}

		private int propTmp = 0;
		public MainWindow()
		{
			DataContext = new MainWindowVM();
            InitializeComponent();
            var userGuide = new UserGuideWindow();
			userGuide.Topmost = true;
            userGuide.Show();
        }
		
		
        

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
        }

		private void MinimizeButton_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void MaximizeButton_Click(object sender, RoutedEventArgs e)
		{
			if(WindowState == WindowState.Normal) WindowState = WindowState.Maximized;
			else WindowState = WindowState.Normal;
		}

		private void Fname_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));

		}

		private void Lname_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("LastName", ListSortDirection.Ascending));

		}

		private void Gender_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("Gender", ListSortDirection.Ascending));

		}

		private void DOB_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("DateOfBirth", ListSortDirection.Ascending));

		}

		private void GPA_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("GPA", ListSortDirection.Ascending));

		}

		private void Email_Click(object sender, RoutedEventArgs e)
		{
			// Get the DataGrid's CollectionView
			ICollectionView view = CollectionViewSource.GetDefaultView(ItemGrid.ItemsSource);

			// Sort the CollectionView by the "ColumnName" property
			view.SortDescriptions.Clear();
			view.SortDescriptions.Add(new SortDescription("Email", ListSortDirection.Ascending));

		}


	}
}
