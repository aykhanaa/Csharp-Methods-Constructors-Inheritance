


using Csharp_Methods_Constructors_Inheritance;
using System;

//Person person = new Person()
//{
//    id = 1,
//    FullName = "Fatime Qayxanova",
//    age = 22,
//    position = "Student"
//};

//Person person = new Person(1, "Hacixan Hacixanov", 19, "Student");

//Console.WriteLine(person.FullName);

//Person person = new Person("Azerbaycan","Turkiye");



 
Person[] GetAllPerson() 
{
    Person person1 = new()
    {
        id = 1,
        FullName = "Ilqar Siriyev",
        age = 26,
    };

    Person person2 = new()
    {
        id = 2,
        FullName = "Resad Agayev",
        age = 21,
    };

    Person person3 = new()
    {
        id = 3,
        FullName = "Nurlan Umudov",
        age = 22,
    };

    Person person4 = new()
    {
        id = 4,
        FullName = "Elmir Qafarzade",
        age = 21,
    };

    Person[] people = { person1, person2, person3, person4 };

    return people;
}

void ShowAllPeople(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id:{item.id} Fullname:{item.FullName} Age:{item.age}";
        Console.WriteLine(response);
    }
}

//var result = GetAllPerson();
//ShowAllPeople(GetAllPerson());
    
Person FindPersonById(Person[]people,int id)
{
    return people.FirstOrDefault(m => m.id == id);
}

//var AllPeople = GetAllPerson(people);

//var result1 = result != null ? $"Id:{result.id} Fullname:{result.FullName} Age:{result.age}" : "Not found";

//Console.WriteLine(result1);

 void ShowPerson(Person person)
{

    if (person != null)
    {

        string response = $"Id:{person.id} Fullname:{person.FullName} Age:{person.age}";

        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data notfound");
    }
}

//ShowPerson(FindPersonById(GetAllPerson(), 1));



Person[] GetPeopleBYName(Person [] people ,string name)
{
    return people.Where(m=>m.FullName==name).ToArray();
}

void ShowPeopleByName(Person[] datas)
{
    foreach (var item in datas)
    {
        string response = $"Id:{item.id} Fullname:{item.FullName} Age:{item.age}";
        Console.WriteLine(response);
    }
}

//ShowPeopleByName(GetPeopleBYName(GetAllPerson(), "Behruz"));



//Animal animal = new Animal();

//animal.id = 5;
//animal.name = "Qartal";

//Console.WriteLine(animal.name);

//Bird bird = new Bird()
//{
//    id = 5,
//    name = "Qaranqush",
//    age = 10,
//};

//Console.WriteLine(bird.name);

//bird.Sound();

//Fish fish = new();

//Animal animal = new("salam");
