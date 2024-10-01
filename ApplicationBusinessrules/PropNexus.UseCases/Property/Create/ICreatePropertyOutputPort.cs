namespace PropNexus.UseCases.Property.Create;

public interface ICreatePropertyOutputPort
{
    Task Handle(bool success);
}