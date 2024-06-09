using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_tasks__1
{
    public class BuyMotoForCompany
    {
        public BuyMotoForCompany(IMoto moto, int money, string cart_number)
        {
            moto.BuyMoto(money, cart_number);
        }
    }

    public interface IMoto
    {
        bool BuyMoto(int money, string card_number);
    }
    public class Hyundai : IMoto
    {
        public Hyundai()
        {

        }

        public bool BuyMoto(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Hyundai moto ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    }

    public class Toyota : IMoto
    {
        public Toyota()
        {

        }

        public bool BuyMoto(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Toyota moto ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    }

    public class Mercedes : IMoto
    {
        public Mercedes()
        {

        }

        public bool BuyMoto(int money, string card_number)
        {
            try
            {
                Console.WriteLine(" You bought Mercedes moto ");
                return true;
            }
            catch
            {
                throw new NotImplementedException();
                return false;
            }
        }
    }

    /*
     buradaki mentiq istifADECI base classdan asili olmalidir torenen classdan yox yeni biz burada mercedes moto dan asili olmamalaiyiq baseden asili olduqda lazim gelse diger motolardanda
    istifade ede bilmeliyik.
     */


}
