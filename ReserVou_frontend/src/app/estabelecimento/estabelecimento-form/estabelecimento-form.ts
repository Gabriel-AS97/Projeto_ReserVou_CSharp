import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EstabelecimentoService } from '../estabelecimento.service';
import { Estabelecimento } from '../estabelecimento.model';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-aluno-form',
  standalone: true,
  imports: [
              ReactiveFormsModule,
              MatCardModule,
              MatFormFieldModule,
              MatInputModule,
              MatButtonModule,
              CommonModule],
  templateUrl: './estabelecimento-form.html',
  styleUrl: './estabelecimento-form.scss'
 })
 export class EstabelecimentoFormComponent {
    form: FormGroup;

    constructor(private fb: FormBuilder, private estabelecimentoService: EstabelecimentoService, private router: Router) {
 this.form = this.fb.group({
    nome_estabelecimento: ['', Validators.required],
    endereco_estabelecimento: ['', Validators.required],
    });
  }

  adicionar() {
    if (this.form.valid) {
      this.estabelecimentoService.adicionar(this.form.value).subscribe({
      next: () => this.router.navigate(['/']),
      error: () => alert('Erro ao salvar estabelecimento.'),
      });
      }
  }
}

/*@Component({
  selector: 'app-estabelecimento-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './estabelecimento-form.html',
  styleUrl: './estabelecimento-form.scss'
})

export class EstabelecimentoFormComponent {
  nome_estabelecimento: string = '';
  endereco_estabelecimento: string = '';

  constructor(private estabelecimentoService: EstabelecimentoService) {}

  adicionar() {
    const novoEstabelecimento = new Estabelecimento(this.nome_estabelecimento, this.endereco_estabelecimento);
    this.estabelecimentoService.adicionar(novoEstabelecimento);
    this.nome_estabelecimento = '';
    this.endereco_estabelecimento = '';
 }
}*/