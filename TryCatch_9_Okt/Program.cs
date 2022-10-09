namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TryCatch eller Exception Handling - Alltså att man tar hand om Exceptions (krashar)

            try // Kod som vi tror kanske krashar lägger vi här inne och om den krashar så körs koden i catch 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            catch  // Kod som körs om try krashar programmet - I vanliga fall vill man ha en parameter () för specifika fall och inte en stor generell som denna 
            {
                Console.WriteLine("Error"); // Skriver ut Error
            }

            ////////////////////////////////////////////////////////////////////////////

            try // Kod som vi tror kanske krashar lägger vi här inne och om den krashar så körs koden i catch 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            catch (Exception e) // Fångar vad som blir fel och sparar det i en parameter
            {
                Console.WriteLine(e.Message); // Skriver ut vad som gick fel genom 'e' parametern 
            }
            finally
            {
                Console.WriteLine("YOLOOOOO");// kod som alltid utförs oavsätt vad i slutet
            }

            ////////////////////////////////////////////////////////////////////////////

            try // Kod som vi tror kanske krashar lägger vi här inne och om den krashar så körs koden i catch 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            catch (DivideByZeroException e) // Fångar om det blir ett DivideByZeroException och utför koden nedan
            {
                Console.WriteLine("Kod som förklarar DivideByZeroException eller löser problemet....");  
            }
            catch (FormatException e) // Fångar om det blir ett FormatException och utför koden nedan
            {
                Console.WriteLine("Kod som förklarar FormatException eller löser problemet....");
            }
            finally
            {
                // kod som alltid utförs oavsätt vad 
            }
        }
    }
}