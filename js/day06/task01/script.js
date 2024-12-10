const table = document.getElementById('tbl');
/**
 * 
 * name.common
 * capital[0]
 * continents[0]
 * 
 */
const getAllCountires = () => {
    const xhr = new XMLHttpRequest()

    xhr.open('Get', "https://restcountries.com/v3.1/all", true);
    
    xhr.addEventListener('load', () => {
        const countries = JSON.parse(xhr.responseText)
        
        countries.slice(0, 20);
        for(let country of countries) {            
            const row = `
                <tr>
                    <td>${country.name.common}</td>
                    <td>${country.capital[0]}</td>
                    <td>${country.continents[0]}</td>
                </tr>
            `
            table.insertAdjacentHTML('beforeend',row)
        }
    })

    xhr.send()
}

// getAllCountires()

const getCountryByName = (name) => {
    const xhr = new XMLHttpRequest()

    xhr.open('Get', `https://restcountries.com/v3.1/name/${name}`, true);
    
    xhr.addEventListener('load', () => {
        const country = JSON.parse(xhr.responseText)[0]        
            const row = `
                <tr>
                    <td>${country.name.common}</td>
                    <td>${country.capital[0]}</td>
                    <td>${country.continents[0]}</td>
                </tr>
            `
            table.insertAdjacentHTML('beforeend',row)
    })

    xhr.send()
}
getCountryByName('deutschland')