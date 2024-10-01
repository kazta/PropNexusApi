namespace PropNexus.Entities.Interfaces;

public interface ICriteria<T>
{
    IQueryable<T> Apply(IQueryable<T> query);
}
