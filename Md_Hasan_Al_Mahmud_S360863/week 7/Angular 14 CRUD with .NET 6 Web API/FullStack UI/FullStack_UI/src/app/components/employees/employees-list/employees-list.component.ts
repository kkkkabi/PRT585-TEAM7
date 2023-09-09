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
      id: 'S360863',
      name: 'mahmud',
      email: 'ham2k7@email.com',
      phone: 123456789,
      salary: 60000,
      department:'Information Technology'
    },
    {
      id: 'S360123',
      name: 'kabi',
      email: 'kabi@email.com',
      phone: 987654321,
      salary: 60000,
      department:'Human Resource'
    },
    {
      id: 'S360987',
      name: 'Chen',
      email: 'Chen@email.com',
      phone: 23456789,
      salary: 65000,
      department:'Information Technology'
    },
  ];

constructor(){}

ngOnInit(): void {
  
}
}

