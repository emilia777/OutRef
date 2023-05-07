// 3 METOD YARAT SADE,OUT,REF//
namespace OutRef
{

    class Program
    {

        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Age = 10;
            newPerson.ID = 44;
            newPerson.Name = "emilia";
            Modify(newPerson);
            Console.WriteLine(newPerson.Age);
            Mod(out newPerson);
            Console.WriteLine(newPerson.Name);
            Mody(ref newPerson);
            Console.WriteLine(newPerson.ID);
            static void Modify(Person newPerson)
            {
                newPerson.Age = 33;
            }
            static void Mod(out Person newPerson)
            {
                newPerson = new Person();
                newPerson.Name = " gunel";
            }
            static void Mody(ref Person newPerson)
            {
                newPerson = new Person();
                newPerson.ID = 3;
            }
        }
        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
        }
    }
} 

