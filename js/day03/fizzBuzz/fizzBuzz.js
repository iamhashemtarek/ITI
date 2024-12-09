const numberInput = document.getElementById('num');
const sentence = document.getElementById('sentence');
sentence.value='none'

numberInput.addEventListener('input', () => {
    const num = numberInput.value;

    if(num%3==0 && num%5==0 && num != 0) 
        sentence.value='fizz buzz'
    else if(num%5==0)
        sentence.value='buzz'
    else if(num%3==0)
        sentence.value='fizz'
    else
        sentence.value = 'none';
})