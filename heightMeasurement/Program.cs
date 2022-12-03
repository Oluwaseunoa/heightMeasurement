class  Program
{
    static void Main()
    {
        int heightInInches = 75; //input
        double heightInCentimeter = heightInInches * 2.54; //inch in cent = 2.54;
        string result = null; //initializing result

        //if statement
        if(heightInCentimeter < 150)
        {
            result = "Dwarf";
        }
        else if(heightInCentimeter >= 150 && heightInCentimeter <= 165)
        {
            result = "Average Height";
        }
        else if(heightInCentimeter >= 165 && heightInCentimeter <= 195)
        {
            result = "Tall";
        }
        else
        {
            result = "Abnormal Height";
        }
        System.Console.WriteLine(result);
        System.Console.ReadKey();
    }
}