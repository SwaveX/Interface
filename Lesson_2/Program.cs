IDataProcessor datProcessor = new ConsoleDataProcessor();
datProcessor.ProcessData(new DbDataProvider());
datProcessor.ProcessData(new FileDataProvider());
datProcessor.ProcessData(new APIDataProvider());


interface IDataProvider
{
    string GetData();
}
interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from DB";
    }
}
class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from File";
    }
}
class APIDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from API";
    }
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}
