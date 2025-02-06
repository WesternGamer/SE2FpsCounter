using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Media;
using Keen.VRage.UI.AvaloniaInterface.Services;
using Keen.VRage.UI.Screens;

namespace SE2FpsCounter
{
    [NeedsWindowStyles]
    internal class StatsOverlayScreen : ScreenView, IAlwaysVisible
    {
        public StatsOverlayScreen()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            Canvas canvas = new Canvas();
            canvas.Height = Height;
            canvas.Width = Width;
            canvas.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
            canvas.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;

            TextBlock textBlock = new TextBlock();
            textBlock.Height = 100;
            textBlock.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            textBlock.FontSize = 20;
            textBlock.TextAlignment = TextAlignment.Left;
            textBlock.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
            textBlock.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Bind(TextBlock.TextProperty, new Binding("FpsValueText", BindingMode.Default), null);
            canvas.Children.Add(textBlock);
            Content = canvas;
        }
    }
}
