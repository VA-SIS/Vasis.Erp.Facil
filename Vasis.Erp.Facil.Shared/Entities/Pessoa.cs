namespace Vasis.Erp.Facil.Shared.Entities;

public class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string CpfCnpj { get; set; } = string.Empty;

    public string Tipo { get; set; } = "F"; // "F" = Física, "J" = Jurídica

    public string Endereco { get; set; } = string.Empty;

    public string Municipio { get; set; } = string.Empty;

    public string Uf { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;
}
