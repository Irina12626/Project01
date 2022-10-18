// **Задача: Написать программу, которая из сформированного массива строк, содержащих символы и числа 
// создаст массив из строк, в который попадут только символы, не являющиеся цифрами**

// *Список задач*

// 1. Составить блок - схему.
// 2. Создать сформированный массив из строк, содержащих символы и числа
// 3. Показать в консоле массив
// 4. Создать массив из строк
// 5. Перебрать полученный массив и сохранить в нем  только символы, которые не являются цифрами.

char[] elements = new char[10];
string alfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
for (int i = 0; i < elements.Length; i++)
{
    int number = new Random().Next(1, 33);
    string number2;
    if (i % 2 == 0)
    {
        number2 = Convert.ToString(alfabet[number]);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
    else
    {
        number = number % 10;
        number2 = Convert.ToString(number);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < elements.Length; i++)
{
    bool mark = elements[i] >= '0' && elements[i] <= '9';
    if (mark == false)
    {
        count++;
    }
}
System.Console.WriteLine();