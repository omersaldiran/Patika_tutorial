let isim = prompt("İsminizi giriniz :")
document.querySelector("#info").innerHTML=isim;

const clock = new Date();
document.querySelector("#clock").innerHTML=clock.toDateString("tr-TR");