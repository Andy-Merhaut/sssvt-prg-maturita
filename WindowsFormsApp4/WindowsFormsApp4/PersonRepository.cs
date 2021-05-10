using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp4
{
    public class PersonRepository
    {
        private MyContext _database = new MyContext();

        public List<Person> SelectAll()
        {
            return this._database.Person.ToList();
        }

        public void Insert(Person person)
        {
            this._database.Person.Add(person);
            this._database.SaveChanges();
        }

        public Person SelectById(int id)
        {
            return this._database.Person.Find(id);
        }

        public void Delete(Person person)
        {
            this._database.Person.Remove(person);
            this._database.SaveChanges();
        }

        public void Update(Person person)
        {
            this._database.Entry(person).State = EntityState.Modified;
            this._database.SaveChanges();
        }
    }
}
