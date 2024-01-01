import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root',
})
export class BusyService {
  busyRequesCount = 0;

  constructor(private spinnerService: NgxSpinnerService) {}

  busy() {
    this.busyRequesCount++;
    this.spinnerService.show(undefined, {
      type: 'ball-spin-clockwise',
      bdColor: 'rgba(255,255,255,0)',
      color: '#333',
    });
  }

  idle() {
    this.busyRequesCount--;
    if (this.busyRequesCount <= 0) {
      this.busyRequesCount = 0;
      this.spinnerService.hide();
    }
  }
}
