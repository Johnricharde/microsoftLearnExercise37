namespace microsoftLearnExercise37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};






            try
            {
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }





            static void Workflow1(string[][] userEnteredValues)
            {

                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }





            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {

                    try
                    {
                        valueEntered = int.Parse(userValue);
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                    checked
                    {
                        try
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                        catch (DivideByZeroException)
                        {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }
                    }
                }
            }
        }
    }
}
