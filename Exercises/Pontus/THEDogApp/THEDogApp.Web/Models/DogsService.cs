using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace THEDogApp.Web.Models
{
    public class DogsService
    {
        public static List<Dog> Dogs = new List<Dog>();
        public static int DogsCount = 1;

        public void AddDog(Dog dog)
        {
            dog.Id = DogsCount++;
            Dogs.Add(dog);
        }

        public void EditDog(Dog dog)
        {
            Dogs.Remove(Dogs.FirstOrDefault(d => d.Id == dog.Id));
            Dogs.Add(dog);
        }

        public void DeleteDog(int id)
        {
            Dogs.Remove(Dogs.FirstOrDefault(d => d.Id == id));
        }

        public Dog[] GetAllDogs()
        {
            Dogs.OrderBy(d => d.Id);
            return Dogs.ToArray();
        }

        public Dog GetDogById(int id)
        {
            return Dogs.SingleOrDefault(d => d.Id == id);
        }

    }
}
