const getSecondLowestAndHighestNum = (arr) => {
    arr.sort((a, b) => a - b)
    let newArr = arr.map(elem => {
        if (!arr.includes(elem)) {
            return elem;
        }
    })
    
    console.log(`
        second lowest: ${newArr.at(1)}//dup
        second highest: ${newArr.at(-2)}
    `)
}

getSecondLowestAndHighestNum([2,9,1,5,6,7])
