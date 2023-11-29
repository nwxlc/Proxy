namespace Proxy;

public interface IFile
{
    public double GetSize();
    public string GetPath();
    public byte[] Show();
}