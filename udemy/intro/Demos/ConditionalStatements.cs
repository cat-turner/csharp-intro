namespace Demos
{
    public class ConditionalStatements
    {
        public static void demoChainedCond()
        {
            // if/else example

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("Its amazing");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("Its afternoon");
            }
            else
            {
                System.Console.WriteLine("its evening");
            }
        }

        public static void demoCondOperator()
        {
            bool isGoldCustomer = true;

            //float price;
            // if (isGoldCustomer)
            // {
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }
            // this next line is same as above

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            System.Console.WriteLine(price);
        }

        public static void demoSwitchWithEnum()
        {
            var season = Season.Spring;
            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("its autumn");
                    break;
                
                case Season.Summer:
                    System.Console.WriteLine("its summer");
                    break;

                case Season.Winter:
                case Season.Spring:
                System.Console.WriteLine(" brrrrr");
                break;

                default:
                    System.Console.WriteLine("I dont understand that season");
                    break;

            }
        }
    }
}