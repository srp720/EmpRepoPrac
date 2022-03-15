import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeRoutingModule } from './employee-routing.module';
import { EmployeeComponent } from './employee.component';
import { LeftbarComponent } from './leftbar/leftbar.component';
import { MaincontentComponent } from './maincontent/maincontent.component';
import { EmpscreenComponent } from './empscreen/empscreen.component';

@NgModule({
  imports: [
    CommonModule,
    EmployeeRoutingModule
  ],
  declarations: [EmployeeComponent,
    LeftbarComponent,
    MaincontentComponent,
    EmpscreenComponent]
})
export class EmployeeModule { }
