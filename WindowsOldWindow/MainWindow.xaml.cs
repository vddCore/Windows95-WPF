using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace WindowsOldWindow
{
    public partial class MainWindow
    {
        private readonly List<string> _tips;
        private int _currentTipIndex;

        public MainWindow()
        {
            InitializeComponent();

            _tips = new List<string>();

            if (File.Exists("./tips.txt"))
            {
                using (var sr = new StreamReader("./tips.txt"))
                {
                    var json = sr.ReadToEnd();
                    _tips = JsonConvert.DeserializeObject<List<string>>(json);
                }
            }

            var index = new Random().Next(0, _tips.Count - 1);
            _currentTipIndex = index;
            MainTipBox.TipText = _tips[_currentTipIndex];

            var args = Environment.GetCommandLineArgs();
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == "-version")
                {
                    if (i + 1 > args.Length) break;
                    WindowsVersionTextBlock.Text = args[++i];
                }
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NextTip_Click(object sender, RoutedEventArgs e)
        {
            _currentTipIndex++;
            if (_currentTipIndex > _tips.Count - 1)
            {
                _currentTipIndex = 0;
            }
            MainTipBox.TipText = _tips[_currentTipIndex];
        }

        private void OnlineRegistration_Click(object sender, RoutedEventArgs e)
        {
            new MessageBox("Registration failed", "You are already a registered member of Hell.").ShowDialog();
        }
    }
}
