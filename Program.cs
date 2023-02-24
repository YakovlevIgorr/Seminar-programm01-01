Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int numberEven = 2;
while (numberEven <= number1)
{
    Console.Write(numberEven + " ");
    numberEven = numberEven + 2;
}
