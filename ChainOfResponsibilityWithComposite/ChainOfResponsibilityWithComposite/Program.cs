using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Panel mainPanel = new Panel("Main Panel");
        Panel subPanel = new Panel("Sub Panel");
        Button button1 = new Button("Button 1");
        Button button2 = new Button("Button 2");

        mainPanel.AddComponent(subPanel);
        subPanel.AddComponent(button1);
        mainPanel.AddComponent(button2);

        button1.HandleEvent("Scroll");  
        button2.HandleEvent("Click");   
        button1.HandleEvent("Resize"); 
    }
}
