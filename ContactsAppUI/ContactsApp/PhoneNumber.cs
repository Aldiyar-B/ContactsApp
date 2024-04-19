using System.ComponentModel.DataAnnotations;

/// <summary>
/// Класс номера телефона.
/// </summary>
public class PhoneNumber
{
    /// <summary>
    /// Поле номера телефона.
    /// </summary>
    private string _number;

    /// <summary>
    /// Конструктор без параметров
    /// </summary>
    public PhoneNumber()
    {

    }

    /// <summary>
    /// Конструктор с параметрами.
    /// </summary>
    /// <param name="number"> Номер телефона. </param>
    public PhoneNumber(string number)
    {
        Number = number;
    }

    /// <summary>
    /// Возвращает и задаёт номер телефона.
    /// </summary>
    public string Number
    {
        get
        {
            return _number;
        }
        set
        {
            Validator.CheckNumber(value);
            _number = value;
        }
    }
}