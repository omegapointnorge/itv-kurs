const mary = {
  name: "Mary Carter",
  gender: "Female",
  superhero: false,
};

const { name: fullName, gender, superhero } = mary;

console.log(fullName); // "Mary Carter"
console.log(gender); // "Female"
console.log(superhero); // false

const oneToFive = [1, 2, 3, 4, 5];

const [one] = oneToFive;
console.log(one); // 1

const [, two, three] = oneToFive;
console.log(two); // 2
console.log(three); // 3

const [, ...rest] = oneToFive;
console.log(rest); // [2,3,4,5]

const [...copy] = oneToFive;
console.log(copy); // [1,2,3,4,5]


