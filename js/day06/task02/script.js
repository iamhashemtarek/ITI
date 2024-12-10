
document.getElementById('registerBtn').addEventListener('click', () => {
    const username = document.getElementById('name').value;
    const age = document.getElementById('age').value;
    const selectedGender = document.querySelector('input[name="gender"]:checked')?.value;    
    
    const img = selectedGender == 'male' ? './images/1.jpg' : './images/2.jpg';
    
    
    const myWindow =  window.open('./details.html', '_self')
    myWindow.document.write(
        `        
        <!DOCTYPE html>
        <html lang="en">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <title>User Details</title>
        </head>
        <body>
            <img src="${img}" alt="User Avatar" />
            <p id="info">Loading visits...</p>
             <script>
                const getCookie = (name) => {
                    const cookies = document.cookie.split('; ');
                    for (const cookie of cookies) {
                        const [key, value] = cookie.split('=');
                        if (key === name) {
                            return parseInt(value, 10) || 0;
                        }
                    }
                    return 0;
                };

                let visits = getCookie('visits') || 0;
                visits++;
                document.cookie = \`visits=\${visits}; path=/\`;

                // Update the page with the visit count
                document.getElementById('info').innerText = 
                    'Welcome ${username}, you have visited this page ' + visits + ' times.';
            </script>
        </body>
        </html>
        `
    )
});


