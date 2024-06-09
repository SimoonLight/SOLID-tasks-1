using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_tasks__1
{

    // bu princip bize deyirki program yenilikliklere aciq ama deyisime qapali olmalidir yeni biz kodumuzu ele yazmaliyiq ki kod bizim teyin etdiyimiz hall dogruntusunda deyise bilsin,
    // kodu bir daha yeniden deyismeyek. kodu yazmamisdan evvel plan qurub gelecekdeki deyisimlere gore kod yazmaliyir. meselen bu kodda sirked hyundai alir ama sahab eger sirket toyota
    // almaq istese artiq kodda deyisiklik etmeye ehtiyyac qalmayacaq, sadece main icerisinde hyundai yetine toyota yazilacaq ve buda bizi boyuk bir zehmetden qurtarir.

    public class BuyCarForCompany
    {
        public BuyCarForCompany(ICar car, int money, string cart_number)
        {
            car.BuyCar(money, cart_number);
        }
    }

    public interface ICar
    {
        bool BuyCar(int money, string card_number);
    }
    public class Hyundai : ICar
    {
        public Hyundai()
        {

        }

        public bool BuyCar(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Hyundai car ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    } 
    
    public class Toyota : ICar
    {
        public Toyota()
        {

        }

        public bool BuyCar(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Toyota car ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    } 
    
    public class Mercedes : ICar
    {
        public Mercedes()
        {

        }

        public bool BuyCar(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Mercedes car ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    }

}
