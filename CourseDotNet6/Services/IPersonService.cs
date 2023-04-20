using CourseDotNet6.Controllers;
using CourseDotNet6.Model;

namespace CourseDotNet6.Services
{
    public interface IPersonService
    {
        List<Person> FindAll();
        Person FindById (long id);
        Person Create (Person person);
        Person Update (Person person);
        Person Delete (long id);
    }
}
