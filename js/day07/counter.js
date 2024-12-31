let counter = () => {
    let cntr = 0;
    return () => cntr++
}

let myCounter = counter();

console.log(myCounter());
console.log(myCounter());
console.log(myCounter());
console.log(myCounter());


