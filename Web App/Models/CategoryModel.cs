using System.ComponentModel.DataAnnotations;

namespace Web_App.Models;

public enum CategoryModel
{
    [Display(Name = "Rodzina")]
    Family = 1,
    [Display (Name = "Znajoimi")]
    Friend = 2,
    [Display (Name = "Zawodowy")]
    Business = 3
}