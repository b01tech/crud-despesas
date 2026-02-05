import { Routes } from '@angular/router';
import { authGuard } from './auth/guard/auth.guard';
import { loginGuard } from './auth/guard/login.guard';

export const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'auth/login',
  },
  {
    path: 'despesas',
    canActivate: [authGuard],
    loadComponent: () => import('./despesas/despesas').then((mod) => mod.Despesas),
  },
  {
    path: 'despesas/criar',
    canActivate: [authGuard],
    loadComponent: () =>
      import('./despesas/criar-despesa/criar-despesa').then((mod) => mod.CriarDespesa),
  },
  {
    path: 'despesas/editar/:id',
    canActivate: [authGuard],
    loadComponent: () =>
      import('./despesas/editar-despesa/editar-despesa').then((mod) => mod.EditarDespesa),
  },
  {
    path: 'auth/usuario',
    canActivate: [loginGuard],
    loadComponent: () => import('./auth/usuario/usuario').then((mod) => mod.Usuario),
  },
  {
    path: 'auth/login',
    canActivate: [loginGuard],
    loadComponent: () => import('./auth/login/login').then((mod) => mod.Login),
  },
];
