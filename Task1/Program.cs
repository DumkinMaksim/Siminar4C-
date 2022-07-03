
//The program finds the sum of all digits of the number(Программа находит сумму всех цифр числа)
Console.Write("Enter the number: ");

int znums=Convert.ToInt32(Console.ReadLine());

int SumdigitalV2(int znums)
    {
        int rezult=0;
        while (znums>0)
        {   
            rezult=rezult+znums%10;
            znums=znums/10;
        }
    
    return rezult;
    }
Console.WriteLine("Sum digital: "+SumdigitalV2(znums));



