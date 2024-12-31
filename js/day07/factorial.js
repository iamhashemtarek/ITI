let calcFactorial = (num) => {
    if (num <= 1)
        return 1;

    return num * calcFactorial(--num) 
}

console.log(calcFactorial(0));
