namespace CSharpTestTasks.Core.Compression.Abstractions;

// контракт алгоритма компрессии / декомпрессии
public interface IStringCompressor
{
    string Compress(string input);
    string Decompress(string input);
}