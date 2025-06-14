import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'client';
  users:any="";

  constructor(private  http:HttpClient)
  {

  }
 ngOnInit() {
    this.http.get('http://localhost:5217/api/User').subscribe({
      next:(data)=>{
        this.users=data;
        console.log(data);      },
        error:(err)=>{
          console.error('Error fetching data:', err);
        }
    })
  }
}
