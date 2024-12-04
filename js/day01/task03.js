const userInput = prompt("enter a string");

let count = 0;
for(let char of userInput) {
    if (char === 'e')
        count++;
}
document.writeln(`<h2>count = ${count}</h2>`);