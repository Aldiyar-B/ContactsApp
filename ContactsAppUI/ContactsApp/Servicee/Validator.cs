/// <summary>
/// Класс валидации
/// </summary>
public static class Validator
{

    /// <summary>
    /// Проверяет поле на максимальную длину.
    /// </summary>
    /// <param name="word"> Переданное слово. </param>
    /// <param name="length"> Максимальная длина. </param>
    /// <exception cref="ArgumentException"></exception>
    public static void CheckMaxLength(string word, int length)
    {
        if (word.Length > length)
        {
            throw new ArgumentException("Превысило максимальную длину поля.");
        }
    }

    /// <summary>
    /// Проверяет дату на существующую.
    /// </summary>
    /// <param name="date"> Переданная дата. </param>
    /// <exception cref="ArgumentException"></exception>
    public static void CheckBirthday(DateTime date)
    {
        if (date > DateTime.Now || date.Year < 1900)
        {
            throw new ArgumentException("Вряд ли такой есть.");
        }
    }

    /// <summary>
    /// Проверяет номер телефона на соответствие нормам.
    /// </summary>
    /// <param name="number"> Переданный номер. </param>
    /// <exception cref="ArgumentException"></exception>
    public static void CheckNumber(string number)
    {
        if (number.Length != 11 || number[0] != '7' || HasOtherSymbols(number))
        {
            throw   new ArgumentException();
        }
    }

    /// <summary>
    /// Проверяет, что строка состоит только из цифр.
    /// </summary>
    /// <param name="str"> Строка. </param>
    /// <returns> Возвращает true, если состоит не только из цифр, иначе false. </returns>
    private static bool HasOtherSymbols(string str)
    {
        foreach (var symbol in str)
        {
            if (symbol < '0' || symbol > '9')
            {
                return true;
            }
        }
        return false;
    }
}