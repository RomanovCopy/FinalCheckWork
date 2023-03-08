Console.Write( "Каково колличество вводимых строк? : " );
int n = Convert.ToInt32( Console.ReadLine() );//колличество строк в массиве
string[] array = new string[n];
int count = 0;
while(count < n)//ввод строк и занесение их в массив
{
    Console.Clear();
    Console.WriteLine( $"Ввод строки {count + 1} из {n}" );
    array[count] = Console.ReadLine();
    count = count + 1;
}
string[] result = new string[n];
count = 0;
int res = 0;
while (count < n)
{
    if (array[count].Length <= 3)
    {
        result[res] = array[count];
        res = res + 1;
    }
    count = count + 1;
}
Console.WriteLine($"Строки длиной меньше или равной 3 символам: \n{string.Join('\n', result)}" );
Console.ReadKey();

