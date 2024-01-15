//Задача1
int Ms = 13015126;
int St = 5598486;
Console.WriteLine($"В Питере {St} жителей.");
Console.WriteLine($"В Москве {Ms} жителей.");
int res = Ms - St;
Console.WriteLine($"В Москве на {res} жителей больше.");
//Задача2
double year = 260548.56895;
Console.WriteLine($"Зарплата за год - {year}.");
double month =(double) year / 12;
Console.WriteLine($"Зарплата за месяц - {month}.");
double ndfl = 13;
double monthndfl=System.Math.Round((double)(month * ndfl / 100));
Console.WriteLine($"Зарплата за месяц, за вычетом налогов - {monthndfl}.");