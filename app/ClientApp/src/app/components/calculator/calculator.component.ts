import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';
import { ChangeDetectionStrategy, ChangeDetectorRef, Component , } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-calculator',
  standalone: true,
  imports: [FormsModule, CommonModule, HttpClientModule], 
  templateUrl: './calculator.component.html',
  styleUrl: './calculator.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CalculatorComponent {
  public valorBruto: number | undefined = 0.0;
  public valorLiquido: number | undefined = 0.0;
  public valorInicial: number | undefined;
  public qtdMeses: number | undefined;

  private apiUrl = 'http://localhost:5153/api/';

  constructor(private http: HttpClient, private cdRef: ChangeDetectorRef){}

  enviarDados(){
    const body = {
      valorInicial: this.valorInicial,
      qtdMeses: this.qtdMeses
    };

    const headers = new HttpHeaders();
    headers.set('Content-Type', 'application/json');

    this.http.post(this.apiUrl + 'CalculoCDB', body, { headers }).subscribe(
      (data: any) => {
        this.valorBruto = data.valorBruto;
        this.valorLiquido = data.valorLiquido;
        this.cdRef.detectChanges(); 
      },
      (error: any) => {
        console.error('Erro:', error);
      }
    );
  }

  validarCampos(): boolean{
    return this.valorInicial === undefined || this.valorInicial === null || this.valorInicial <= 0 ||
            this.qtdMeses === undefined || this.qtdMeses === null || this.qtdMeses <= 1 
  }
}
