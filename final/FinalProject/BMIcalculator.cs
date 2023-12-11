public class BMIcalculator
{
    private double weightInt
    {get;set;}

    private double heightInt
    {get;set;}

    private double heightIntSquared;
    private double BMI;
    // {get;set;}

    public Tuple<double,double> getWeightAndHeight()
    {// In this function I will return a tuple, because I cannot direclty return two values. A tuple allows me to return multiple
        //values at once.
        Console.WriteLine("\nWhat is your weight(in Kg)?");
        string weight = Console.ReadLine();
        
        Console.WriteLine("\nWhat is your height(in cm)?");
        string height = Console.ReadLine();

         try
        {
            // Use the setter to store the duration
            weightInt = Convert.ToInt32(weight);
            heightInt = Convert.ToInt32(height);
           
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the duration.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The entered value is too large to fit into a 32-bit integer.");
        }

        return Tuple.Create(weightInt,heightInt);
    }

    public void getBMI()
    {   
        double heightIntSquared = Math.Pow(heightInt/100,2);
        double BMI = weightInt / heightIntSquared;

        //BMI = weight(kg) / height**2
        Console.WriteLine($"\nYour height in cm is {heightInt}.\n");
        Console.WriteLine($"\nYour weight in KG is {weightInt}.\n");
        Console.WriteLine($"\nYour BMI is: {BMI:F2}\n");

        if(BMI < 18.5)
        {Console.WriteLine("\nYou are underweight. You should should put on some more pounds.\n");
        
        }

        else if(BMI >= 18.5 && BMI <24.9)
        {Console.WriteLine("\nYou are at the reommended weight level. Keep it that way!\n");
        
        }

        else if(BMI >= 25 && BMI <29.9)
        {Console.WriteLine("\nYou are overweight.\n");
        
        }

        else if(BMI >= 30)
        {Console.WriteLine("\nYou are obese. You should really lose some weight.\n");
        
        }
    }





}