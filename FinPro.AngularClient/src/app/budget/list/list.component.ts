import { Component, Inject } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { BudgetService } from '../../services/budget.service';
import { ErrorModel } from '../../model/error/error.model';
import { BudgetModel } from '../../model/budget/budget.model';

@Component({
  selector: 'app-badget-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})

export class BudgetListComponent {
  public BudgetList: BudgetModel[];
  private returnUrl: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute, private service: BudgetService) {
    this.returnUrl = activatedRoute.snapshot.queryParams['returnUrl'];

    if (this.returnUrl == null)
      this.returnUrl = "/";

    this.service.budgetList()
      .subscribe(
        data => {
          console.log(data);
          this.BudgetList = data;
        }
      );
  }

  public registrar() {
    
  }
}
