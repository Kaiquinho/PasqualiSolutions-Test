import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class PessoaService {
    private apiUrl = 'http://localhost:5000/api/pessoas';

    constructor(private http: HttpClient) { }

    getPessoas(): Observable<any[]> {
        return this.http.get<any[]>(this.apiUrl);
    }
}