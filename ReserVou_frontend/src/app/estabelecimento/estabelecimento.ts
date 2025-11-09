import { Component } from '@angular/core';

@Component({
  selector: 'app-estabelecimento',
  templateUrl: './estabelecimento.html',
  styleUrls: ['./estabelecimento.scss']
})
export class Estabelecimento {
  nomeEstabelecimento: string = "Hotel 1";
  enderecoEstabelecimento: string = "Rua 1";
  contadorCliques: number = 0;

  mostrarBoasVindas() {
    alert("Bem-vindo! Este estabelecimento é o " + this.nomeEstabelecimento + ", que fica no endereço: " + this.enderecoEstabelecimento);
  }

  contarClique() {
    this.contadorCliques = this.contadorCliques + 1;
  }
}
