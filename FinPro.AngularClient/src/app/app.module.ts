import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './user/login/login.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { UserService } from './services/user.service';
import { GuardRoute } from './authorization/guard.route';
import { UserRegisterComponent } from './user/register/register.component';
import { TextMaskModule } from 'angular2-text-mask';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { BudgetService } from './services/budget.service';
import { BudgetRegisterComponent } from './budget/register/budget.register.component';
import { BudgetListComponent } from './budget/list/list.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    UserRegisterComponent,
    NavMenuComponent,
    HomeComponent,
    FetchDataComponent,
    BudgetRegisterComponent,
    BudgetListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    TextMaskModule,
    FontAwesomeModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [GuardRoute] },
      { path: 'user-login', component: LoginComponent },
      { path: 'user-register', component: UserRegisterComponent },
      { path: 'budget-register', component: BudgetRegisterComponent, canActivate: [GuardRoute] },
      { path: 'budget-list', component: BudgetListComponent, canActivate: [GuardRoute] }
    ])
  ],
  providers: [UserService, BudgetService],
  bootstrap: [AppComponent]
})
export class AppModule { }
