// 2) Using rest parameter and spread operator return max value from any array
// note: array length is not fixed return min and max value and display each of
// them separately after function call

let getMinAndMax = (arr) => {
    let min = Math.min(...arr);
    let max = Math.max(...arr);
    return {min, max};
};

let {min, max} = getMinAndMax([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);

console.log('min', min)
console.log('max', max)
