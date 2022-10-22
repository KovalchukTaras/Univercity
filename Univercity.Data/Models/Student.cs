using System.ComponentModel.DataAnnotations.Schema;

namespace Univercity.Data.Models;

public class Student
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GroupId { get; set; }
}