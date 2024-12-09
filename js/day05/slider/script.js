const imagesUrl = ['./images/2.JPG','./images/1.JPG', './images/3.jpg']

const prevBtn = document.getElementsByClassName('prev')[0];
const playBtn = document.getElementsByClassName('play')[0];
const stopBtn = document.getElementsByClassName('stop')[0];
const nextBtn = document.getElementsByClassName('next')[0];

const imageContainer = document.getElementsByClassName('imageContainer')[0]

let intervalId = null
let idx = 0;
playBtn.addEventListener('click', () => {

    intervalId = setInterval(() => {
        imageContainer.style.backgroundImage = `url(${imagesUrl[idx]})`
        idx = (idx+1) % imagesUrl.length
    }, 1000)
})

stopBtn.addEventListener('click', () => {
    clearInterval(intervalId)
    intervalId = null
})
prevBtn.addEventListener('click', () => {
    idx = (idx-1+imagesUrl.length) % imagesUrl.length
    imageContainer.style.backgroundImage = `url(${imagesUrl[idx]})`
})
nextBtn.addEventListener('click', () => {
    idx = (idx+1) % imagesUrl.length
    imageContainer.style.backgroundImage = `url(${imagesUrl[idx]})`
})