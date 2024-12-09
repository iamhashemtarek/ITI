const marbles = document.getElementsByClassName('marble');
const marblesContainer = document.getElementsByClassName('marbles')[0];

let currentIndex = 0;
let intervalId = null;

function start() {
    intervalId = setInterval(() => {
        marbles[currentIndex].classList.remove('active')
    
        currentIndex = (currentIndex+1) % marbles.length
    
        marbles[currentIndex].classList.add('active')
    }, 500);
}

function stop() {
    clearInterval(intervalId); 
    intervalId = null;
}

marblesContainer.addEventListener('mouseleave', start )
marblesContainer.addEventListener('mouseenter', stop)

