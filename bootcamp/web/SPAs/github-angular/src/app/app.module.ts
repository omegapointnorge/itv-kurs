import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { GithubSearchComponent } from 'src/github-search/github-search.component';
import { GithubSearchAsComponentsComponent } from 'src/github-search-as-components/github-search-as-components.component';
import { HeaderComponent } from 'src/github-search-as-components/header/header.component';
import { SpinnerComponent } from 'src/github-search-as-components/spinner/spinner.component';
import { AvatarComponent } from 'src/github-search-as-components/avatar/avatar.component';
import { LinkComponent } from 'src/github-search-as-components/link/link.component';
import { CardComponent } from 'src/github-search-as-components/card/card.component';

@NgModule({
  declarations: [
    AppComponent,
    GithubSearchComponent,
    GithubSearchAsComponentsComponent,
    SpinnerComponent,
    HeaderComponent,
    AvatarComponent,
    LinkComponent,
    CardComponent
  ],
  imports: [BrowserModule, FormsModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
