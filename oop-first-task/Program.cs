using oop_first_task;

//Console.Write("Nece kitab daxil olunacaq : ");
//int cout = int.Parse(Console.ReadLine());
//Book[] books = new Book[cout];



//for (int i = 0; i < cout; i++)
//{
//    Console.Write($"{i+1}.Kitabin adi : ");
//    string name = Console.ReadLine();
//    Console.Write($"{i + 1}.sehife sayi : ");
//    int countPage = int.Parse(Console.ReadLine());
//    books[i] = new Book(name , countPage);
//}
Student student1 = new() { Name = "Ali" , Surname = "Aliyev" };
Student student2 = new() { Name = "Ferhad" , Surname = "Xidirli" };
Student student3 = new() { Name = "Nicat" , Surname = "Huseynli" };
Student student4 = new() { Name = "Elvin" , Surname = "Zeynizade" };
Student student5 = new() { Name = "Rufet" , Surname = "Esgerov" };

Group group1 = new() {
    GroupName = "az-123",
    Limit = 3,
    GroupMembers = new[]
    {
        student1,student2,student3,student4,student5
    }
};


group1.GetStudents();




