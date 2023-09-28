using SokszogOOP;

for (int i = 0; i < 100; i++)
{
    new Haromszog();
}

Haromszog haromszog = new Haromszog();
Haromszog haromszog2 = new Haromszog(3, 4, 5);
Teglalap teglalap = new Teglalap(3, 5);
Teglalap teglalap2 = new Teglalap(4, 2);
Paralelogramma paralelogramma = new Paralelogramma(10,120,5);
Sokszogek sokszogek = new Sokszogek();

Console.WriteLine(haromszog);
Console.WriteLine(haromszog2);
Console.WriteLine(teglalap);
Console.WriteLine(teglalap2);
Console.WriteLine(paralelogramma);
Console.WriteLine("---------------------------------------------");
Console.WriteLine(sokszogek);
Console.WriteLine(sokszogek.osszTerulet());
Console.WriteLine(sokszogek.osszKerulet());
Console.WriteLine(sokszogek.maxTerulet());

Console.WriteLine(haromszog2.A);

try
{
    haromszog2.A = 10;
}
catch (ArgumentException ex) {
    Console.WriteLine(ex.Message);
}
Console.WriteLine(haromszog2.A);