Console.WriteLine("Задайте массив строк");
Console.WriteLine("Укажите количество элементов массива");
int countMass = 0;
try
{
    countMass = Convert.ToInt32(Console.ReadLine());
}catch(Exception ex) { Console.WriteLine("Введено не число"); }
int count = 0;
String [] array = new String [countMass];
while (count != countMass)
{
    array [count] = Console.ReadLine();
    count++;
}