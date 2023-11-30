import { Component, OnInit } from '@angular/core';
import { EducationDataServiceService } from "../../Services/EducationData/education-data.service.service"
@Component({
  selector: 'app-education-data',
  templateUrl: './education-data.component.html',
  styleUrls: ['./education-data.component.css']
})
export class EducationDataComponent implements OnInit{
  
  listEducationData: any[] = [];

  constructor(private _educationData: EducationDataServiceService){

  }
  
  ngOnInit(): void {
    this._educationData.getListPersonalData().subscribe((data: any[]) => {
      data.forEach(element => {
        if(element.finishDate != null){
          var sfinishedDate: string[] = element.finishDate.split("/");
          var finishedDate: Date = new Date(parseInt(sfinishedDate[2]),parseInt(sfinishedDate[1]),parseInt(sfinishedDate[0]));
          element.finishDate = finishedDate.getFullYear();
        }
      });
      this.listEducationData = data;
      console.log(data);
    },
    (error: any) => {
      console.log(error);
    })
  }

}
