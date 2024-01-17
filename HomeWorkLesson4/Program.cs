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
double month =year / 12;
Console.WriteLine($"Зарплата за месяц - {month:F2}.");
double monthndfl = month - (month * 0.13);
Console.WriteLine($"Зарплата за месяц, за вычетом налогов - {monthndfl:F2}.");