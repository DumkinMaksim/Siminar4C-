//Program for creating an array of n elements (Программа по созданию массива из n  элементов)

Console.WriteLine("EnterEnter the size of the array");
int masn=Convert.ToInt32(Console.ReadLine());
if (masn>0)
{


Console.WriteLine("Create array of the "+masn+" elements");
int i=0;
string MassivV2(int masn,int i)
{
    
    string z=" ";
    int[] massiv=new int [masn];
    for(i=0;i<masn;i++)
    {
        
        int ramd=new Random().Next(1,1000);
        massiv[i]=ramd;
        z=z+massiv[i]+" ";
    }
     
    return z;
}

Console.Write("["+MassivV2(masn,i)+"]");
} 
else
{
   Console.WriteLine("Eror:the elements in the array must be greater than zero  ");
} 
