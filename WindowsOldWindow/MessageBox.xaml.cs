using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowsOldWindow
{
    public partial class MessageBox
    {
        public MessageBox()
        {
            InitializeComponent();
        }

        public MessageBox(string title, string message) : this()
        {
            Title = title;
            MessageText.Text = message;
        }

        private void AcceptButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
