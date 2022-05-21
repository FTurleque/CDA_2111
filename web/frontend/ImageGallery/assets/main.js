const displayedImage = document.querySelector('.displayed-img');
const thumbBar = document.querySelector('.thumb-bar');

const btn = document.querySelector('button');
const overlay = document.querySelector('.overlay');

/* Declaring the array of image filenames */

/* Looping through images */
let pics=[];
for(var i=1;i<6;i++){
    const newImage = document.createElement('img');
    newImage.onload=function(){
        pics.push(this);
    }

    newImage.setAttribute('src', `./assets/images/pic${i}.jpg`);
    thumbBar.appendChild(newImage);
}

// const newImage = document.createElement('img');
// newImage.setAttribute('src', './assets/images/pic'+i+'.jpg');
// thumbBar.appendChild(newImage);

/* Wiring up the Darken/Lighten button */
