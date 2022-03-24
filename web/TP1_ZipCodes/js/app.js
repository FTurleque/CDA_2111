const CITIES_URL = 'https://raw.githubusercontent.com/ARFP/TP_WEB/serie_1/frontend-js/TP1_ZipCodes/zipcodes.json';
const city_name = document.querySelector('#city_name').addEventListener('input', 

);

function getCityInfo() {
    fetch(CITIES_URL)
        .then(response => response.json())
        .then(data => {
            console.log(data);

            
        })
}

let createUlWithClass = function(className) {
    let ul = document.createElement('ul');
    ul.setAttribute('class', className);
    return ul;
}

let createLiWithClass = function(className) {
    let li = document.createElement('li');
    li.setAttribute('class', className);
    return li;
}

let createOptionWithValue = function(value) {
    let option = document.createElement('option');
    option.setAttribute('value=', value);
    return option;
}
