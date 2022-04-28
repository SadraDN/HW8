namespace HW8
{
    public class PersonDb
    {

        private static List<Person> _persons = new List<Person>
        {
            new Person{
                Id =11,
                Name = "صدرا"
            },
            new Person{
                Id=22,
                Name= "حسین"
            },
            new Person{
                Id=33,
                Name= "مجید"
            },
            new Person{
                Id=44,
                Name= "مهدی"
            },
            new Person{
                Id=55,
                Name= "امین"
            }
        };

        public static List<Person> GetAllPerson()
        {
            return _persons;
        }

        public static Person GetById(int id)
        {
            return _persons.FirstOrDefault(x => x.Id == id);
        }


        public static bool Delete(int id)
        {
            var per = _persons.FirstOrDefault(x => x.Id == id);
            return _persons.Remove(per);
        }

        public void UpdatePerson(Person model)
        {
            var person = GetById(model.Id);
            person.Name = model.Name;
        }

    }
    }
