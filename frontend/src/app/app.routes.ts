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
  {
    path: 'despesas/editar/:id',
    loadComponent: () =>
      import('./despesas/editar-despesa/editar-despesa').then((mod) => mod.EditarDespesa),
  },
];
