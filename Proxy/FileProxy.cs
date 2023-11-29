using System.ComponentModel.Design;

namespace Proxy;

public class FileProxy : IFile
{
    private File? _file;
    private string _path;
    public FileProxy(string path)
    {
        _path = path;
    }
    
    public double GetSize()
    {
        if (_file == null)
        {
            _file = new File(_path);
        }
        if (_file != null)
        {
            return _file.GetSize();
        }
        else
        {
            return 0;
        }
    }

    public string GetPath()
    {
        if (_file == null)
        {
            _file = new File(_path);
        }
        if (_file != null)
        {
            return _path;
        }
        else
        {
            return null;
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