namespace CSharpTestTasks.Core.Compression.Abstractions;

// абстракция получателя результата
public interface ITextSink
{
    void Write(string context);
}