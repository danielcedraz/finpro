import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class GuardRoute implements CanActivate {
  constructor(private router: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var token = sessionStorage.getItem("token");
    var authorized = (token != "" && token != undefined && token != null);

    if (authorized)
      return true;

    this.router.navigate(['/user-login'], { queryParams: { returnUrl: state.url } });

    return false;
  }
}
