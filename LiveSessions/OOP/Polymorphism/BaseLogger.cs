namespace OOP.Polymorphism;

public abstract class BaseLogger
{
    public abstract void Log();
    public abstract void Error(string message);
    public abstract void Info(string message);
    public abstract void Debug(string message);
}
