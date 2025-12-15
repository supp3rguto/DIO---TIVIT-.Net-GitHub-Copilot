import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class AppComponent {
  numeroCartao: string = '';
  resultado: any = null;
  
  private apiUrl = 'http://localhost:5000/api/Card'; 

  constructor(private http: HttpClient) {}

  verificar() {
    if (!this.numeroCartao) return;

    this.http.get(`${this.apiUrl}/${this.numeroCartao}`)
      .subscribe({
        next: (dados) => {
          this.resultado = dados;
        },
        error: (erro) => {
          console.error('Erro:', erro);
          alert('Erro ao conectar na API. Verifique o C#.');
        }
      });
  }
  
  get statusClass() {
    if (!this.resultado) return '';
    return this.resultado.valido ? 'status-valido' : 'status-invalido';
  }
}