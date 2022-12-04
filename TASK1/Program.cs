Console.WriteLine("Пожалуйста, введите число1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool Answer = true;
if(number1*number1 == number2)
{
Answer = true; 
} 
else 
{
    Answer = false;
}

Console.WriteLine(Answer);git




// /*Console.Write("Введите имя пользователя ");
// string username = Console.ReadLine();
// if(username.ToLower() == "дина")
// {
//     Console.WriteLine("Ура, это же Дина!!");
// }
// else
// {
// Console.Write("Привет, ");
// Console.Write(username);
// }


