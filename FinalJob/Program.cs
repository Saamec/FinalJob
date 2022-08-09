Console.WriteLine("Задайте массив строк");
Console.WriteLine("Укажите количество элементов массива");
int countMass = 0;
try
{
    countMass = Convert.ToInt32(Console.ReadLine());
}catch(Exception ex) { Console.WriteLine("Введено не число"); }
int count = 0;
String [] array = new String [countMass];
Console.WriteLine("Вводите строки массива через ENTER");
while (count != countMass)
{
    array [count] = Console.ReadLine();
    count++;
}
//foreach (String s in array)Console.WriteLine(s);

void FinderFreeSimvols (String [] value)
{
    int count = 0;
    for (int i = 0; i < value.Length; i++)
    {
        if (value [i].Length <= 3)
        {
            count++;
        }
    }
    String [] array = new String [count];
    int temp = 0;
    for (int i = 0; i < value.Length; i++)
    {
        if(value [i].Length <= 3)
        {
            array[temp] = value [i];
            temp++;
        }
    }
    if (array.Length > 0) Console.WriteLine("[\"" + String.Join("\", \"", array) + "\"]");
    else Console.WriteLine("[]");
}
FinderFreeSimvols(array);