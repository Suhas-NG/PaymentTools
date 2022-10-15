import { Injectable } from "@angular/core";
import { INote } from "./note" ;

@Injectable()
export class NoteService {

    getNotes(): INote[] {
        return [
            
        ]
    }
}