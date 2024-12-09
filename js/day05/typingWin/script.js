const m = 'hashem tarek 24 years old faculty of electronic engineering menofia university'

const showMsgBtn = document.getElementById('showMsg');

showMsgBtn.addEventListener('click', () => {
    
    const messageWindow = window.open('./message.html', '_blank', 'width=500, height=150, top=200, left=50');
    
    messageWindow.addEventListener('load', () => {
        const messageContainer = messageWindow.document.getElementsByClassName('messageContainer')[0];
        let idx = 0;
        const intervalId = setInterval(() => {
            messageContainer.textContent += m[idx++];
            
            if(idx == m.length){
                clearInterval(intervalId)
                setTimeout(() => messageWindow.close(), 500)
            }
        }, 80)
    })
})