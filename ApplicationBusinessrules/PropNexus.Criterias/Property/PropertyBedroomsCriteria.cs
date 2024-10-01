using PropNexus.Entities.Interfaces;
using Model = PropNexus.Entities.Models.Property;

namespace PropNexus.Criterias.Property;

public class PropertyBedroomsCriteria(int? bedrooms) : ICriteria<Model>
{
    public IQueryable<Model> Apply(IQueryable<Model> query)
    {
        if (bedrooms == null) return query;
        return query.Where(x => x.Bedrooms == bedrooms);
    }
}
