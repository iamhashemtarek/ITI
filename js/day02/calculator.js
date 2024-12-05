const userInput = prompt('enter 3 numbers sperated by a space');
const arr = userInput.split(' ');

const add = arr => {
    let numericArr = arr.map(elem => Number(elem))
    return numericArr.reduce((acc, elem) => acc+= elem)
}

const multiply = arr => {
    return arr.reduce((acc, elem) => acc*=elem, 1)
}


const divide = arr => {
    return arr.slice(1).reduce((acc, elem) => acc/=elem, arr[0])
}

document.writeln('<h1>Adding - Multiplying - and dividing 3 valuse</h1>')
document.writeln('<br>')
document.writeln(`<h2>sum ${arr[0]} + ${arr[1]} + ${arr[2]} = ${add(arr)}</h2>`)
document.writeln(`<h2>multiplication ${arr[0]} * ${arr[1]} * ${arr[2]} = ${multiply(arr)}</h2>`)
document.writeln(`<h2>division ${arr[0]} / ${arr[1]} / ${arr[2]} = ${divide(arr)}</h2>`)