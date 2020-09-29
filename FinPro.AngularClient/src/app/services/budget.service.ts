import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BudgetModel } from '../model/budget/budget.model';

@Injectable({
  providedIn: "root"
})

export class BudgetService {
  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public findBudget(Budget: BudgetModel): Observable<BudgetModel> {
    var token = sessionStorage.getItem("token");
    const headers = new HttpHeaders().set('content-type', 'application/json').set('Authorization', 'Bearer ' + token);
    return this.http.post<BudgetModel>(this.baseURL + 'api/Budget/Find', Budget, { headers });
  }

  public budgetRegister(BudgetData: BudgetModel): Observable<BudgetModel> {
    var token = sessionStorage.getItem("token");
    const headers = new HttpHeaders().set('content-type', 'application/json').set('Authorization', 'Bearer ' + token);
    return this.http.post<BudgetModel>(this.baseURL + 'api/Budget/Register', BudgetData, { headers });
  }

  public budgetList(): Observable<BudgetModel[]> {
    var token = sessionStorage.getItem("token");
    var headers = new HttpHeaders().set('content-type', 'application/json').set('Authorization', 'Bearer ' + token);
    console.log(token);

    return this.http.post<BudgetModel[]>(this.baseURL + 'api/Budget/List', { headers });
  }
}
