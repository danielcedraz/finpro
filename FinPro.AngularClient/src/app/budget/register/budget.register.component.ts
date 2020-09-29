import { Component, Inject } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { BudgetService } from '../../services/budget.service';
import { ErrorModel } from '../../model/error/error.model';
import { BudgetModel } from '../../model/budget/budget.model';

@Component({
  selector: 'app-user-register',
  templateUrl: './budget.register.component.html',
  styleUrls: ['./budget.register.component.css']
})

export class BudgetRegisterComponent {
  public BudgetData: BudgetModel;
  private returnUrl: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute, private service: BudgetService) {
    this.BudgetData = new BudgetModel();
    this.returnUrl = activatedRoute.snapshot.queryParams['returnUrl'];

    if (this.returnUrl == null)
      this.returnUrl = "/";
  }

  public registrar() {
    this.service.budgetRegister(this.BudgetData)
      .subscribe(
        data => {
          console.log(data);
          this.BudgetData = data;

          if (data.error == null) {

            this.router.navigate(['user-login']);
          }
        },
        err => {
          this.BudgetData.error = new ErrorModel();
          this.BudgetData.error.message = "Erro ao cadastrar usuário.";
        }
      );
  }
}
