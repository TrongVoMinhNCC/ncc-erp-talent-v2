import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BaseApiService } from '../apis/base-api.service';

@Injectable({
  providedIn: 'root'
})
export class SubPositionService extends BaseApiService{

  constructor(
    public http: HttpClient
  ) {
    super(http);
  }
  
  changeUrl(): string {
   return 'SubPostision';
  }
}