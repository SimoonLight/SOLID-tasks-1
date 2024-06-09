using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_tasks__1
{
    public abstract class Base_
    {
        public abstract void Suret(); 
    }
    public interface Komekci_
    {
        public void Teker(); 
    }

    public class Car : Base_, Komekci_
    {
        public Car() { }
        public override void Suret()
        {
            Console.WriteLine(" Car class Suret method ");
        }

        public void Teker()
        {
            Console.WriteLine(" Car class Teker method ");
        }
    }
    public class Airplane : Base_, Komekci_
    {
        public Airplane() { }
        public override void Suret()
        {
            Console.WriteLine(" Airlane class Suret method ");
        }

        public void Teker()
        {
            Console.WriteLine(" Airlane class Teker method ");
        }
    }
    public class Train : Base_
    {
        public Train() { }
        public override void Suret()
        {
            Console.WriteLine(" Train class Suret method ");
        }

    }

    /*
     burada bize basa salinmaq istenen ideya odur ki ehtiyyac duyuldugda torenen class base classi evez ede bilmelidir .
    programda gosterdiyim kimi Car ve Airplane nin teker funksiyalari var ama Trinin yoxdur eger men ayri interface yaradmasaydim bu funksiyanin icerisini bos qoymali idim
    cunki qatarlarin tekeri olmur ve buda mukemmel kod olmur. ona gorede biz base classa butun classlarda olacaq funksiyalari yaziriq ve her hansisa bir classa xususi bir sey lazimdir sa ayri
    interface yaradib bunu onun icerisine yerlesdiririk. beleliklede liskovun principine uygun kod yaziriq.
     */

}
