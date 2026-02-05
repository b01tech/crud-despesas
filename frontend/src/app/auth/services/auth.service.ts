import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environment/environment';
import { LoginRequest } from '../models/login-request';
import { SignupRequest } from '../models/signup-request';
import { TokenResponse } from '../models/token-response';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private readonly _apiUrl = environment.apiUrl;
  private readonly _httpClient = inject(HttpClient);

  signup(signupRequest: SignupRequest) {
    return this._httpClient.post(`${this._apiUrl}/usuario`, signupRequest);
  }

  login(loginRequest: LoginRequest) {
    return this._httpClient.post<TokenResponse>(`${this._apiUrl}/usuario/login`, loginRequest);
  }

  isAuthenticated(): boolean {
    const token = document.cookie.split('; ').find((row) => row.startsWith('access_token='));
    return !!token;
  }
}
