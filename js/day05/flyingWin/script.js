const myWindow = window.open("myWindow.html", "_blank", "width=100, height=100, left=100,top=100");

let direction = 'down'; 

const timer = setInterval(flying, 100);

function flying() {
    if (direction === 'down') {
        myWindow.moveBy(10, 10);   
    } else {
        myWindow.moveBy(-10, -10); 
    }

    if (direction === 'down' && myWindow.screenY + myWindow.outerHeight >= window.innerHeight) {
        direction = 'up';
    }

    if (direction === 'up' && myWindow.screenY <= (window.outerHeight - window.innerHeight)) {
        direction = 'down'; 
    }
}

const btn = document.getElementById('btn')
btn.addEventListener('click', () =>{
    clearInterval(timer)
    myWindow.focus()
})

