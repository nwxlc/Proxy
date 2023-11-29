namespace Proxy;

public class File : IFile
{
    private MemoryStream _memoryStream;

    public File()
    {
        _memoryStream = new MemoryStream();
    }

    public double GetSize()
    {
        return _memoryStream.Length;
    }

    public string GetPath()
    {
        return "In Memory";
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