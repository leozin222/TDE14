public class Bicicleta: Veiculo, Iaceleravel
{
    public Bicicleta(string marca, string modelo) :base(marca, modelo)
    {

    }

    public void Acelerar()
    {
        Console.WriteLine($"A {marca} e {modelo} está pedalando mais rapido")
    }

    public override void Ligar()
    {
        Console.WriteLine($"{Marca} e {Modelo} está pronto para uso ")
    }
}