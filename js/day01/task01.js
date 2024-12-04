const userInput = prompt('enter a string')

for(let i = 0; i<6; i++) {
    document.writeln(`<h${i+1}>${userInput}</h${i+1}>`);
    
}