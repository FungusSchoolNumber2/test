namespace Test1;

interface Tools
{
    static int SafeInts(string input, int? maxValue = null, int? minValue = null)
    {
        int output;
        while (true)
        {
            while (!int.TryParse(input, out output))
            {
                Console.WriteLine("That is not a valid number please try again!");
                input = Console.ReadLine();
            }

            if (maxValue == null && minValue == null)
            {
                break;
            }
            else if (maxValue != null && minValue == null)
            {
                if (output >= maxValue)
                {
                    Console.WriteLine("The number needs to be under " + maxValue);
                }
                else
                {
                    break;
                }
            }
            else if (maxValue == null && minValue != null)
            {
                if (output <= minValue)
                {
                Console.WriteLine("The number needs to be over " + minValue);
                    
                }
                else
                {
                    break;
                }
            }
            else
            {
                if ((output >= maxValue) && (output <= minValue))
                {
                    Console.WriteLine($"The number need to be between {minValue} and {maxValue}");
                }
                else
                {
                    break;
                }
            }

            input = "x";
        }

        return output;
    }
}