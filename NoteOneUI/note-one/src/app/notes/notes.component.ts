import { Component, OnInit } from '@angular/core';
import { NoteService } from './notes.service';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.css'],
  providers: [NoteService]
})
export class NotesComponent implements OnInit {

  constructor(private noteService: NoteService) { }

  public categories = ['Work', 'Shopping', 'Variables', 'Stocks', 'Passwords']
  public pages = ["page1", "page2", "page3", "page4"]
  public notes = ["alskdjlsakjdlkasjdlaskjd","asdjasdjalskdjaslkdjalkjd", "asdkjhsjkfgkwjagjkgahjf"]
  ngOnInit(): void {
  }

}
