const mary = {
  name: "Mary Carter",
  gender: "Female",
  superhero: false,
};

const superMary = { ...mary, superhero: true, superpower: "fly" };

console.log(mary); // {name: "Mary Carter", gender: "Female", superhero: false}
console.log(superMary); // {name: "Mary Carter", gender: "Female", superhero: true, superpower: "fly"}
console.log(superMary === mary); // false

const oneToFive = [1, 2, 3, 4, 5];
const oneToNine = [...oneToFive, 6, 7, 8, 9];

console.log(oneToFive); // [1, 2, 3, 4, 5]
console.log(oneToNine); // [1, 2, 3, 4, 5, 6, 7, 8, 9]
console.log(oneToFive === oneToNine); // false


