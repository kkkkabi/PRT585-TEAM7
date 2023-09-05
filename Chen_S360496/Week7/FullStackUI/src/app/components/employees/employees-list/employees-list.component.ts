import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {
  
  employees: Employee[] = [

    {
      id: 'a-001',
      name: 'John',
      email: 'john@email.com',
      phone: 1234567,
      salary: 60000,
      department: 'Human Resources'
    },
    {
      id: 'a-002',
      name: 'Sam',
      email: 'Sam@email.com',
      phone: 343467,
      salary: 80000,
      department: 'Information Technology'
    },
    {
      id: 'b-001',
      name: 'Amy',
      email: 'Amy@email.com',
      phone: 367467,
      salary: 50000,
      department: 'Administration'
    }
  
  ]
  constructor() {}
  ngOnInit(): void {
    
  }
}
