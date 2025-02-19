﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1488
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void clnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{
			DatePicker clndr = (DatePicker)sender;
			txt.Text = clndr.SelectedDate.Value.Date.ToShortDateString();
			// MessageBox.Show($"You used {clndr.SelectedDate.Value.Date.ToShortDateString()}");
		}

		private void cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		{
			Calendar cal = (Calendar)sender;
			MessageBox.Show(cal.SelectedDate.Value.Date.ToShortDateString());
		}
	}
}