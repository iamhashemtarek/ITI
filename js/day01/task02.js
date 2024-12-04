let sum = 0;
let flag = true;

while (true) {
    const userInput = Number(prompt("enter a number"));

    if(userInput === 0)
        break;

    sum += userInput;

    if(sum > 100) 
        break;
}

document.writeln(`<h2>sum = ${sum}</h2>`);