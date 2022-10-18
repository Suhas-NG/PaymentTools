import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, Observable, tap, throwError } from "rxjs";
import { ITlvCompare } from "./tlv-compare" ;

@Injectable(
    {
     providedIn: "root"   
    }
)
export class TlvCompareService {

    constructor(private http: HttpClient){}

    private tlvCompareUrl = "https://localhost:7249/Api/Tlv"

    getTlvCompareResult(tlv1: string, tlv2:string ): Observable<ITlvCompare[]>  {
       return this.http.post<ITlvCompare[]>(this.tlvCompareUrl, {
            "tlv1HexString": tlv1,
            "tlv2HexString": tlv2
       }).pipe(
        tap(data => console.log('All:', JSON.stringify(data))),
        catchError(this.handleError)
       ) ;
    }

    private handleError(err: HttpErrorResponse) {
        let errorMessage =""
        if(err.error instanceof ErrorEvent){
            errorMessage = `An error has occured : ${err.error.message}`;
        } else {
            errorMessage = `Error code returned by server :${err.status}, error message : ${err.message}`
        }
      return throwError(()=> errorMessage);  
    } 
}