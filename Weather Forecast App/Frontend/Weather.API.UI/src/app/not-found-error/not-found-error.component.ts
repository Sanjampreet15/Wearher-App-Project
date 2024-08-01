import { Component } from '@angular/core';

@Component({
  selector: 'app-not-found-error',
  templateUrl: './not-found-error.component.html',
  styleUrl: './not-found-error.component.css',
})
export class NotFoundComponent {
  customAction() {
    window.location.reload();
  }
}
