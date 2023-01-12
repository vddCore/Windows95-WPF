using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Windows95
{
    public class Windows95Window : Window
    {
        private Button CloseButton { get; set; }
        private Button MaximizeButton { get; set; }
        private Button MinimizeButton { get; set; }
        private Border TitleBar { get; set; }

        private bool _mouseDown;

        static Windows95Window()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Windows95Window),
                new FrameworkPropertyMetadata(typeof(Windows95Window)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            CloseButton = GetTemplateChild("PART_CloseButton") as Button;
            MaximizeButton = GetTemplateChild("PART_MaximizeButton") as Button;
            MinimizeButton = GetTemplateChild("PART_MinimizeButton") as Button;
            TitleBar = GetTemplateChild("PART_TitleBar") as Border;

            CloseButton.Click += CloseButton_Click;
            MaximizeButton.Click += MaximizeButton_Click;
            MinimizeButton.Click += MinimizeButton_Click;
            TitleBar.MouseDown += TitleBar_MouseDown;
        }

        private void TitleBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
