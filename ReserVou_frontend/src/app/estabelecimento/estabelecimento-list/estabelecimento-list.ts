import { Component } from '@angular/core';
import { EstabelecimentoService } from '../estabelecimento.service';
import { Estabelecimento } from '../estabelecimento.model';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-estabelecimento-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './estabelecimento-list.html',
  styleUrls: ['./estabelecimento-list.css']
})

export class EstabelecimentoListComponent {
  estabelecimentos: Estabelecimento[];

  constructor(private estabelecimentoService: EstabelecimentoService) {
    this.estabelecimentos = this.estabelecimentoService.obterTodos();
  }
} 