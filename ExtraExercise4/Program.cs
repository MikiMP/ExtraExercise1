//4.Натуральное число называется совершенным, если оно равно сумме всех своих собственных делителей,
//  включая 1. Напечатать все совершенные числа, меньшие, чем заданное M. Вводить М с клавиатуры.

int intTypedNumber = 0;
int intRest = 0;
int intSumOfDivisors = 0;

Console.WriteLine("Type any number: ");
int.TryParse(Console.ReadLine(), out intTypedNumber);

for (int i = intTypedNumber - 1; i >= 1; i--)
{
    for(int j = 1; j < i; j++)
    {
        // intSumOfDivisors = i % j == 0 ? intSumOfDivisors + j : intSumOfDivisors;

        intRest = i % j;

        if (intRest == 0)
           intSumOfDivisors += j;
            

        if (intSumOfDivisors == i & j == i - 1)
            Console.WriteLine($"{i} is perfect number which is less than {intTypedNumber}");
    }
    intSumOfDivisors = 0;
}