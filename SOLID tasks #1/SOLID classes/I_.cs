using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_tasks__1
{
    public interface eye
    {
        public void have_eye();
    }
    public interface foot
    {
        public void have_foot();
    }
    public interface hand
    {
        public void have_hand();
    }
    public class Human : eye, foot, hand
    {
        public void have_eye()
        {
            Console.WriteLine(" Human class have eye method ");
        }

        public void have_foot()
        {
            Console.WriteLine(" Human class have foot method ");
        }

        public void have_hand()
        {
            Console.WriteLine(" Human class have hand method ");
        }
    }
    
    public class Horse : eye, foot
    {
        public void have_eye()
        {
            Console.WriteLine(" Horse class have eye method ");
        }

        public void have_foot()
        {
            Console.WriteLine(" Horse class have foot method ");
        }

    }
    
    public class Snake : eye
    {
        public void have_eye()
        {
            Console.WriteLine(" Snake class have eye method ");
        }

    }

    /*
     bu principin bize oyretmek istediyi sey odur ki biz classin ozelliklerine gore interfaceler yaratmaliyiq . cunki base classdan butun ozellikler gelir ve 
    child classlar onlarin hamisini istifade edemeye biler ona gorede bize bu kodu interfacelere bolmek lazimdir bu sayede istediyimiz ozelliyi classlara verib istifade ede bileceyik.
     */
}
