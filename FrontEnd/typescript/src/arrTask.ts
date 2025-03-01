// -- define an array with string and number values only
// -- write a function that accept an array of numbers or string
//     - if all values are numbers -- return the sum
//     - if all values are string -- return all values as a one string 
//     --if all values string or numbers -- return numbers only and sort them


const arr: (string | number)[] = [1, 2, 3, 'a', 'b', 'c'];
const funcAcceptStringOrNumber = (arr: (string | number)[]): number | string | number[] => {
    const isAllNumbers = arr.every((el) => typeof el === 'number');
    const isAllStrings = arr.every((el) => typeof el === 'string');
    if (isAllNumbers) {
        return arr.reduce((acc, el) => acc + Number(el), 0);
    } else if (isAllStrings) {
        return arr.join('');
    } else {
        return arr.filter((el) => typeof el === 'number').sort((a, b) => Number(a) - Number(b));
    }
}
