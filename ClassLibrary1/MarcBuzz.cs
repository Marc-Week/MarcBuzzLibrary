using System.Text;

namespace ClassLibrary1
{
    public static class MarcBuzz
    {

        public static void PrintBuzz()
        {
            Console.Write(RunMarcBuzz());
        }

        public static string RunMarcBuzz()
        {
            StringBuilder buzz = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                buzz.AppendLine(ConvertInt(i));
            }

            return buzz.ToString();
        }


        public static string ConvertInt(int i)
        {
            
                if (i % 3 == 0 && i % 5 == 0)
                    return "Marc Week";
                else if (i % 3 == 0)
                    return "Marc";
                else if (i % 5 == 0)
                    return "Week";
            return i.ToString();
            
        }
    }
}
