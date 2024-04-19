using System.ComponentModel.DataAnnotations;

/// <summary>
/// Класс контакта.
/// </summary>
public class Contact
{
    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    private string _surname;

    /// <summary>
    /// Эл.почта контакта.
    /// </summary>
    private string _email;

    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string _name;

    /// <summary>
    /// ID vk контакта.
    /// </summary>
    private string _vkID;

    /// <summary>
    /// День рождения контакта.
    /// </summary>
    private DateTime _birthday;

    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    private PhoneNumber _phone;

    /// <summary>
    /// Конструктор без параметров.
    /// </summary>
    public Contact()
    {
        Phone = new PhoneNumber();
    }

    public string PhoneNumber { get; set; }

    /// <summary>
    /// Конструктор с параметрами.
    /// </summary>
    /// <param name="surname"> Фамилия.</param>
    /// <param name="name"> Имя. </param>
    /// <param name="email"> Эл.почта. </param>
    /// <param name="vkId"> vkID. </param>
    /// <param name="birthday"> День рождения. </param>
    /// <param name="phone"> Номер телефона. </param>
    public Contact(
  string surname,
  string name,
  string email,
  string vkId,
  DateTime birthday,
  string phone)
    {
        Surname = surname;
        Name = name;
        Email = email;
        VkID = vkId;
        Birthday = birthday;
        Phone = new PhoneNumber(phone);
    }

    /// <summary>
    /// Возвращает и задает фамилию контакта.
    /// </summary>
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            Validator.CheckMaxLength(value, 50);
            _surname = value;
        }
    }

    /// <summary>
    /// Возвращает и задает эл.почту контакта.
    /// </summary>
    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            Validator.CheckMaxLength(value, 50);
            _email = value;
        }
    }

    /// <summary>
    /// Возвращает и задает имя контакта.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            Validator.CheckMaxLength(value, 50);
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер контакта.
    /// </summary>
    public PhoneNumber Phone
    {
        get
        {
            return _phone;
        }
        set
        {
            _phone = value;
        }
    }

    /// <summary>
    /// Возвращает и задает vkID контакта.
    /// </summary>
    public string VkID
    {
        get
        {
            return _vkID;
        }
        set
        {
            Validator.CheckMaxLength(value, 15);
            _vkID = value;
        }
    }

    /// <summary>
    /// Возвращает и задает день рождение контакта.
    /// </summary>
    public DateTime Birthday
    {
        get
        {
            return _birthday;
        }
        set
        {
            Validator.CheckBirthday(value);
            _birthday = value;
        }
    }
}