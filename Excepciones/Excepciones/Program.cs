using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string content = File.ReadAllText(@"C:\test.txt");
                //Console.WriteLine(content);

                throw new Exception("Ocurrio algo raro");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aquí me ejecuto pase lo que pase");
            }

            Console.WriteLine("Aqui se sigue ejecutando");

        }
    }
}