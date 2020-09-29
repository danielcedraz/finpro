import { Component, Inject } from '@angular/core';
import { UserService } from '../../services/user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { RegisterModel } from '../../model/user/register.model';
import { ErrorModel } from '../../model/error/error.model';
import { StateModel } from '../../model/user/state.model';
import { faCheckCircle } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-user-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class UserRegisterComponent {
  public UserData: RegisterModel;
  private returnUrl: string;
  public phonePattern = "^[0-9]{2} [0-9]{0,1} [0-9]{4}-[0-9]{4}$";
  public maskPhonePattern = [/^[0-9]/, /[0-9]/, ' ', /[0-9]*/, ' ', /[0-9]/, /[0-9]/, /[0-9]/, /[0-9]/, '-', /[0-9]/, /[0-9]/, /[0-9]/, /[0-9]$/];
  public cepPattern = "^[0-9]{2}.[0-9]{3}-[0-9]{3}$";
  public maskCepPattern = [/^[0-9]/, /[0-9]/, '.', /[0-9]/, /[0-9]/, /[0-9]/, '-', /[0-9]/, /[0-9]/, /[0-9]$/];
  public cnpjPattern = "^[0-9]{2}.[0-9]{3}.[0-9]{3}\/[0-9]{4}-[0-9]{2}$";
  public maskCnpjPattern = [/^[0-9]/, /[0-9]/, '.', /[0-9]/, /[0-9]/, /[0-9]/, '.', /[0-9]/, /[0-9]/, /[0-9]/, '/', /[0-9]/, /[0-9]/, /[0-9]/, /[0-9]/, '-', /[0-9]/, /[0-9]$/];
  public cpfPattern = "^[0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2}$";
  public maskCpfPattern = [/^[0-9]/, /[0-9]/, /[0-9]/, '.', /[0-9]/, /[0-9]/, /[0-9]/, '.', /[0-9]/, /[0-9]/, /[0-9]/, '-', /[0-9]/, /[0-9]$/];
  public passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z$*&@#]{8,}$";

  public stateList: Array<StateModel>;
  public checkIcon = faCheckCircle;


  constructor(private router: Router, private activatedRoute: ActivatedRoute, private service: UserService) {
    this.UserData = new RegisterModel();
    this.UserData.addressstate = new StateModel();
    this.returnUrl = activatedRoute.snapshot.queryParams['returnUrl'];

    if (this.returnUrl == null)
      this.returnUrl = "/";

    this.service.stateList()
      .subscribe(
        data => {
          this.stateList = data;
        }
      );
  }

  public passwordIsEqual() {
    return this.UserData.password === this.UserData.passwordconfirm;
  }

  public registrar() {
    this.service.userRegister(this.UserData)
      .subscribe(
        data => {
          console.log(data);
          this.UserData = data;

          if (data.error == null) {

            this.router.navigate(['user-login']);
          }
        },
        err => {
          this.UserData.error = new ErrorModel();
          this.UserData.error.message = "Erro ao cadastrar usuário.";
        }
      );
  }
}
