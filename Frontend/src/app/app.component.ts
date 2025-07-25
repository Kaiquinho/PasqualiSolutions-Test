import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'crud-pessoas-angular';

    constructor() {
        // Constructor vazio - pode ser usado para injeção de dependências futuras
    }

    // Método opcional para lidar com eventos globais da aplicação
    ngOnInit(): void {
        // Este método pode ser usado para inicializações quando o componente for criado
        console.log('Aplicação CRUD de Pessoas inicializada');
    }
}