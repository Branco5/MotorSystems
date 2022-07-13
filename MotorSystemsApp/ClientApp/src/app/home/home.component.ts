import { Component } from '@angular/core';
import { AuthorizeGuard } from '../../api-authorization/authorize.guard';
import { AuthorizeService, IUser } from '../../api-authorization/authorize.service';
import { ClientService } from '../services/client.service';
import { NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public user: IUser | null | undefined;

  constructor(private service: AuthorizeService, private guard: AuthorizeGuard,
              private clientService: ClientService, private notifService: NgToastService) { }

  ngOnInit() {
    //this.notifService.info({ detail: "test", summary: "One of your services has been updated", duration: 50000 })

    this.service.getUser().subscribe(user => {
      this.user = user;      
      if (this.user) {
        console.log("USER NOT NULL");
        let username = user!.name
        this.clientService.getClient(username!).subscribe(client => {
          console.log("CLIENT: ", client);          
          if (client.serviceUpdated) {
            console.log("SERVICE UPDATED");
            this.notifService.info({detail:"Service Updated", summary: "One of your services has been updated", position:'tr', duration: 5000})
            client.serviceUpdated = false;
            this.clientService.updateClient(client).subscribe();
          }
        })
      }
    });
  }

}

