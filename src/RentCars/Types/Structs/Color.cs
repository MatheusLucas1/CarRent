namespace RentCars.Types;

//1 - Crie uma `Struct` para as **Cores**
public struct Color
{
    public String Name { get; set; }
    public String Hex { get; set; }

    public Color(String name, String hex)
    {
        Name = name;
        Hex = hex;
    }
}