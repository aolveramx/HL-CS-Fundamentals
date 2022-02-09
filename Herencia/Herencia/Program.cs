using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctorOne = new Doctor("Juan", 40, "Cardiologist");
            Console.WriteLine(doctorOne.GetInfo());
            Console.WriteLine(doctorOne.GetData());

            Dev devOne = new Dev("Ari", 29, "C#");
            Console.WriteLine(devOne.GetInfo());
            Console.WriteLine(devOne.GetData());
        }

        class People
        {
            private string _name;
            private int _age;

            public People(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string GetInfo()
            {
                return _name + " " + _age;
            }

            
        }

        class Doctor : People
        {
            private string _specialty;
            public Doctor(string name, int age, string specialty) : base(name, age)
            {
                _specialty = specialty;
            }

            public string GetData()
            {
                return GetInfo() + "  " + _specialty;
            }
        }

        class Dev : People
        {
            private string _language;

            public Dev(string name, int age, string language) : base(name, age)
            {
                _language = language;
            }

            public string GetData()
            {
                return GetInfo() + " " + _language;
            }
        }
    }
}
