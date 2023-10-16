using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;
public class Elements {


    public StackPanel CreateTextElement(string inputText) {
        StackPanel row = new StackPanel();
        var bc = new BrushConverter();
        TextBox Section = new TextBox();
        Section.FontSize = 28;
        Section.Text = inputText;
        Section.IsReadOnly = true;
        Section.HorizontalAlignment= new HorizontalAlignment();
        Section.BorderThickness= new Thickness(0);
        Section.TextWrapping= new TextWrapping();
        Section.FontFamily = new FontFamily("Trebuchet MS");
        Section.VerticalAlignment= new VerticalAlignment();
        Section.Width = 800;
        Section.Margin = new Thickness(40,20,0,0);
        row.Children.Add(Section);
        return row;
    }

    public TextBox inputBox = new TextBox();
    public StackPanel CreateInputTextElement(string inputText) {
        StackPanel row = new StackPanel();
        var bc = new BrushConverter();
        inputBox.FontSize = 28;
        inputBox.Text = inputText;
        inputBox.IsReadOnly = true;
        inputBox.HorizontalAlignment= new HorizontalAlignment();
        inputBox.BorderThickness= new Thickness(0);
        inputBox.TextWrapping= new TextWrapping();
        inputBox.FontFamily = new FontFamily("Trebuchet MS");
        inputBox.VerticalAlignment= new VerticalAlignment();
        inputBox.Width = 800;
        inputBox.Margin = new Thickness(40,20,0,0);
        row.Children.Add(inputBox);
        return row;
    }
    
}