public class Carro : Veiculo, Ifreavel, Iaceleravel
{
    public string Marca{get; set;}

    public string Modelo{get; set;}

    public Carro(string marca, string modelo)
    {
       
    }

    public override void Ligar()
    {
        Console.WriteLine("O carro está ligado!")
    }

    public void Acelerar()
    {
        Console.WriteLine($"O carro {Marca}, {modelo} está acelerando")

    }
        public void Frear()
    {
        Console.WriteLine($"O carro {Marca}, {modelo} está freiando")

    }

    
}

