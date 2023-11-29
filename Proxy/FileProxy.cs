

namespace Proxy;

public class FileProxy : IFile, IDisposable
{
    private File _file;

    public FileProxy(File file)
    {
        _file = file;
    }
    
    public double GetSize()
    {
        return _file.GetSize();
    }

    public string GetPath()
    {
        return _file.GetPath();
    }

    public byte[] Show()
    {
        _file = new File();
        return _file.Show();
    }

    public void Dispose()
    {
        _file.Dispose();
    }
}