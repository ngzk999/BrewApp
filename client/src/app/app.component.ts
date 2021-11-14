import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Brew Apps';
  users: any;

  // Dependency Injection.
  constructor(private http: HttpClient, private accountService: AccountService) { }

  // Life cycle.
  ngOnInit() {
    this.getUsers();
    this.setCurrentUser();
  }

  /*
   * If there is any user stored in the local storage,
   * take the value out and set currentUserSource (AccountService).
   */
  setCurrentUser() {
    const user: User = JSON.parse(localStorage.getItem('user'));
    this.accountService.setCurrentUser(user);
  }

  getUsers() {
    this.http.get('https://localhost:5001/api/users').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }
}

