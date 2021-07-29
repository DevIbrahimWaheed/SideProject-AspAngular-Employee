import { Injectable } from '@angular/core';
import { EmployeeDetail } from './employee-detail.model';
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EmployeeDetailService {

  tableData : EmployeeDetail = new EmployeeDetail();

  constructor() { }
}
