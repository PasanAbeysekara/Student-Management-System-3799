﻿using System;
using System.Collections.Generic;
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

namespace SMS.UserControls
{
	public partial class MyOption : UserControl
	{
		public MyOption()
		{
			InitializeComponent();
		}

		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register
			("Text", typeof(string), typeof(MyOption));

		public FontAwesome.WPF.FontAwesomeIcon Icon
		{
			get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconProperty); }
			set { SetValue(IconProperty, value); }
		}
		public static readonly DependencyProperty IconProperty = DependencyProperty.Register
			("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MyOption));
	}
}
