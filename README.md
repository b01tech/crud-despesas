# CRUD Despesas

Sistema de gerenciamento de despesas pessoais, desenvolvido como um projeto Full Stack utilizando tecnologias modernas.

## 🚀 Tecnologias Utilizadas

### Backend

- **.NET 10**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **Scalar** (Documentação da API)
- **C#**

### Frontend

- **Angular 21**
- **Tailwind CSS 4**
- **TypeScript**
- **Reactive Forms**

## 📦 Estrutura do Projeto

O projeto está dividido em duas pastas principais:

- `backend`: Contém a API e lógica de negócios.
- `frontend`: Contém a aplicação web Angular.

## 🛠️ Como Executar

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (LTS recomendado)
- [Angular CLI](https://angular.io/cli)

### Backend

1. Navegue até a pasta da API:

   ```bash
   cd backend/src/API
   ```

2. Restaure as dependências e execute o projeto:

   ```bash
   dotnet run
   ```

   A API estará disponível em `http://localhost:5000` (ou porta configurada no `launchSettings.json`).
   Acesse a documentação via Scalar em `http://localhost:5000/docs`.

### Frontend

1. Navegue até a pasta do frontend:

   ```bash
   cd frontend
   ```

2. Instale as dependências:

   ```bash
   npm install
   ```

3. Execute o servidor de desenvolvimento:

   ```bash
   npm start
   ```

   ou

   ```bash
   ng serve --open
   ```

   A aplicação estará disponível em `http://localhost:4200`.

## ✨ Funcionalidades

- **Listagem de Despesas**: Visualize todas as despesas cadastradas com formatação de data e moeda.
- **Criação de Despesas**: Adicione novas despesas informando descrição, data, valor e status de pagamento.
- **Edição de Despesas**: Atualize informações de despesas existentes.
- **Exclusão de Despesas**: Remova despesas da lista.
- **Status Visual**: Identificação rápida de despesas pagas e pendentes.

## 📄 Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE.md](LICENSE.md) para mais detalhes.
