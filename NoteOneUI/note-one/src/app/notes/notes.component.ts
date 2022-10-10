import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.css']
})
export class NotesComponent implements OnInit {

  constructor() { }

  public categories = ['Work' , 'Medicine', 'Shopping','Variables', 'Stocks', 'Passwords']
  public pages = ["page1", "page2", "page3", "page4"]
  public notes = ["alskdjlsakjdlkasjdlaskjd","asdjasdjalskdjaslkdjalkjd", "asdkjhsjkfgkwjagjkgahjf"]
  ngOnInit(): void {
  }

}
