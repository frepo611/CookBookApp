namespace CookBookApp.Classes;
    
class StringsTextRepository : IStringsRepository
{
    private static readonly string LineSeparator = Environment.NewLine;
    private static readonly string IDSeparator = ",";
    public List<string> Read(string filePath)
    {   
        if (!(File.Exists(filePath)))
            {
                return new List<string>();
            }

        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(LineSeparator).ToList();
    }
    public void Write(string filePath, List<string> strings)
    {
        string asString = string.Join(LineSeparator, strings);
        File.WriteAllText(filePath, asString);
    }
    public List<List<int>> GetIdsAsLists(List<string> strings)
    {
        var recipesAsIds = new List<List<int>>();
        foreach (var item in strings)
            {
                var ids = item.Split(IDSeparator).ToList();
                var idsAsLists = new List<int>();
                foreach (string id in ids)
                    {
                        idsAsLists.Add(int.Parse(id));
                    }
                recipesAsIds.Add(idsAsLists);
            }  
        return recipesAsIds;
    }
}

public interface IStringsRepository
{
    public List<string> Read(string filePath);
    public void Write(string filePath, List<string> strings);
    public List<List<int>> GetIdsAsLists(List<string> strings);
}