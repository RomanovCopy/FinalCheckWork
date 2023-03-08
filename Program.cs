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
string[] result = new string[n];//результирующий массив
count = 0;//обнуляем счетчик для нового перебора
int res = 0;//счетчик для результирующего массива
while (count < n)//перебираем полученный массив
{
    if (array[count].Length <= 3)//отбираем строки с требуемыми параметрами
    {
        result[res] = array[count];//сохраняем в результирующий массив
        res = res + 1;
    }
    count = count + 1;
}
Console.WriteLine($"Строки длиной меньше или равной 3 символам: \n{string.Join('\n', result)}" );//вывод результата
Console.ReadKey();//удержание консоли

