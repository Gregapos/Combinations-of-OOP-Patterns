public class FileSystemBuilder
{
    public Folder Root {get;}
    public Folder CurrentFolder {get; set;}

    public FileSystemBuilder(string rootName)
    {
        Root = new Folder(rootName);
        CurrentFolder = Root;
    }

    public FileSystemBuilder BuildFolder(string name)
    {
        var folder = new Folder(name);
        CurrentFolder.AddChild(folder);
        return this;
    }

    public FileSystemBuilder BuildFile(string name, long size)
    {
        var file = new File(name, size);
        CurrentFolder.AddChild(file);
        return this;
    }

    public FileSystemBuilder SetCurrentFolder(string currentFolderName)  
    {  
        var folderStack = new Stack<Folder>();  
        folderStack.Push(Root);  
        while (folderStack.Any())  
        {  
            //topmost element  
            var currentFolder = folderStack.Pop();  

            if(currentFolderName == currentFolder.Name)  
            {  
                this.CurrentFolder = currentFolder;  
                return this;  
            }  

            //iterate through childrens  
            //As directory can have file and directory both we have specify what are we iterating  
            foreach (var item in currentFolder.Children.OfType<Folder>())  
            {  
                //we are inserting childrens of the root and it will check for its name in code up above  
                folderStack.Push(item);  
            }  
        }  
        //let the user know that he is looking for wrong directory.  
        throw new Exception($"Folder name: '{ currentFolderName }' not found!");  
    }  

    public Folder Build() {
        return Root;
    }
}