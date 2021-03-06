﻿namespace StatisticsAnalysisTool.Views
{
    using System.Windows;
    using System.Windows.Input;
    using ViewModels;

    /// <summary>
    /// Interaktionslogik für SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow
    {
        private readonly SettingsWindowViewModel _settingsWindowViewModel;

        public SettingsWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            _settingsWindowViewModel = new SettingsWindowViewModel(this, mainWindowViewModel);
            DataContext = _settingsWindowViewModel;
        }
        
        private void CloseButton_Click(object sender, RoutedEventArgs e) => Close();

        private void MinimizeButton_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void Hotbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            _settingsWindowViewModel.SaveSettings();
        }
    }
}
