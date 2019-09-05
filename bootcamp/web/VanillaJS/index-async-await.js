async function getUser() {
  const username = document.getElementById('username-input').value;

  const userCard = newFunction();

  let response = await fetch(`https://api.github.com/users/${username}`);

  if (response.status === 404) {
    userCard.innerHTML = `Unable to find user: ${username}`;
    return;
  }
  if (response.status !== 200) {
    response.json().then(function(responseJson) {
      userCard.innerHTML(
        `Looks like there was a problem. Status Code:
              ${response.status}. Message: ${responseJson && responseJson.message} `
      );
    });

    return;
  }

  let userData = await response.json();
  buildUserCard(userData);

  console.log('done');
}

function newFunction() {
  const userCard = document.getElementById('usercard');
  const statusIndicator = document.getElementById('statusIndicator');
  userCard.innerHTML = '';
  userCard.classList.remove('visible');
  statusIndicator.classList.add('spin');
  return userCard;
}

function buildUserCard(statusIndicator) {
  const userCard = document.getElementById('usercard');
  const statusIndicator = document.getElementById('statusIndicator');
  statusIndicator.classList.remove('spin');
  userCard.classList.add('visible');
  const userName = document.createElement('h2');
  userName.innerText = userData.login;
  const homepageUrl = document.createElement('a');
  homepageUrl.text = userData.blog;
  homepageUrl.href = userData.blog;
  homepageUrl.style = 'display:block';
  const avatar = document.createElement('img');
  avatar.src = userData.avatar_url;
  avatar.height = 200;
  avatar.width = 200;
  userCard.appendChild(userName);
  userCard.appendChild(homepageUrl);
  userCard.appendChild(avatar);
}
