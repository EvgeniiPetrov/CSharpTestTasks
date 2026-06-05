namespace CSharpTestTasks.Core.Compression.Abstractions;

// абстракция источника текста
public interface ITextSource
{
    string Read();
}