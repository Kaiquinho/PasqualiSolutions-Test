# 📋 CRUD de Pessoas - Angular 17 + ASP.NET Core

> **Aplicação completa com front-end em Angular 17 e back-end em ASP.NET Core**

---

## 📑 Índice

- [📋 CRUD de Pessoas - Angular 17 + ASP.NET Core](#-crud-de-pessoas---angular-17--aspnet-core)
  - [📑 Índice](#-índice)
  - [🎯 Objetivo](#-objetivo)
  - [🚀 Tecnologias Utilizadas](#-tecnologias-utilizadas)
  - [📁 Estrutura do Projeto](#-estrutura-do-projeto)
  - [⚙️ Pré-requisitos](#️-pré-requisitos)
    - [Back-end (.NET Core)](#back-end-net-core)
    - [Front-end (Angular)](#front-end-angular)
  - [📦 Instalação](#-instalação)
    - [Back-end](#back-end)
    - [Front-end](#front-end)
  - [🏃 Execução](#-execução)
    - [Iniciar o Back-end](#iniciar-o-back-end)
    - [Iniciar o Front-end](#iniciar-o-front-end)
  - [🌐 Funcionalidades](#-funcionalidades)
  - [🎨 Componentes Principais](#-componentes-principais)
  - [🔌 API Endpoints](#-api-endpoints)
  - [📱 Interface do Usuário](#-interface-do-usuário)
  - [🛡️ Tratamento de Erros](#️-tratamento-de-erros)
  - [📊 Dados Mockados](#-dados-mockados)
  - [🔧 Desenvolvimento](#-desenvolvimento)
  - [🧪 Testes](#-testes)
  - [🏗️ Arquitetura](#️-arquitetura)
  - [🤝 Contribuição](#-contribuição)
  - [📄 Licença](#-licença)
  
---

## 🎯 Objetivo

Desenvolver uma aplicação CRUD completa com:
- **Back-end**: API RESTful em ASP.NET Core (mockada)
- **Front-end**: Interface em Angular 17 com Angular Material
- **Funcionalidades**: Listagem, paginação, filtragem e carregamento de dados

---

## 🚀 Tecnologias Utilizadas

### Back-end
- **[ASP.NET Core 7+](https://dotnet.microsoft.com/apps/aspnet)** - Framework web
- **C#** - Linguagem de programação
- **REST API** - Arquitetura de serviços

### Front-end
- **[Angular 17](https://angular.io)** - Framework frontend
- **[Angular Material](https://material.angular.io)** - Componentes UI
- **[TypeScript](https://www.typescriptlang.org)** - Superset do JavaScript
- **[RxJS](https://rxjs.dev)** - Programação reativa

---

## 📁 Estrutura do Projeto

```
/project-root/
├── 📁 backend/
│   ├── 📄 Pessoa.cs
│   ├── 📄 Program.cs
│   ├── 📄 appsettings.json
│   └── 📁 Properties/
└── 📁 frontend/
    ├── 📄 package.json
    ├── 📄 angular.json
    ├── 📄 src/
    │   ├── 📄 styles.css
    │   ├── 📄 main.ts
    │   └── 📁 app/
    │       ├── 📁 components/
    │       │   └── 📁 pessoa-list/
    │       │       ├── pessoa-list.component.html
    │       │       ├── pessoa-list.component.ts
    │       │       └── pessoa-list.component.css
    │       ├── 📁 services/
    │       │   └── pessoa.service.ts
    │       ├── app-routing.module.ts
    │       ├── app.module.ts
    │       ├── app.component.html
    │       ├── app.component.ts
    │       └── app.component.css
└── 📄 README.md
```

---

## ⚙️ Pré-requisitos

### Back-end (.NET Core)
- [.NET SDK 7.0 ou superior](https://dotnet.microsoft.com/download)
- IDE: Visual Studio, VS Code ou Rider

### Front-end (Angular)
- [Node.js 16+](https://nodejs.org/)
- [npm 8+](https://www.npmjs.com/)
- [Angular CLI](https://angular.io/cli)

---

## 📦 Instalação

### Back-end
```bash
cd backend
# O projeto .NET não requer instalação adicional além do SDK
```

### Front-end
```bash
cd frontend
npm install
```

---

## 🏃 Execução

### Iniciar o Back-end
```bash
cd backend
dotnet run
```
> 🌐 API disponível em: `http://localhost:5000`

### Iniciar o Front-end
```bash
cd frontend
ng serve
# ou
npm start
```
> 🌐 Aplicação disponível em: `http://localhost:4200`

---

## 🌐 Funcionalidades

✅ **Listagem de Pessoas** - Exibição em tabela paginada  
✅ **Paginação** - 10 registros por página  
✅ **Filtragem** - Busca por nome em tempo real  
✅ **Carregamento** - Botão para atualizar dados  
✅ **Responsividade** - Layout adaptável para mobile  
✅ **Design Moderno** - Interface com Angular Material  

---

## 🎨 Componentes Principais

### 📋 PessoaListComponent
- **Responsabilidade**: Exibir tabela de pessoas
- **Funcionalidades**: 
  - Paginação
  - Filtragem
  - Carregamento de dados
  - Design responsivo

### 🌐 PessoaService
- **Responsabilidade**: Comunicação com API
- **Métodos**: 
  - `getPessoas()` - Busca dados da API

### 🔄 AppRoutingModule
- **Responsabilidade**: Roteamento da aplicação
- **Rotas**: 
  - `/pessoas` - Lista de pessoas
  - Rota padrão e curinga

---

## 🔌 API Endpoints

### GET `/api/pessoas`
```http
GET http://localhost:5000/api/pessoas
```

**Response:**
```json
[
  {
    "cpf": "123.456.789-00",
    "nome": "João Silva",
    "genero": "Masculino",
    "endereco": "Rua A, 123",
    "idade": 25,
    "municipio": "São Paulo",
    "estado": "SP"
  }
]
```

---

## 📱 Interface do Usuário

### Elementos Visuais
- 📊 **Tabela Material** - Com ordenação por colunas
- 🔍 **Campo de Busca** - Filtro em tempo real
- 📄 **Paginação** - Controles de navegação
- 🎨 **Design Responsivo** - Adaptação mobile
- 🎯 **Feedback Visual** - Hover e animações

### Componentes do Material
- `mat-table` - Tabela de dados
- `mat-paginator` - Paginação
- `mat-form-field` - Campo de formulário
- `mat-input` - Input de texto
- `mat-button` - Botões estilizados

---

## 🛡️ Tratamento de Erros

### Erros Comuns
- ❌ **API Indisponível** - Mensagem de erro amigável
- ❌ **Dados Vazios** - Indicação visual
- ❌ **Falha de Conexão** - Retry automático

### Feedback ao Usuário
- 🔄 **Loading States** - Indicadores de carregamento
- ✅ **Success Messages** - Confirmação de ações
- ⚠️ **Error Messages** - Mensagens de erro claras

---

## 📊 Dados Mockados

### Estrutura de Dados
```typescript
interface Pessoa {
  cpf: string;
  nome: string;
  genero: string;
  endereco: string;
  idade: number;
  municipio: string;
  estado: string;
}
```

### Quantidade de Registros
- 📦 **30 registros** mockados
- 🎲 **Dados variados** para testes
- 📈 **Distribuição realista** de valores

---

## 🔧 Desenvolvimento

### Comandos Úteis

#### Back-end
```bash
# Executar em modo desenvolvimento
dotnet run

# Compilar projeto
dotnet build

# Publicar aplicação
dotnet publish
```

#### Front-end
```bash
# Servidor de desenvolvimento
ng serve

# Build para produção
ng build

# Build com watch
ng build --watch

# Executar testes
ng test

# Linting
ng lint
```

### Estrutura de Componentes
```
app/
├── components/
│   └── pessoa-list/
│       ├── pessoa-list.component.ts    # Lógica
│       ├── pessoa-list.component.html  # Template
│       └── pessoa-list.component.css   # Estilos
├── services/
│   └── pessoa.service.ts               # API Service
├── app-routing.module.ts               # Rotas
├── app.module.ts                       # Módulo principal
└── app.component.*                     # Componente raiz
```

---

## 🧪 Testes

### Tipos de Testes Implementados
- ✅ **Testes Unitários** - Componentes e serviços
- ✅ **Testes de Integração** - Fluxos completos
- ✅ **Testes E2E** - Funcionalidades reais

### Frameworks de Teste
- **Jasmine** - Framework de testes
- **Karma** - Runner de testes
- **Protractor** - Testes E2E (se configurado)

---

## 🏗️ Arquitetura

### Padrões Utilizados
- **Component-Based Architecture** - Componentes reutilizáveis
- **Service Layer** - Separação de concerns
- **Reactive Programming** - RxJS para streams
- **Dependency Injection** - Injeção de dependências

### Fluxo de Dados
```
API (Back-end) → Service → Component → Template
     ↑              ↓          ↓          ↓
   Mocked      HttpClient   Binding    Angular Material
```

---

## 🤝 Contribuição

### Como Contribuir
1. 🍴 **Fork** o repositório
2. 🔧 **Crie uma branch** para sua feature (`git checkout -b feature/nova-feature`)
3. 💾 **Commit** suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. ⬆️ **Push** para a branch (`git push origin feature/nova-feature`)
5. 📤 **Abra um Pull Request**

### Padrões de Código
- ✨ **Clean Code** - Código limpo e legível
- 📝 **Commits Semânticos** - Mensagens claras
- 🎨 **Style Guide** - Seguir padrões do Angular

---

## 📄 Licença

Este projeto é desenvolvido para fins educacionais e demonstração de habilidades técnicas.

---

<p align="center">
  <strong>Desenvolvido com 🧠 e 🤖 usando Angular 17 + ASP.NET Core</strong>, pois a otimização das tarefas através da IA permite com que enxerguemos divervasos outros pontos de melhoria e revisão, ao invés de sermos só digitadores!
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white"/>
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white"/>
  <img src="https://img.shields.io/badge/TypeScript-007ACC?style=for-the-badge&logo=typescript&logoColor=white"/>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"/>
</p>
