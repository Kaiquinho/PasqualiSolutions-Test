import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PessoaListComponent } from './components/pessoa-list/pessoa-list.component';

const routes: Routes = [
    { path: '', redirectTo: '/pessoas', pathMatch: 'full' },
    { path: 'pessoas', component: PessoaListComponent },
    { path: '**', redirectTo: '/pessoas' } // Rota curinga para redirecionar rotas não encontradas
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }