using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Studentstable
{
    [System.ComponentModel.DataAnnotations.Key]
    public int StudetId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Mark { get; set; }

    public Studentstable(string text)
    { }
    public Studentstable(string firstname, string lastname, int mark)
    {
        FirstName = firstname;
        LastName = lastname;
        Mark = mark;
    }
}
