//2.Известно, что у всех чисел, которые являются степенью двойки, только один бит == 1. 
//  Написать приложение, которое будет проверять, что чисто является степенью двойки.
int intDecimalNumber = 0;
int intOnesCounter = 0;
int[] intBinaryNumber = new int[32]; 

Console.WriteLine("Type any number: ");
int.TryParse(Console.ReadLine(), out intDecimalNumber);

for (int i = 0; i < intBinaryNumber.Length; i++)
{
    intBinaryNumber[i] = intDecimalNumber % 2;
    intDecimalNumber /= 2;

    intOnesCounter = intBinaryNumber[i] == 1 ? intOnesCounter + 1 : intOnesCounter;

    if (intOnesCounter == 2)
    {
        Console.WriteLine("Typed number isn't the power of two");
        break;
    }    

}

if (intOnesCounter != 2)
{
    for (int i = 0; i < intBinaryNumber.Length; i++)  //should we create new variable here? not i.
    {
        if (intBinaryNumber[i] == 1)
        {
            Console.WriteLine($"Typed number is 2^{i}");
            break;
        }

    }
}

Console.ReadKey();