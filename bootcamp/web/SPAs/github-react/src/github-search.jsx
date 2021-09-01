import React, { useState } from "react";

const GithubSearch = () => {
  const [username, setUserName] = useState("");
  const [githubUser, setGithubUser] = useState({});
  const [isLoadingUser, setIsLoadingUser] = useState(false);

  const getUser = () => {
    setIsLoadingUser(true);
    fetch(`https://api.github.com/users/${username}`)
      .then((response) => {
        response.json().then((githubUser) => {
          setGithubUser(githubUser);
          setIsLoadingUser(false);
        });
      })
      .catch(() => setIsLoadingUser(false));
  };

  return (
    <main>
      <div>
        <h1>Github users</h1>
        <div>
          <input onChange={(e) => setUserName(e.currentTarget.value)} autoFocus></input>
          <button onClick={() => getUser()}>Search</button>
        </div>
      </div>
      <div id="content">
        {isLoadingUser && <div className="spin"></div>}
        {githubUser.login && (
          <div className="card">
            <h2>{githubUser.login}</h2>
            <a href={githubUser.blog} style={{ display: "block" }}>
              {githubUser.blog}
            </a>
            {githubUser.avatar_url && <img src={githubUser.avatar_url} alt="avatar" width="200" height="200" />}
          </div>
        )}
      </div>
    </main>
  );
};

export default GithubSearch;
