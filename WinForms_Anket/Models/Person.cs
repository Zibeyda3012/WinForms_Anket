namespace WinForms_Anket.Models;

public class Person
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email {  get; set; }  

    public string PhoneNumber { get; set; }

    public DateTime Birthday { get; set; }

    public Person(string Name,string Surname,String Email,string PhoneNumber,DateTime Birthday)
    {
        this.Name = Name;   
        this.Surname = Surname;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.Birthday = Birthday;
    }

    public override string ToString()
    {
        return $"{Name} {Surname}";
    }

}
