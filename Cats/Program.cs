// See https://aka.ms/new-console-template for more information
using Cats;

Console.WriteLine("Hello, World!");

Cat cat = new Cat("CutiePie", "brown", 6, 9);//We used constructor to create cat object and we filled in the property values. We created class cats. Use camelCase
Console.WriteLine("My name is " + cat.Name); //How we access the property.
                                             //


Parrot myParrot = new Parrot("Tweet");
Console.WriteLine(myParrot.Name);

if (myParrot.Hunger)
{
    Console.WriteLine("I am hungry");
    myParrot.FeedMe();
}
else
{
    Console.WriteLine("I am not hungry");
}
Console.WriteLine(myParrot.Hunger);