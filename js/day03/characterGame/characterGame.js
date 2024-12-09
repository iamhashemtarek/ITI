const strInput = document.getElementById('sBox')
const letterInput = document.getElementById('lBox')
const arrOutput = document.getElementById('aBox')

strInput.addEventListener('input',displayIndexes)
letterInput.addEventListener('input', displayIndexes)

function displayIndexes() {
    const str = strInput.value;
    const letter = letterInput.value;
    const arrOfIndexes = []

    for(let i=0; i<str.length; i++) {
        if(str[i] == letter)
            arrOfIndexes.push(i)
    }

    arrOutput.value = arrOfIndexes.length>0 ? arrOfIndexes : 'no matches found'
}
