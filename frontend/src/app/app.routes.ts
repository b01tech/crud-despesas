import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'despesas',
  },
  {
    path: 'despesas',
    loadComponent: () => import('./despesas/despesas').then((mod) => mod.Despesas),
  },
  {
    path: 'despesas/criar',
    loadComponent: () =>
      import('./despesas/criar-despesa/criar-despesa').then((mod) => mod.CriarDespesa),
  },
];
