using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BAL;
using BAL;

namespace talantNexusMVC.Servives
{
    public class Services
    {
        private readonly HttpClient _httpClient;

        public Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:5073/api/Student/");
        }

        public async Task<IEnumerable<Students>> GetAllStudents()
        {
            var response = await _httpClient.GetAsync("GetAllStudent");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<Students>>();
        }

        public async Task<Students> GeStudentsId(int id)
        {
            var response = await _httpClient.GetAsync($"getAllStudentsBYID/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Students>();
        }

        public async Task AddProduct(Students objstudents)
        {
            var response = await _httpClient.PostAsJsonAsync("SetAllStudent", objstudents);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProduct(int id, Students objstudents)
        {
            var response = await _httpClient.PutAsJsonAsync($"updateStudentsByID/{id}", objstudents);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProduct(int id)
        {
            var response = await _httpClient.DeleteAsync($"DeleteStudentsByID/{id}");
            response.EnsureSuccessStatusCode();
        }

    }
}
