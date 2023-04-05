using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheckboxThing
{
    /// <summary>
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public bool FromBehindCode { get; set; } = false;
        public Item()
        {
            InitializeComponent();
        }

        public void myCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!FromBehindCode)
            {
                MessageBox.Show("Disabled from UI");
            } else
            {
                MessageBox.Show("Disabled from behind the code");
            }
            FromBehindCode = false;
        }
    }
}
