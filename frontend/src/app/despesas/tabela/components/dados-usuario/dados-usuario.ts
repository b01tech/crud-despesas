import { Component, inject } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AuthService } from '../../../../auth/services/auth.service';

@Component({
  selector: 'app-dados-usuario',
  imports: [RouterLink],
  templateUrl: './dados-usuario.html',
  styleUrl: './dados-usuario.css',
})
export class DadosUsuario {
  private readonly _authService = inject(AuthService);
  private readonly _router = inject(Router);

  logout() {
    this._authService.logout();
    this._router.navigate(['/']);
  }
}
