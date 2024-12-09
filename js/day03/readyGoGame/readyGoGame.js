const circles = document.getElementsByClassName('circle')
const ready = circles[0];
const steady = circles[1];
const go = circles[2];

const userInput = document.getElementById('inBox');

userInput.addEventListener('input', () => {
    if(userInput.value == 1) {
        ready.classList.add('active')
        steady.classList.remove('active')
        go.classList.remove('active')
    }
    else if (userInput.value == 2){
        ready.classList.remove('active')
        steady.classList.add('active')
        go.classList.remove('active')
    } 
    else if(userInput.value == 3){
        ready.classList.remove('active')
        steady.classList.remove('active')
        go.classList.add('active')
    }else {
        ready.classList.remove('active')
        steady.classList.remove('active')
        go.classList.remove('active')
    }
})