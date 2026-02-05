import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { SignupRequest } from '../models/signup-request';

@Component({
  selector: 'app-usuario',
  imports: [ReactiveFormsModule, RouterLink],
  templateUrl: './usuario.html',
  styleUrl: './usuario.css',
})
export class Usuario {
  private readonly _fb = inject(FormBuilder);
  private readonly _authService = inject(AuthService);
  private readonly _router = inject(Router);

  form = this._fb.group({
    nome: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    senha: ['', Validators.required],
  });

  onSubmit() {
    if (this.form.valid) {
      const request = this.form.value as SignupRequest;
      this._authService.signup(request).subscribe({
        next: () => {
          this._router.navigate(['/auth/login']);
        },
        error: (err) => {
          console.error('Erro ao criar usuário', err);
        },
      });
    }
  }
}
