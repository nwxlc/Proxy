namespace Proxy;

public class File : IFile
{
    private MemoryStream _memoryStream;
    private string _path;
    
    public File(string path)
    {
        _path = path;
        _memoryStream = new MemoryStream();
    }

    public double GetSize()
    {
        return _memoryStream.Length;
    }

    public string GetPath()
    {
        return _path;
    }

    public byte[] Show()
    {
        return _memoryStream.ToArray();
    }

    public void Dispose()
    {
        _memoryStream.Dispose();
    }
}