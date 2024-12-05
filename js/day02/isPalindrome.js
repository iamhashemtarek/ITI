let str = prompt("enter a string")
const isCaseSensitive = prompt(`
    should i consider case of entered string?
    (y/n)`);

const isPalindrome = str => {
    const reversedStr = str.split('').reverse().join('');
    console.log(reversedStr);
    
    return str == reversedStr 
}

str = isCaseSensitive == 'n' ? str.toLocaleLowerCase() : str;

if(isPalindrome(str))
    document.writeln('<h1>the string is palindrome </h1>')
else
    document.writeln('<h1>the string is <span style="color:red">not</span> palindrome </h1>')

//RADAR
//raDaR