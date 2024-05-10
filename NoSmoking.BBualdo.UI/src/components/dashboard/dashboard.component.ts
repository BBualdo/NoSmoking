import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { SmokeService } from '../../services/smoke.service';
import { SmokeLog } from '../../models/SmokeLog';
import { BehaviorSubject, Subject } from 'rxjs';
import { AsyncPipe, formatDate } from '@angular/common';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterLink, AsyncPipe],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css',
})
export class DashboardComponent {
  logsSubject: Subject<SmokeLog[] | null> = new BehaviorSubject<
    SmokeLog[] | null
  >(null);

  logs$ = this.logsSubject.asObservable();

  constructor(private smokeService: SmokeService) {}

  ngOnInit(): void {
    this.getSmokeLogs();
  }

  formatDate(dateStr: string, format: string, locale: string): string {
    return formatDate(dateStr, format, locale);
  }

  getSmokeLogs() {
    this.smokeService.getLogs().subscribe((logs) => {
      this.logsSubject.next(logs);
    });
  }
}
