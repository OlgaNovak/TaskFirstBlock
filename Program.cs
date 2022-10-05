// Итоговая проверочная работа

Console.Clear();
Console.WriteLine("Заполните строкy через запятую:");
string A=Console.ReadLine();
string []rows=A.Split(",");
int N=3;
Console.WriteLine($"Cтроки массива, длина которых меньше или равна трем символам:");
for(int i=0; i<rows.Length;i++){
    if (rows[i].Length<=N)
    Console.Write(rows[i]+" ,");
}
Console.ReadLine();