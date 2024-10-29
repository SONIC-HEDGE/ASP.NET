﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Web_App.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać bo tak!")]
    [MaxLength(length: 20, ErrorMessage = "Co tak dużo znaków??!!")]
    [Display(Name = "Imię")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisać bo tak!")]
    [MaxLength(length: 50, ErrorMessage = "Co tak dużo znaków??!!")]
    [Display(Name = "Nazwisko")]
    public string LastName { get; set; }
    
    [EmailAddress(ErrorMessage = "Zły email!")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Phone(ErrorMessage = "Zły numer telefonu!!")]
    [Display(Name = "Numer telefonu")]
    [RegularExpression("\\d\\d\\d \\d\\d\\d \\d\\d\\d", ErrorMessage = "FORMAT: XXX XXX XXX!!")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Data urodzenia")]
    public DateOnly BirthDate { get; set; }
    
    public CategoryModel Category { get; set; }
}