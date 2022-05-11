using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string substring = "in";

            //Брояч, колко пъти се среща substring-а
            int counter = 0;

            //превръщам текста към малки букви
            //text = text.ToLower();

            //търся първата поява на събстринга
            int index = text.IndexOf(substring, StringComparison.OrdinalIgnoreCase);

            //Докато намирам събстринга в текста въртя цикъл
            while (index != -1)
            {
                //увеличавам брояча всеки път с 1, когато намеря събстринга
                counter++;
                
                //премахвам намерения събстринг
                text = text.Remove(index, 2);

                //търся следващия събстринг
                index = text.IndexOf(substring, StringComparison.OrdinalIgnoreCase);

            }
        }
    }
}
