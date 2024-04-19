using Newtonsoft.Json;

/// <summary>
/// Класс сериализатор.
/// </summary>
public static class Serializer
{

    /// <summary>
    /// Метод сохранения данных в файл.
    /// </summary>
    /// <param name="data"> Список контактов. </param>
    /// <param name="filename"> Путь до файла.</param>
    public static void SaveToFile(List<Contact> data, string filename)
    {
        var serialized = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filename, serialized);
    }

    /// <summary>
    /// Метод десериализации.
    /// </summary>
    /// <param name="filename"> Путь до файла. </param>
    /// <returns> Возвращает список контактов. </returns>
    public static List<Contact> LoadFromFile(string filename)
    {
        var data = new List<Contact>();
        if (File.Exists(filename))
        {
            var jsonData = File.ReadAllText(filename);
            data = JsonConvert.DeserializeObject<List<Contact>>(jsonData);
        }
        return data;
    }
}