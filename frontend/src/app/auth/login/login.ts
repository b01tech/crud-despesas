import { Component, inject, signal } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { LoginRequest } from '../models/login-request';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule, RouterLink],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  private readonly _fb = inject(FormBuilder);
  private readonly _authService = inject(AuthService);
  private readonly _router = inject(Router);
  loginFail = signal(false);

  loginForm = this._fb.group({
    email: ['', [Validators.required, Validators.email]],
    senha: ['', Validators.required],
  });

  onSubmit() {
    if (this.loginForm.valid) {
      this._authService.login(this.loginForm.value as LoginRequest).subscribe({
        next: (response) => {
          document.cookie = `access_token=${response.token}; path=/`;
          this._router.navigate(['/despesas']);
        },
        error: (error) => {
          this.loginFail.set(true);
          console.error('Login failed', error);
        },
      });
    }
  }
}
