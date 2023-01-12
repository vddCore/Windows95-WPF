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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsOldWindow
{
    /// <summary>
    /// Interaction logic for TipBox.xaml
    /// </summary>
    public partial class TipBox : UserControl
    {
        public static readonly DependencyProperty TipTextProperty = DependencyProperty.Register("TipText", typeof(string), typeof(TipBox), new PropertyMetadata(string.Empty));

        public string TipText
        {
            get { return (string) GetValue(TipTextProperty); }
            set { SetValue(TipTextProperty, value); }
        }

        public TipBox()
        {
            InitializeComponent();
        }
    }
}
