
namespace Proxy;

public class FileProxy : IFile
{
    private File? _file;
    private string _path;
    public FileProxy(string path)
    {
        _path = path;
        _file = new File(path);
    }
    
    public double GetSize()
    {
        if (_file != null)
        {
            return _file.GetSize();
        }
        else
        {
            return new FileInfo(_path).Length;
        }
    }

    public string GetPath()
    {
        if (_file != null)
        {
            return _file.GetPath();
        }
        else
        {
            return _path;
        }
        
    }

    public byte[] Show()
    {
        if (_file == null)
        {
            _file = new File(_path);
        }
        return _file.Show();
    }

    public void Dispose()
    {
        if (_file != null)
            _file.Dispose();
    }
}