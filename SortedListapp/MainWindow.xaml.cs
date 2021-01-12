using System;
using System.Collections;
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

namespace SortedListapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addBottom_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(keytxtBox.Text, valuetxtBox.Text);
            keytxtBox.Text = "";
            valuetxtBox.Text = "";

            ICollection collection = sortedList.Keys;
            string data = ""; //เป็นการจับ sortedList มาเรียงต่อๆกันด้วยโค๊ตด้านล่าง
            foreach (string key in collection)
            {
                data = data + " " + "\n" + sortedList[key].ToString(); //ชุดที่ใช้เรียงโค๊ต
            }
            MessageBox.Show("You have " + sortedList.Count + " list"+ data);
        }
    }
}
