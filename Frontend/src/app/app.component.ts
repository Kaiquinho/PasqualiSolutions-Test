import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'crud-pessoas-angular';

    constructor() {
        // Constructor vazio - pode ser usado para inje��o de depend�ncias futuras
    }

    // M�todo opcional para lidar com eventos globais da aplica��o
    ngOnInit(): void {
        // Este m�todo pode ser usado para inicializa��es quando o componente for criado
        console.log('Aplica��o CRUD de Pessoas inicializada');
    }
}