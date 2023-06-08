using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using employeTracker.Models;

namespace employeTracker.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();

        // GET: api/employee
        [HttpGet("list")]
        public IActionResult Get()
        {
            return Ok(employees); // 200 OK durum kodu ile çalışanları döndürür
        }

        // GET: api/employee/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id); // Belirli bir çalışanı id'ye göre arar
            if (employee == null)
            {
                return NotFound(); // 404 Not Found durum kodu döndürür
            }
            return Ok(employee); // 200 OK durum kodu ile çalışanı döndürür
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 Bad Request durum kodu ile geçersiz model durumunu döndürür
            }

            employees.Add(employee); // Çalışanı listeye ekler
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee); // 201 Created durum kodu ile yeni çalışanın URI'sini ve çalışanı döndürür
        }

        // PUT: api/employee/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 Bad Request durum kodu ile geçersiz model durumunu döndürür
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id); // Belirli bir çalışanı id'ye göre bulur
            if (existingEmployee == null)
            {
                return NotFound(); // 404 Not Found durum kodu döndürür
            }

            // Var olan çalışanın bilgilerini günceller
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Address = employee.Address;
            existingEmployee.City = employee.City;
            existingEmployee.Age = employee.Age;
            existingEmployee.Department = employee.Department;
            existingEmployee.PhoneNumber = employee.PhoneNumber;
            existingEmployee.BirthDate = employee.BirthDate;

            return NoContent(); // 204 No Content durum kodu döndürür
        }

        // DELETE: api/employee/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id); // Belirli bir çalışanı id'ye göre bulur
            if (employee == null)
            {
                return NotFound(); // 404 Not Found durum kodu döndürür
            }

            employees.Remove(employee); // Çalışanı listeden kaldırır
            return NoContent(); // 204 No Content durum kodu döndürür
        }

        // PATCH: api/employee/{id}
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<Employee> patchDocument)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id); // Belirli bir çalışanı id'ye göre bulur
            if (employee == null)
            {
                return NotFound(); // 404 Not Found durum kodu döndürür
            }

            patchDocument.ApplyTo(employee); // JsonPatchDocument'ı kullanarak çalışana yamaları uygular
            return NoContent(); // 204 No Content durum kodu döndürür
        }
    }
}
