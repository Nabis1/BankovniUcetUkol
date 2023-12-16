namespace BankovniUcetUkol
{
    public class InputValidation
    {
        static public int GetIntFromConsole(int minimumAllowedInt = 0, int maximumAllowedInt = int.MaxValue)
        {
            int inputFromUserConverted = 0;
            bool isConvertedValueValid = false;
            while( !isConvertedValueValid ) 
            {
                Console.WriteLine($"Please insert a valid integer value between {minimumAllowedInt} and {maximumAllowedInt}: ");
                bool isParsingValid = int.TryParse(Console.ReadLine(), out inputFromUserConverted);
                if( inputFromUserConverted >= minimumAllowedInt && inputFromUserConverted <= maximumAllowedInt && isParsingValid)
                {
                    isConvertedValueValid = true;
                }
            }

            return inputFromUserConverted;
        }

        static public double GetDoubleFromConsole(double minimumAllowedDouble = 0, double maximumAllowedDouble = double.MaxValue)
        {
            double inputFromUserConverted = 0;
            bool isConvertedValueValid = false;
            while (!isConvertedValueValid)
            {
                Console.WriteLine($"Please insert a valid double value between {minimumAllowedDouble} and {maximumAllowedDouble}: ");
                bool isParsingValid = double.TryParse(Console.ReadLine(), out inputFromUserConverted);
                if (inputFromUserConverted >= minimumAllowedDouble && inputFromUserConverted <= maximumAllowedDouble && isParsingValid)
                {
                    isConvertedValueValid = true;
                }
            }

            return inputFromUserConverted;
        }
    }
}
