Console.Write ("Введите имя пользователя ");
string username = Console.ReadLine ();

if(username.ToLower () == "маша")

{ 
    Console.WriteLine ("Ура, это же Маша!");
}

else

{
    Console.WriteLine ("Не, ты не Маша");
    Console.Write ("Привет ");
    Console.WriteLine (username);
}