using System.Configuration; // Include this for using configuration settings

class Program
{
    static void Main()
    {
        IGUIFactory guiFactory = Initialize();
        IButton button = guiFactory.CreateButton();
        ICheckbox checkbox = guiFactory.CreateCheckbox();
        button.Render();
        checkbox.Render(); // The output will depend on the OS type configuration
    }

    static IGUIFactory Initialize()
    {
        AppSettingsReader reader = new AppSettingsReader();

        string osType = (string)reader.GetValue("OSType", typeof(string));
        IGUIFactory guiFactory;
        if (osType == "Windows") guiFactory = new WindowsFactory();
        else if (osType == "MacOS") guiFactory = new MacOSFactory();
        else throw new NotSupportedException($"Unknown OS type: {osType}");

        return guiFactory;
    }
}
