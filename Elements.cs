using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;
public class Elements {

    public TextBox CreateTextElement(string inputText) {
        var bc = new BrushConverter();
        TextBox Section = new TextBox();
        Section.FontSize = 16;
        Section.Text = inputText;
        Section.IsReadOnly = true;
        Section.HorizontalAlignment= new HorizontalAlignment();
        Section.BorderThickness= new Thickness(0);
        Section.TextWrapping= new TextWrapping();
        Section.FontFamily = new FontFamily("Trebuchet MS");
        Section.VerticalAlignment= new VerticalAlignment();
        Section.Width = 400;
        Section.Margin = new Thickness(5,0,0,0);
        return Section;
    }

    public List<TextBox> inputBoxList = new List<TextBox>();
    public StackPanel CreateInputTextElement(string inputText) {
        StackPanel row = new StackPanel();
        var bc = new BrushConverter();
        TextBox inputBox = new TextBox();
        inputBox.FontSize = 28;
        inputBox.Text = inputText;
        inputBox.HorizontalAlignment= new HorizontalAlignment();
        inputBox.BorderThickness= new Thickness(0);
        inputBox.TextWrapping= new TextWrapping();
        inputBox.FontFamily = new FontFamily("Trebuchet MS");
        inputBox.VerticalAlignment= new VerticalAlignment();
        inputBox.Width = 800;
        inputBox.Margin = new Thickness(40,20,0,0);
        row.Children.Add(inputBox);
        inputBoxList.Add(inputBox);
        return row;
    }
    
}
