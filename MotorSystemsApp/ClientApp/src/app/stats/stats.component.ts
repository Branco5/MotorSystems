import { Component, OnInit } from '@angular/core';
import { AuthorizeService } from '../../api-authorization/authorize.service';
import { WorkerService, Worker } from '../services/worker.service';
import { Service, ServicesService } from '../services/services.service';

@Component({
  selector: 'app-stats',
  templateUrl: './stats.component.html',
  styleUrls: ['./stats.component.css']
})
export class StatsComponent implements OnInit {

  public tableItems: TableItem[] = [];

  constructor(private userService: AuthorizeService, private servicesService: ServicesService, private workerService: WorkerService) {}

  ngOnInit(): void {
    this.workerService.getWorkers().subscribe(workers => {
      workers.forEach(worker => {
        let tableItem: TableItem = {
          worker: worker.username,
          numberOfServices: 0,
          numberOfServicesFinished: 0,
          numberOfServicesCancelled: 0,
          numberOfServicesProcessing: 0,
          mostCommonServiceType: "-"
        };
        this.servicesService.getServicesByWorker(worker.username).subscribe(services => {
          tableItem.numberOfServices = services.length;
          //Math.max(...services.map(({ type }) => type));
          let servicesTypes = services.map(s => s.type);
          tableItem.mostCommonServiceType = servicesTypes.sort((a, b) => servicesTypes.filter(v => v === a)
                              .length - servicesTypes.filter(v => v === b).length).pop();
          

          services.forEach(service => {
            console.log(service.state);
            if (service.state === "Finished") {
              tableItem.numberOfServicesFinished++;
            }
            else if (service.state === "Processing") {
              tableItem.numberOfServicesProcessing+=1;
            }
            else if (service.state === "Cancelled") {
              tableItem.numberOfServicesCancelled++;
            }
          })


          this.tableItems!.push(tableItem);
        })
      })
    })
  }
}

interface TableItem {
  worker: string;
  numberOfServices: number;
  numberOfServicesFinished: number;
  numberOfServicesCancelled: number;
  numberOfServicesProcessing: number;
  mostCommonServiceType: string | undefined;
}
