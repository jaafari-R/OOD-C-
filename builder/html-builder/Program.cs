namespace DesignPatterns {
    public class Person
    {
        public string Name;
        public string Position;
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class PersonInfoBuilder {
        protected Person person = new Person();

        public PersonInfoBuilder Called(string name) {
            person.Name = name;
            return this;
        }
    }

    public class PersonJobBuilder : PersonInfoBuilder {
        public PersonJobBuilder WorkAsA(string position) {
            person.Position = position;
            return this;
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            PersonJobBuilder builder = new PersonJobBuilder();
            builder.Called("Ahmed").WorkAsA("Farmer");
        }
    }
}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
