using System;

// The Bhagwan class, which serves as the Superclass
class Bhagwan
{
    public virtual void DisplayForm()
    {
        Console.WriteLine("This is the universal form of God.");
    }
}

// Child class 1 representing Lord Shiv
class shiv : Bhagwan
{
    public override void DisplayForm()
    {
        Console.WriteLine("This is the form of Lord Shiv.");
    }
}
// Child class 2 representing Lord Krishna
class Krishna : Bhagwan
{
    public override void DisplayForm()
    {
        Console.WriteLine("This is the form of Lord Krishna.");
    }
}
// Child class 3 representing Lord Ram
class Ram : Bhagwan
{
    public override void DisplayForm()
    {
        Console.WriteLine("This is the form of Lord Ram.");
    }
}


// Execution Code
class Program
{
    static void Main()
    {
        // Create instance of God, Shiv and Krishna

        Bhagwan universalForm = new Bhagwan();
        Bhagwan shiv = new shiv();
        Bhagwan krishna = new Krishna();
        Bhagwan ram = new Ram();

        // Call the DisplayForm method on each object

        universalForm.DisplayForm();              // Calls Vagwan's DisplayForm method
        shiv.DisplayForm();                       // Calls shiv's overridden DisplayForm method
        krishna.DisplayForm();                    // Calls Krishna's overridden DisplayForm method
        ram.DisplayForm();                        // Calls Ram's overridden DisplayForm method
    }
}


/*We have three child classes, Shiv, Krishna and Ram, each of which overrides the DisplayForm method to provide 
  a specific implementation for displaying the form of the respective deity.*/


/*When we call the DisplayForm method on each object, polymorphism comes into play. 
  Even though the variables are of the parent class type(God), the actual method that gets called 
 depends on the type of the object. As a result, we see the appropriate form displayed for each deity,
 demonstrating polymorphism.*/

/*This example reflects the concept of polymorphism by allowing objects of different classes
 (Shiv, Krishna and Ram) to be treated as objects of a common base class (Bhagwan), 
 and the appropriate method is called based on the actual type of the object*/