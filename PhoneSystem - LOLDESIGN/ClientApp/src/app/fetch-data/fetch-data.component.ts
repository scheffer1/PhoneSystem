import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public relation: Relation[] = [];
   baseUrl = "https://localhost:7083/api/";

  constructor(http: HttpClient) {
    http.get<Relation[]>('https://localhost:7083/api/getAll').subscribe(result => {
      this.relation = result;
      console.log(this.relation)
    }, error => console.error(error));
  }
}

interface Relation {
    id: number
    from: number
    to: number
    pricePerMin: DoubleRange
}
