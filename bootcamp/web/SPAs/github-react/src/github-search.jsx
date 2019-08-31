import React, { useState } from 'react';

const GithubSearch = () => {
  const [username, setUserName] = useState('');
  const [githubUser, setGithubUser] = useState({});
  const [isLoadingUser, setIsLoadingUser] = useState(false);

  const getUser = () => {
    setIsLoadingUser(true);
    fetch(`https://api.github.com/users/${username}`)
      .then(response => {
        response.json().then(githubUser => {
          setGithubUser(githubUser);
          setIsLoadingUser(false);
        });
      })
      .catch(() => setIsLoadingUser(false));
  };

  return (
    <div>
      <h1>Hi, and welcome. Search by user below</h1>
      <input onChange={e => setUserName(e.currentTarget.value)}></input>
      <button onClick={() => getUser()}>Click me</button>
      {isLoadingUser ? <div className="spin"></div> : <React.Fragment />}
      {githubUser.login ? (
        <div className="card">
          <h2>{githubUser.login}</h2>

          <a href={githubUser.blog} style={{ display: 'block' }}>
            {githubUser.blog}
          </a>

          {githubUser.avatar_url ? <img src={githubUser.avatar_url} alt="avatar" width="200" height="200" /> : <React.Fragment />}
        </div>
      ) : (
        <React.Fragment />
      )}
    </div>
  );
};

export default GithubSearch;
