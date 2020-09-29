import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserModel } from '../model/user/user.model';
import { RegisterModel } from '../model/user/register.model';
import { StateModel } from '../model/user/state.model';

@Injectable({
  providedIn: "root"
})

export class UserService {
  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public userLogin(User: UserModel): Observable<UserModel> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    return this.http.post<UserModel>(this.baseURL + 'api/Login/Authenticate', User, { headers });
  }

  public userRegister(UserData: RegisterModel): Observable<RegisterModel> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    return this.http.post<RegisterModel>(this.baseURL + 'api/Login/Register', UserData, { headers });
  }

  public stateList(): Observable<StateModel[]> {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    return this.http.post<StateModel[]>(this.baseURL + 'api/Login/StateList', { headers });
  }
}
