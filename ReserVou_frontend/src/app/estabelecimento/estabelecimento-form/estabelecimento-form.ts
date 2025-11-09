import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EstabelecimentoService } from '../estabelecimento.service';
import { Estabelecimento } from '../estabelecimento.model';

@Component({
  selector: 'app-estabelecimento-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './estabelecimento-form.html',
  styleUrl: './estabelecimento-form.css'
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
}