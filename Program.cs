// See https://aka.ms/new-console-template for more information
using InterviewProgrammerTask.Data;
using System.Linq.Expressions;

var Employee = new EmployeeService();
await Employee.Command();
Console.ReadLine();