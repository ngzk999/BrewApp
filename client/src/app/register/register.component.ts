import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() usersFromHomeComponent: any; //receive data from parent component (HomeComponent).
  @Output() cancelRegister = new EventEmitter(); //for output, we always emitting event.
  model: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  register() {
    console.log(this.model);
  }

  cancel() {
    // pass "false" to parent component (HomeComponent)'s registerMode property.
    this.cancelRegister.emit(false);
  }
}
