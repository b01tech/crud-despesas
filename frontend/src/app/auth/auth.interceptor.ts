import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, throwError } from 'rxjs';
import { AuthService } from './services/auth.service';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const router = inject(Router);
  const authService = inject(AuthService);
  const token = document.cookie
    .split('; ')
    .find((row) => row.startsWith('access_token='))
    ?.split('=')[1];

  let requestToHandle = req;

  if (token) {
    requestToHandle = req.clone({
      headers: req.headers.set('Authorization', `Bearer ${token}`),
    });
  }

  return next(requestToHandle).pipe(
    catchError((error: HttpErrorResponse) => {
      if (error.status === 401) {
        authService.logout();
        router.navigate(['/auth/login']);
      }
      return throwError(() => error);
    }),
  );
};
