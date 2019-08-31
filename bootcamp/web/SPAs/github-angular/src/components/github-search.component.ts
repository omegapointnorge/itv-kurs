import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GithubResponse } from './githubResponse';

@Component({
  selector: 'app-github-search',
  templateUrl: './github-search.component.html',
  styleUrls: ['./github-search.component.scss']
})
export class GithubSearchComponent {
  username = '';
  githubUserInfo: GithubResponse = {} as any;
  loadingUser = false;

  constructor(private httpClient: HttpClient) {}

  getUser() {
    this.loadingUser = true;
    this.httpClient.get(`https://api.github.com/users/${this.username}`).subscribe(
      (response: GithubResponse) => {
        this.githubUserInfo = response;
        this.loadingUser = false;
      },
      (error: Error) => {
        this.loadingUser = false;
      }
    );
  }
}
