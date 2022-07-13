import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getClients(): Observable<Client[]> {
    return this.http.get<Client[]>(this.baseUrl + 'api/clients')
  }

  //getClient(id: string): Observable<Client> {
  //  console.log("CALLING CLIENT GET");
  //  return this.http.get<Client>(this.baseUrl + 'api/clients/' + id);
  //}

  getClient(username: string): Observable<Client> {
    console.log("CALLING CLIENT GET");
    return this.http.get<Client>(this.baseUrl + 'api/clients/' + username);
  }


  updateClient(client: Client): Observable<Client> {
    console.log("CALLING CLIENT PUT");
    return this.http.put<Client>(this.baseUrl + 'api/clients/' + client.id, client);
  }
}

export interface Client {
  id: string;
  userName: string;
  docId: number;
  createdDate: Date;
  address: string;
  city: string;
  zip: string;
  serviceUpdated: boolean;
}


