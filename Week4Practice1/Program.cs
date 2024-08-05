using Week4Practice1;

internal class Program
{
    public static void Main(string[] args)
    {
        Person teacher1 = new Person();                                     //1. öğretmen için nesneyi oluşturdum ve propert lerine atama yaptım
        teacher1.Name = "Merve";
        teacher1.LastName = "Akkoyunlu";
        teacher1.DateofBirth = new DateTime(1996,08,30);

        Person teacher2 = new Person();
        teacher2.Name = "Emirhan";
        teacher2.LastName = "Akkoyunlu";
        teacher2.DateofBirth = new DateTime(1997, 01, 27);

        Person student1 = new Person();
        student1.Name = "Gökçe";
        student1.LastName = "Akkoyunlu";
        student1.DateofBirth = new DateTime(2026, 08, 30);

        Person student2 = new Person();
        student2.Name = "Ali";
        student2.LastName = "Akkoyunlu";
        student2.DateofBirth = new DateTime(2028, 08, 30);


        teacher1.InfoPerson();
        teacher2.InfoPerson();

        student1.InfoPerson();
        student2.InfoPerson();
    }
}