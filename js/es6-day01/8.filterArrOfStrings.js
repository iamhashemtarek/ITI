const filterArrOfStrings = (arr, length) => arr.filter(item => item.length > length);

const arr = ['aaa', 'bbbb', 'ccccc', 'dd'];

const result = filterArrOfStrings(arr, 3);

console.log("filtered arr:", result);
