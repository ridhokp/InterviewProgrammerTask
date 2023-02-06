using InterviewProgrammerTask.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgrammerTask.Data
{
    public class EmployeeService
    {
        //Seed data entity Employee di memory  
        IList<Employee> employees = new List<Employee> {
            new Employee() { 
                EmployeeId = "1001", 
                FullName = "Adit", 
                BirthDate= new DateOnly(1954,8,17) },
            new Employee() { 
                EmployeeId = "1002", 
                FullName = "Anton", 
                BirthDate= new DateOnly(1954,8,18) },
            new Employee() { 
                EmployeeId = "1003", 
                FullName = "Amir", 
                BirthDate= new DateOnly(1954,8,19) }
        };

        //Method Tampil Data Employee di memory
        public async Task GetEmployee()
        {
            Console.WriteLine("==================================================================================================================");
            //looping untuk menampilkan data setiap data Employee pada list memory
            foreach (Employee employee in employees)
            {
                Console.WriteLine(string.Format("EmployeeID = {0}, FullName = {1}, BirthDate = {2}", employee.EmployeeId, employee.FullName, employee.BirthDate));
            }
            Console.WriteLine("==================================================================================================================");
        }

        //Method tambah data employee baru ke list memory
        public async Task AddEmployee(Employee emp)
        {
            //menambah data Employee dari velue parameter 
            employees.Add(new Employee() { EmployeeId = emp.EmployeeId, FullName = emp.FullName, BirthDate = emp.BirthDate });
            //tampilkan list data terbaru
            await GetEmployee();
        }


        //Method tambah data employee baru ke list memory
        public async Task EditEmployee(Employee emp)
        {
            //cari data employee yang akan diedit berdasarkan EmployeeId
            var existEmp = employees.FirstOrDefault(e => e.EmployeeId == emp.EmployeeId);
            //jika employee yang di cari ada
            if (existEmp != null)
            {
                //menambah data Employee dari velue parameter 
                existEmp.FullName = emp.FullName;
                existEmp.BirthDate = emp.BirthDate;
            }
            //tampilkan list data terbaru
            await GetEmployee();
        }


        //Method tambah data employee baru ke list memory
        public async Task DeleteEmployee(string EmpID)
        {
            //cari data employee yang akan diedit berdasarkan EmployeeId
            var existEmp = employees.FirstOrDefault(e => e.EmployeeId == EmpID);
            //jika employee yang di cari ada
            if (existEmp != null)
            {
                //hapus data employee yang ditemukan
                employees.Remove(existEmp);
            }
            //tampilkan list data terbaru
            await GetEmployee();
        }

        //method ekseskusi perintah key
        public async Task Command()
        {
            //tampilkan list data terbaru
            await GetEmployee();

            //variable string perintah
            string cmd;
            Console.Write("Perintah 0 tambah data default, 1 tambah data entri, 2 edit data, 3 hapus data : ");

            //membaca input perintah
            cmd = Console.ReadLine();

            //jika perintah 0
            if (cmd == "0")
            {
                //hardcode value
                var emp = new Employee();
                emp.EmployeeId = "1010";
                emp.FullName = "Ridho";
                emp.BirthDate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                //panggil method tambah data employee dengan mengirim parameter value entity set value default
                await AddEmployee(emp);
            }

            //jika perintah 1
            else if (cmd == "1")
            {
                //value input 
                var emp = new Employee();
                Console.Write("EmploryeId : ");
                emp.EmployeeId = Console.ReadLine();
                Console.Write("Full Name : ");
                emp.FullName = Console.ReadLine();
                Console.Write("Birth Day : ");
                emp.BirthDate = DateOnly.Parse(Console.ReadLine());

                //panggil method tambah data employee dengan mengirim parameter value entity set value input keyboard
                await AddEmployee(emp);
            }

            //jika perintah 2
            else if (cmd == "2")
            {
                //value input 
                var emp = new Employee();
                Console.Write("EmploryeId : ");
                emp.EmployeeId = Console.ReadLine();
                Console.Write("Full Name : ");
                emp.FullName = Console.ReadLine();
                Console.Write("Birth Day : ");
                emp.BirthDate = DateOnly.Parse(Console.ReadLine());

                //panggil method edit data employee dengan mengirim parameter value entity set value
                await EditEmployee(emp);
            }

            //jika perintah 3
            else if (cmd == "3")
            {
                //variable string
                string EmpId;
                //value input EmployeeId
                Console.Write("EmploryeId : ");
                EmpId = Console.ReadLine();

                //panggil method hapus data employee dengan mengirim parameter value string
                await DeleteEmployee(EmpId);
            }
        }
    }
}
