import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeComponent } from './employee.component';
import { EmpscreenComponent} from './empscreen/empscreen.component';

const routes: Routes = [
  {
  path: 'emp', component: EmployeeComponent,
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  providers: []
})
export class EmployeeRoutingModule { }