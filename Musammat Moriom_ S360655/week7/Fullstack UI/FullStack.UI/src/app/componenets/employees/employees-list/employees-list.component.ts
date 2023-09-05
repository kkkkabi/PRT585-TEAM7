import { Component, OnInit } from  '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector:'app-employee-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employees: Employee[] = [
    {
      Id: 'a-001',
      Name: 'john',
      Email:'john@email.com',
      Phone: 123456,
      Salary: 20000,
      Department: 'Human Resources'
    },
    {
      Id: 'a-002',
      Name: 'Sam',
      Email:'Sam@email.com',
      Phone: 234567,
      Salary: 20000,
      Department: 'Information Technology'
    },
    
          {
            Id: 'a-003',
            Name: 'Any',
            Email:'Any@email.com',
            Phone: 2345678,
            Salary: 20000,
            Department: 'Administration'
          },
  ];
  constructor() { }
  
  ngOnInit(): void {

    this.employees.push()
    
  }
}






















