using PropNexus.Entities.Interfaces;

namespace PropNexus.Criterias;

public class CriteriaList<T>(params ICriteria<T>[] criterias) : ICriteria<T>
{
    public IQueryable<T> Apply(IQueryable<T> query)
    {
        foreach (var item in criterias)
        {
            query = item.Apply(query);
        }
        return query;
    }
}