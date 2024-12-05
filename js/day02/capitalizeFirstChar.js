const capitalizeFirstChar = str => {
    let capitalizedStr = str.split(' ').map(elem => elem[0].toUpperCase()+elem.slice(1)).join(' ')
    console.log(`output: ${capitalizedStr}`)
}

capitalizeFirstChar('hello world')