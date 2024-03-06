let salaries = {
  John: 100,
  Ann: 160,
  Pete: 130,
};

let sum = Object.values(salaries).reduce((acc, curr) => acc + curr);

console.log(sum); // Output: 390
