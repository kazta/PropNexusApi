using Moq;
using PropNexus.Criterias;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using Model = PropNexus.Entities.Models.Property;
using PropNexus.UseCases.Property.GetAll;

namespace PropNexus.UnitTest.Property;

[TestFixture]
public class GetAllPropertyInteractorTests
{
    private Mock<IGetAllPropertyOutputPort> _mockOutputPort;
    private Mock<IPropertyRepository> _mockRepository;
    private GetAllPropertyInteractor _interactor;

    [SetUp]
    public void SetUp()
    {
        _mockOutputPort = new Mock<IGetAllPropertyOutputPort>();
        _mockRepository = new Mock<IPropertyRepository>();
        _interactor = new GetAllPropertyInteractor(_mockOutputPort.Object, _mockRepository.Object);
    }

    [Test]
    public async Task Handle_ShouldCallRepositoryAndOutputPort()
    {
        // Arrange
        var request = new PropertyRequest { Bedrooms = 3 };
        var entities = new List<Model>
        {
            new() { Id = 1, Address = "123 Main St", City = "Anytown", State = "CA", ZipCode = "12345", Price = 250000, Bedrooms = 3, Bathrooms = 2, SquareFeet = 1500, PropertyType = "House", Description = "Nice house", OwnerId = 1 }
        };
        _mockRepository.Setup(repo => repo.GetAllAsync(It.IsAny<CriteriaList<Model>>())).ReturnsAsync(entities);

        // Act
        await _interactor.Handle(request);

        // Assert
        _mockRepository.Verify(repo => repo.GetAllAsync(It.IsAny<CriteriaList<Model>>()), Times.Once);
        _mockOutputPort.Verify(port => port.Handle(It.Is<IEnumerable<PropertyDto>>(dtos => dtos.First().Id == 1)), Times.Once);
    }
}
