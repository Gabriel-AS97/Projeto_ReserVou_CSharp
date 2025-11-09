import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Estabelecimento } from "./estabelecimento/estabelecimento";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Estabelecimento],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('ReserVou_frontend');
}
