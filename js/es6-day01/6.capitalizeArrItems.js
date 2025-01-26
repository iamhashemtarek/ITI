const fruits = ["apple", "strawberry", "banana", "orange", "mango"]
    
const capitalizedArr = fruits.map(item => item[0].toUpperCase().concat(item.slice(1)));

console.log("capitalized arr :", capitalizedArr);
