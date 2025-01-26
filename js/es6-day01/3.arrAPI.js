// 3) Study new array api methods then create the following methods and apply it on this array 
var fruits = ["apple", "strawberry", "banana", "orange","mango"]

// a. test that every element in the given array is a string
const isEveryIsString = fruits.every(item => typeof item == "string")
console.log("is all are strings", isEveryIsString);

// b. test that some of array elements starts with "a"
const isSomeStartsWitha = fruits.some(item => item.startsWith('a'))
console.log("is some starts with a", isSomeStartsWitha);

// c. generate new array filtered from the given array with only elements that starts with "b" or "s"
const itemsStartsWithaAndb = fruits.filter(item => item.startsWith('a') || item.startsWith('s'))
console.log("fruits starts with a or s", itemsStartsWithaAndb);

// d. generate new array each element of the new array contains a string declaring that you like the give fruit element
const newArr = fruits.map(item => `i like ${item}`);

// e. use forEach to display all elements of the new array from previous point
newArr.forEach(item => console.log(item))