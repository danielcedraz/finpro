import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {
    sessionStorage.removeItem("token");
    this.router.navigate(["/"]);
  }

  userLogged() {
    var token = sessionStorage.getItem("token");

    return (token != "" && token != undefined && token != null);
  }
}
