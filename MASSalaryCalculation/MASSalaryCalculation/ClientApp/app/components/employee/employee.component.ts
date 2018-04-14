import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'employee',
    templateUrl: './employee.component.html',
    styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {

    baseUrl: string;
    http: Http;

    public Employees: Employee[];

    public EmployeeId: string;
    
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
        this.EmployeeId = '';

        this.fetch();
    }

    public fetch() {

        this.Employees = new Array();
        let params = '';

        if (this.EmployeeId != '')
            params = '?Id=' + this.EmployeeId; 

        this.http.get(this.baseUrl + 'api/Employee/GetEmployees' + params).subscribe(result => {
            this.Employees = result.json() as Employee[];
        }, error => console.error(error));
    }
}

interface Employee {
    id : string;
    name: string;
    contractTypeName: string;
    roleId: string;
    roleName: string;
    roleDescription: string;
    hourlySalary: number;
    monthlySalary: number;
    anualSalary: number;
}
