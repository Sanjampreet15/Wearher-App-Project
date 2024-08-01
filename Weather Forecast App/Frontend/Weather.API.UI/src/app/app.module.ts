import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { SkyAlertModule } from '@skyux/indicators';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
// import { FooterComponent } from './header/header.component';
import { NotFoundComponent } from './not-found-error/not-found-error.component';
import { SkyBoxModule, SkyFluidGridModule, SkyDescriptionListModule} from '@skyux/layout';
import { HttpClientModule } from '@angular/common/http';
import { SkyErrorModule } from '@skyux/errors';
import { DatePipe } from '@angular/common';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    // FooterComponent,
    NotFoundComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    SkyAlertModule,
    SkyBoxModule,
    SkyFluidGridModule,
    SkyErrorModule,
    SkyDescriptionListModule,
    FormsModule,
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent],
})
export class AppModule {}
