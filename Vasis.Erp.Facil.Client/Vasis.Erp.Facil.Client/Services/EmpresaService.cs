using Vasis.Erp.Facil.Shared.Entities;
using System.Net.Http.Json;

//namespace Vasis.Erp.Facil.Client.Services
//{
//    public class EmpresaService
//    {
//    }
//}

//using Vasis.Erp.Facil.Shared.Entities;

namespace Vasis.Erp.Facil.Server.Services;

public class EmpresaService
{
    private readonly HttpClient _http;

    public EmpresaService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Empresa>> GetAllAsync() =>
        await _http.GetFromJsonAsync<List<Empresa>>("api/Empresas") ?? new();

    public async Task<Empresa?> GetByIdAsync(int id) =>
        await _http.GetFromJsonAsync<Empresa?>($"api/Empresas/{id}");

    public async Task<bool> CreateAsync(Empresa empresa)
    {
        var response = await _http.PostAsJsonAsync("api/Empresas", empresa);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(Empresa empresa)
    {
        var response = await _http.PutAsJsonAsync($"api/Empresas/{empresa.Id}", empresa);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/Empresas/{id}");
        return response.IsSuccessStatusCode;
    }
}

