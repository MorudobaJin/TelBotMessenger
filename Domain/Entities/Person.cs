using Domain.ValueObjects;

namespace Domain.Enteties
{
    public class Person : BaseEntities
    {
        public Person()
        {

        }

        public FullName FullName { get; set; }

        public DateTime Bday { get; private set; }

        public int Age { 
            get
            { return DateTime.Now.Year - Bday.Year; }
            set {

                //to do организовать set


                return value;
            }
                
        }

        public List<СustomField> costomFields { get; set; }
    }


    //todo лист сущностей

   
}