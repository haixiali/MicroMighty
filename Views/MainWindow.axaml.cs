using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace MicroMighty.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ExitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void MaximizeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void MinimizeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}