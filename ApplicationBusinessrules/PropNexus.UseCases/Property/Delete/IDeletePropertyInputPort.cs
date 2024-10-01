namespace PropNexus.UseCases.Property.Delete;

public interface IDeletePropertyInputPort
{
    Task Handle(long id);
}