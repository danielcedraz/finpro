import { Component, Inject } from '@angular/core';
import { UserService } from '../../services/user.service';
import { UserModel } from '../../model/user/user.model';
import { Router, ActivatedRoute } from '@angular/router';
import { ErrorModel } from '../../model/error/error.model';

@Component({
  selector: 'app-user-login',
  templateUrl: './login.component.html',
})

export class LoginComponent {
  public User: UserModel;
  private returnUrl: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute, private service: UserService) {
    this.User = new UserModel();
    this.returnUrl = activatedRoute.snapshot.queryParams['returnUrl'];

    if (this.returnUrl == null)
      this.returnUrl = "/";
  }

  public login() {
    if (this.User.email && this.User.password)
      this.service.userLogin(this.User)
        .subscribe(
          data => {
            this.User = data;

            if (data.error == null) {
              sessionStorage.setItem("token", data.token);
              this.router.navigate([this.returnUrl]);
            }
          },
          err => {
            this.User.error = new ErrorModel();
            this.User.error.message = "Erro ao fazer login.";
          }
        );
    else {
      this.User.error = new ErrorModel();
      this.User.error.message = "Preencha os campos abaixo."
    }
  }
}
