namespace Web_App.Models;

public class Birth
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public bool isValid() => Name != null && Name != String.Empty;
    public int Years => (int)(DateTime.Now - Date).TotalDays / 365;
}