import { Component, inject, OnInit, signal } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AuthService } from '../../../../auth/services/auth.service';

@Component({
  selector: 'app-dados-usuario',
  imports: [RouterLink],
  templateUrl: './dados-usuario.html',
  styleUrl: './dados-usuario.css',
})
export class DadosUsuario implements OnInit {
  private readonly _authService = inject(AuthService);
  private readonly _router = inject(Router);
  emailUsuario = signal<string>('');

  ngOnInit(): void {
    this.emailUsuario.set(this._authService.getUserEmail());
  }

  logout() {
    this._authService.logout();
    this._router.navigate(['/']);
  }
}
