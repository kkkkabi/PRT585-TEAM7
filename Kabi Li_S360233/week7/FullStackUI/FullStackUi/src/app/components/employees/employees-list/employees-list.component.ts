import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit{

  employees: Employee[]=[
    {
      id: 'S360233',
      name: 'Kabi',
      email: 'kabi@email.com',
      phone: 7812123456,
      salary: 6000,
      department:'Information Technology'
    },
    {
      id: 'S360123',
      name: 'John',
      email: 'John@email.com',
      phone: 74623456,
      salary: 6000,
      department:'Human Resource'
    },
    {
      id: 'S360496',
      name: 'Chen',
      email: 'Cheni@email.com',
      phone: 758881258,
      salary: 10000,
      department:'Information Technology'
    },
  ];

constructor(){}

ngOnInit(): void {
  
}
}

