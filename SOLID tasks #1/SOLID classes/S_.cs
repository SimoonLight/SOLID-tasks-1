using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_tasks__1
{
    public class Driver
    {
        public string name_ { get; set; }
        public string surname_ { get; set; }
        public int age_ { get; set; }

        public Driver()
        {
            this.name_ = "Empty";
            this.surname_ = "Empty";
            this.age_ = 18; // minimum age
        }

        public void Work()
        {
            Console.WriteLine(" Drive car ");
        }
    }

    public class Cooker
    {
        public string name_ { get; set; }
        public string surname_ { get; set; }
        public int age_ { get; set; }

        public Cooker()
        {
            this.name_ = "Empty";
            this.surname_ = "Empty";
            this.age_ = 18; // minimum age
        }

        public void Work()
        {
            Console.WriteLine(" Cook food ");
        }
    }

    public class Cliner
    {
        public string name_ { get; set; }
        public string surname_ { get; set; }
        public int age_ { get; set; }

        public Cliner()
        {
            this.name_ = "Empty";
            this.surname_ = "Empty";
            this.age_ = 18; // minimum age
        }

        public void Work()
        {
            Console.WriteLine(" Cline company ");
        }
    }

    public class Company
    {
        public Driver driver_ { get; set; }
        public Cooker cooker_ { get; set; }
        public Cliner cliner_ { get; set; }


        public Company()
        {

            driver_ = new Driver();
            cooker_ = new Cooker();
            cliner_ = new Cliner();

        }

        public void show_works()
        {
            driver_.Work();
            cooker_.Work();
            cliner_.Work();
        }

    }

    // Melumat
    // S herifinin baslica fikri bundan ibaretdir ki , bir class sadece bir isi gormelidir . ve bu kodda gosterilen driver , cooker ve cliner heresi oz isini gorur
    // bizim drivere get cookerin isini gor demeyimiz duzgun deil heresinin oz isi var ve heresi sadece oz etmeli oldugu isleri gormelidirler ve bu prinsipde bize bunu oyredir.


}
