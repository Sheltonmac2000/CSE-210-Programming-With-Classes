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
        Console.WriteLine("What is your weight(in Kg)?");
        string weight = Console.ReadLine();
        
        Console.WriteLine("What is your height(in cm)?");
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
        Console.WriteLine($"Your height in m is {heightInt}, that square is {heightIntSquared}");
        Console.WriteLine($"Your weight in KG is {weightInt}");
        Console.WriteLine($"Your BMI is: {BMI:F2}");

        if(BMI < 18.5)
        {Console.WriteLine("You are underweight. You should should put on some more pounds.");
        
        }

        else if(BMI >= 18.5 && BMI <24.9)
        {Console.WriteLine("You are at the reommended weight level. Keep it that way!");
        
        }

        else if(BMI >= 25 && BMI <29.9)
        {Console.WriteLine("You are overweight.");
        
        }

        else if(BMI >= 30)
        {Console.WriteLine("You are obese. You should really lose some weight.");
        
        }
    }





}