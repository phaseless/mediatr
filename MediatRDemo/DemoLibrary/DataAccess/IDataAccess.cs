using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public interface IDataAccess
{
    List<PersonModel> GetPeople { get; }
    PersonModel InsertPerson(string firstName, string lastName);
}