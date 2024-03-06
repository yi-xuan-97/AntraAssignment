let styles = ["James", "Brennie"];

// Append "Robert" to the end
styles.push("Robert");
console.log(styles.join(', ')); // James, Brennie, Robert

// Replace the value in the middle by "Calvin"
let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";
console.log(styles.join(', ')); // James, Calvin, Robert

// Remove the first value of the array and show it
let removed = styles.shift();
console.log(removed); // James
console.log(styles.join(', ')); // Calvin, Robert

// Prepend "Rose" and "Regal" to the array
styles.unshift("Rose", "Regal");
console.log(styles.join(', ')); // Rose, Regal, Calvin, Robert
