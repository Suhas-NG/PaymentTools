import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { Home } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './shared/material.module';
import { TlvAnalyzerComponent } from './tlv-analyzer/tlv-analyzer.component';
import { TlvComparerComponent } from './tlv-comparer/tlv-comparer.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { TlvCompareTreeComponent } from './tlv-compare-tree/tlv-compare-tree.component';


@NgModule({
  declarations: [
    AppComponent,
    Home,
    TlvAnalyzerComponent,
    TlvComparerComponent,
    TlvCompareTreeComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
