namespace PropNexus.Entities.Interfaces;

public interface IPresenter<T>
{
    T Content { get; }
}