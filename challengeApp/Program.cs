var age = 33;
string name = "EWA";
bool isFemale = true;

if (age < 30 && isFemale == true)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && isFemale == true && name == "EWA")
{
    Console.WriteLine("EWA lat 33");
}
else if (age < 18 && isFemale == false)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{ 
    Console.WriteLine("Kryteria nie zostały spełnione"); 
}