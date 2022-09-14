Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] inarray = new string[size];
for (int i = 0; i < inarray.Length; i++)// цикл для введение данных
{
    Console.WriteLine("Введите символы: ");
    inarray[i] = Convert.ToString(Console.ReadLine());
}

int a = 3; // сколько должно быть сиволов
int b = 0; // длина нового массива
CreateNewArray(inarray, a, b);// метод для проверки и создания массива

void CreateNewArray(string[] array, int a, int b) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= a)
        {
            b++;
        }
    }
    if (b == 0) Console.WriteLine("В заданом массиве всё больше 3 символов");
    else
    {
        string[] str = new string[b];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= a)
            {
                str[j] = array[i];
                Console.Write($"{str[j]}, ");
                j++;
            }
        }
    }

}

