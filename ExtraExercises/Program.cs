//1.Можно ли узнать, что число четное по битам? Если да, как бы вы это сделали?
//Это очень легко узнать, нам нужно проверить младший бит числа в двоичном коде. 0 = четное, 1 = не четное.
int intDecimalNumber = 0;
int[] intBinaryNumber = new int[32]; //Why 32? int32 needs 32 bits

Console.WriteLine("Type any number: ");
int.TryParse(Console.ReadLine(), out intDecimalNumber);

string stringTypeOf = "Typed number is even";

for (int i = 0; i < intBinaryNumber.Length; i++)
{
    intBinaryNumber[i] = intDecimalNumber % 2;
    intDecimalNumber /= 2;
}

if (intBinaryNumber[0] == 1)
{
    stringTypeOf = "Typed number is odd";
}

Console.WriteLine(stringTypeOf);
Console.ReadKey();