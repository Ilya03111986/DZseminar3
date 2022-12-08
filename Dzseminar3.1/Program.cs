//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine(" Введите пятизначное число ");
string  n_str = Console.ReadLine();
int str = Convert.ToInt32(n_str);
    if ( str >= 10000 & str <= 99999);
    else
        {Console.WriteLine("только положительные пятизначные числа");
        return;  }
    
    if (n_str[0] == n_str[4] && n_str[1] == n_str[3])
    
     Console.Write("да");  
    else
    
     Console.Write("нет");
    

