import { Component, OnInit } from '@angular/core';
import { PessoaService } from '../../services/pessoa.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { AfterViewInit } from '@angular/core';

@Component({
    selector: 'app-pessoa-list',
    templateUrl: './pessoa-list.component.html',
    styleUrls: ['./pessoa-list.component.css']
})
export class PessoaListComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['cpf', 'nome', 'genero', 'endereco', 'idade', 'municipio', 'estado'];
    dataSource: MatTableDataSource<any>;
    pessoas: any[] = [];
    totalPessoas: number = 0;
    pageSizeOptions: number[] = [5, 10, 20, 50];

    constructor(private pessoaService: PessoaService) { }

    ngOnInit(): void {
        this.loadPessoas();
    }

    ngAfterViewInit(): void {
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
    }

    loadPessoas(): void {
        this.pessoaService.getPessoas().subscribe((data: any[]) => {
            this.pessoas = data;
            this.totalPessoas = this.pessoas.length;
            this.dataSource = new MatTableDataSource(this.pessoas);
        });
    }

    applyFilter(event: Event): void {
        const filterValue = (event.target as HTMLInputElement).value;
        this.dataSource.filter = filterValue.trim().toLowerCase();
    }

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;
}