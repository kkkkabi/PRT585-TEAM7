import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Environment } from 'src/environment/environment';
import { Employee } from '../models/employee.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseApiUrl: string = Environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllEmployees(): Observable<Employee []>{
    return this.http.get<Employee[]>(this.baseApiUrl + '/api/employees')

  }
}