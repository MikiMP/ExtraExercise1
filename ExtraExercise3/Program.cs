//3.Напечатать все простые числа, не превосходящие заданное число M. Вводить М с клавиатуры.
int intTypedNumber = 0;
int intRestOfNumber = 0;

Console.WriteLine("Type any number: ");
int.TryParse(Console.ReadLine(), out intTypedNumber);

for(int i = intTypedNumber - 1; i > 1; i--)
{
    for(int j = 2; j < i; j++)
    {
        intRestOfNumber = i % j;
        if (intRestOfNumber == 0)
        {
            break;
        }
        if (j == i - 1)
            Console.WriteLine($"{i} is prime number which is less than {intTypedNumber}");        
    }
}