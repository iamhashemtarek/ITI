
let memo = {1:1}  
let memoizedFactorial = (num) => {

    if(memo[num])
        return memo[num]

    let lastCached = Math.max(...Object.keys(memo).map(Number));

    for(let i = lastCached+1; i<= num; i++) {
        memo[i] = i * memo[i-1]
    }

    return memo[num]
}

console.log(memoizedFactorial(1))
console.log(memoizedFactorial(2))
console.log(memoizedFactorial(3))

