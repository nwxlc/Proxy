namespace Proxy;

public interface IFile : IDisposable
{
    public double GetSize();
    public string GetPath();
    public byte[] Show();
} 