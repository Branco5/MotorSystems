import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientService } from '../../services/client.service';
import { Product, ProductsService } from '../../services/products.service';
import { Service, ServiceItem, ServiceItemItem, ServicesService } from '../../services/services.service';

@Component({
  selector: 'app-service-item-add',
  templateUrl: './service-item-add.component.html',
  styleUrls: ['./service-item-add.component.css']
})
export class ServiceItemAddComponent implements OnInit {

  public products: Product[] = [];
  public itemItems: ServiceItemItem[] = [];
  public serviceId: number | undefined;

  constructor(private clientService: ClientService, private servService: ServicesService, private prodService: ProductsService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.populateProducts();
    this.serviceId=this.route.snapshot.params['id'];
    //this.servService.getServiceItemItems(this.serviceId!).subscribe()
  }

  populateProducts() {
    this.prodService.getProducts().
      subscribe(products => this.products = products);
  }

  addToService(form: NgForm) {
    let item: ServiceItem = form.value;
    item.serviceId = this.serviceId!;
    this.servService.addServiceItem(item).subscribe(res => {
      let itemId = res.id;
      this.itemItems.forEach(ii => {
        ii.serviceItemId = itemId;
        ii.product = undefined;
        this.servService.addServiceItemItem(ii).subscribe(res => {          
          this.router.navigateByUrl("services/" + this.serviceId);
        });        
      })      
    });

    console.log("NEXT");
    this.servService.getService(item.serviceId).subscribe(service => {
      this.clientService.getClient(service.client).subscribe(client => {
        if (!client.serviceUpdated) {          
          client.serviceUpdated = true;
          console.log("SERVICE UPDATED", client.serviceUpdated);
          this.clientService.updateClient(client).subscribe();
        }        
      })      
    })
  }

  addItem(form: NgForm) {
    let item: ServiceItemItem = form.value;
    this.prodService.getProduct(item.productId!).subscribe(res => {
      item.productId = res.id;
      item.product = res;
      this.itemItems.push(item);      
    });
  }
}


