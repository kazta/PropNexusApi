# PropNexusApi

## Descripción

Esta es una aplicación desarrollada en .NET 8 que sigue la arquitectura limpia propuesta por Uncle Bob. Utiliza los patrones de Input y Output Ports, Repository y Criteria. Además, se han utilizado varias librerías adicionales para mejorar la funcionalidad y las pruebas.

## Requisitos

- .NET 8 SDK
- SQL Server (o cualquier otro sistema de base de datos compatible)
- EntityFrameworkCore
- Google.Cloud.Storage.V1
- NUnit

## Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/kazta/PropNexusApi.git
   cd tu-repositorio

2. **Restaurar paquetes NuGet**:
    ```bash
    dotnet restore

3. **Configurar la base de datos**:
    * La aplicación está configurada para conectarse a una instancia de SQL Server 2019 alojada en Cloud SQL.
    * Si deseas usar una base de datos local, ejecuta el script proporcionado en scripts/database.sql para crear las tablas necesarias.
    ```sql
    CREATE TABLE agents (
    id BIGINT PRIMARY KEY IDENTITY(1,1),
    first_name NVARCHAR(MAX) NOT NULL,
    last_name NVARCHAR(MAX) NOT NULL,
    email NVARCHAR(MAX) UNIQUE NOT NULL,
    phone NVARCHAR(MAX) NOT NULL
    );

    CREATE TABLE clients (
        id BIGINT PRIMARY KEY IDENTITY(1,1),
        first_name NVARCHAR(MAX) NOT NULL,
        last_name NVARCHAR(MAX) NOT NULL,
        email NVARCHAR(MAX) UNIQUE NOT NULL,
        phone NVARCHAR(MAX) NOT NULL
    );

    CREATE TABLE listing_statuses (
        id BIGINT PRIMARY KEY IDENTITY(1,1),
        status_name NVARCHAR(MAX) NOT NULL UNIQUE,
        description NVARCHAR(MAX)
    );

    CREATE TABLE owners (
        id BIGINT PRIMARY KEY IDENTITY(1,1),
        first_name NVARCHAR(MAX) NOT NULL,
        last_name NVARCHAR(MAX) NOT NULL,
        email NVARCHAR(MAX) UNIQUE NOT NULL,
        phone NVARCHAR(MAX) NOT NULL
    );

    CREATE TABLE property_trace (
        id BIGINT PRIMARY KEY IDENTITY(1,1),
        property_id BIGINT FOREIGN KEY REFERENCES properties(id),
        agent_id BIGINT FOREIGN KEY REFERENCES agents(id),
        client_id BIGINT FOREIGN KEY REFERENCES clients(id),
        listing_date DATE NOT NULL,
        status_id BIGINT FOREIGN KEY REFERENCES listing_statuses(id)
    );

    CREATE TABLE property_images (
        id BIGINT PRIMARY KEY IDENTITY(1,1),
        property_id BIGINT FOREIGN KEY REFERENCES properties(id),
        image_url NVARCHAR(MAX) NOT NULL,
        description NVARCHAR(MAX)
    );

    ALTER TABLE properties
    ADD FOREIGN KEY (owner_id) REFERENCES owners(id);

4. **Actualizar la cadena de conexión**:
    * Modifica el archivo InterfaceAdapters/ropNexus.IoC/DependencyContainer para incluir la cadena de conexión a tu base de datos.

5. **Ejecución**
Para ejecutar la aplicación, utiliza el siguiente comando:
    ```bash
    dotnet run

6. **Pruebas**
 * Para ejecutar las pruebas unitarias, utiliza el siguiente comando:
    ```bash
    dotnet test

**Librerías Adicionales**
 * EntityFrameworkCore: Utilizado para el acceso a datos y mapeo objeto-relacional (ORM).
 * Google.Cloud.Storage.V1: Utilizado para interactuar con Google Cloud Storage.
 * NUnit: Utilizado para realizar pruebas unitarias.

**Arquitectura**

La aplicación sigue la arquitectura limpia (Clean Architecture) propuesta por Uncle Bob. A continuación, se describen los componentes principales:

**Input y Output Ports**
 * Input Ports: Interfaces que definen los casos de uso de la aplicación. Son implementadas por los interactores.
 * Output Ports: Interfaces que definen cómo se deben presentar los datos. Son implementadas por los presentadores.

**Patrón Repository**

Repository: Patrón utilizado para abstraer el acceso a los datos. Define métodos para interactuar con la base de datos sin exponer detalles de implementación.

**Patrón Criteria**

* Criteria: Utilizado para encapsular los criterios de búsqueda y filtrado de datos. Permite construir consultas de manera flexible y reutilizable.

**Ejemplo de Código**

```C#
public class GetAllPropertyInteractor : IGetAllPropertyInputPort
{
    private readonly IGetAllPropertyOutputPort _outputPort;
    private readonly IPropertyRepository _repository;

    public GetAllPropertyInteractor(IGetAllPropertyOutputPort outputPort, IPropertyRepository repository)
    {
        _outputPort = outputPort;
        _repository = repository;
    }

    public async Task Handle(PropertyRequest request)
    {
        var criteria = new CriteriaList<Model>(new PropertyBedroomsCriteria(request.Bedrooms));
        var entities = await _repository.GetAllAsync(criteria);
        var dtos = entities.Select(entity => new PropertyDto
        {
            Id = entity.Id,
            Address = entity.Address,
            City = entity.City,
            State = entity.State,
            ZipCode = entity.ZipCode,
            Price = entity.Price,
            Bedrooms = entity.Bedrooms,
            Bathrooms = entity.Bathrooms,
            SquareFeet = entity.SquareFeet,
            PropertyType = entity.PropertyType,
            Description = entity.Description,
            OwnerId = entity.OwnerId
        });

        await _outputPort.Handle(dtos);
    }
}