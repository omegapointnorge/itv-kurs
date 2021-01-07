function getUser() {
  const username = document.getElementById("username-input").value;

  const userCard = document.getElementById("usercard");
  const statusIndicator = document.getElementById("statusIndicator");
  userCard.textContent = "";

  userCard.classList.remove("visible");
  statusIndicator.classList.add("spin");

  fetch(`https://api.github.com/users/${username}`)
    .then((response) => {
      statusIndicator.classList.remove("spin");
      userCard.classList.add("visible");

      if (response.status === 404) {
        userCard.textContent = `Unable to find user: ${username}`;
        return;
      }
      if (response.status !== 200) {
        response.json().then(function (responseJson) {
          userCard.textContent(
            `Looks like there was a problem. Status Code:  ${response.status}. Message: ${
              responseJson && responseJson.message
            } `
          );
        });

        return;
      }

      response.json().then(function (userData) {
        const userName = document.createElement("h2");
        userName.textContent = userData.login;

        const homepageUrl = document.createElement("a");
        homepageUrl.text = userData.blog;
        homepageUrl.href = userData.blog;
        homepageUrl.style = "display:block";

        const avatar = document.createElement("img");
        avatar.src = userData.avatar_url;
        avatar.height = 200;
        avatar.width = 200;

        userCard.append(userName, homepageUrl, avatar);
      });
    })
    .catch(() => statusIndicator.classList.remove("spin"));
}
