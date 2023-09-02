using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    //primary key
    //The question mark after string indicates that the property is nullable
    public int Id { get; set; } 
	public string? Title { get; set; }

    //The user isn't required to enter time information in the date field.
    //Only the date is displayed, not time information.
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Type")]
	public string? Genre { get; set; }
    [Column(TypeName = "decimal (18,2)")]
	public decimal Price { get; set; }
}