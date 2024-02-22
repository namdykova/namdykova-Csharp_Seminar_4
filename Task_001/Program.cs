RequestSumEven();
    
void RequestSumEven()
{
    Console.WriteLine("Введите число или q для выхода: ");
    while (true)
    {
        string input = Console.ReadLine();
        if (input == "q")
        {
            Console.WriteLine("Выход");
            break;
        }
        int number;
        if (int.TryParse(input, out number))
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("Сумма цифр делится на 2");
                break;
            }
            else
            {
                Console.WriteLine("Сумма цифр не делится на 2. Введите другое число или 'q' для выхода");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите целое число или 'q': ");
        }
    }
}