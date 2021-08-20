var homewindow = document.getElementById('homewindow');
var submenu = document.getElementById('submenu');
var headarriba = document.getElementById('headarriba');
var submenudos = document.getElementById('submenudos');
var openwindows = document.getElementById('openwindows');
var closewindow = document.getElementById('closewindow');



homewindow.addEventListener('click', function(){
    submenudos.classList.add("cerrar");
    submenudos.classList.remove("abrir");
    submenu.classList.remove("abrir");
    submenu.classList.add("cerrar");
    submenusiete.classList.add("cerrar");
    submenusiete.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    headarriba.style.width="96%";
    headarriba.style.transitionDuration="0.5s";

});

//compras no tiene menu
var openwindowcuatro = document.getElementById('openwindowcuatro');
openwindowcuatro.addEventListener('click', function(){
    submenudos.classList.add("cerrar");
    submenudos.classList.remove("abrir");
    submenu.classList.remove("abrir");
    submenu.classList.add("cerrar");
    submenusiete.classList.add("cerrar");
    submenusiete.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    headarriba.style.width="96%";
    headarriba.style.transitionDuration="0.5s";

});

//proveedor no tiene menu openwindowscinco

var openwindowscinco = document.getElementById('openwindowscinco');
openwindowscinco.addEventListener('click', function(){
    submenudos.classList.add("cerrar");
    submenudos.classList.remove("abrir");
    submenu.classList.remove("abrir");
    submenu.classList.add("cerrar");
    submenusiete.classList.add("cerrar");
    submenusiete.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    headarriba.style.width="96%";
    headarriba.style.transitionDuration="0.5s";

});

//Clientes no tiene menu 

var openwindowsseis = document.getElementById('openwindowsseis');
openwindowsseis.addEventListener('click', function(){
    submenudos.classList.add("cerrar");
    submenudos.classList.remove("abrir");
    submenu.classList.remove("abrir");
    submenu.classList.add("cerrar");
    submenusiete.classList.add("cerrar");
    submenusiete.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");
    headarriba.style.width="96%";
    headarriba.style.transitionDuration="0.5s";

});
 
//Empleado no tiene menu 
var openwindowsseis = document.getElementById('openwindowsseis');
openwindowsseis.addEventListener('click', function(){
    submenudos.classList.add("cerrar");
    submenudos.classList.remove("abrir");
    submenu.classList.remove("abrir");
    submenu.classList.add("cerrar");

    submenusiete.classList.add("cerrar");
    submenusiete.classList.remove("abrir");
    submenuocho.classList.add("cerrar");
    submenuocho.classList.remove("abrir");

    submenunueve.classList.add("cerrar");
    submenunueve.classList.remove("abrir");
    headarriba.style.width="96%";
    headarriba.style.transitionDuration="0.5s";
});   

// var openwindowscinco = document.getElementById('openwindowscinco');
// openwindowscinco.addEventListener('click', function(){
//     submenudos.classList.add("cerrar");
//     submenudos.classList.remove("abrir");
//     submenu.classList.remove("abrir");
//     submenu.classList.add("cerrar");
//     headarriba.style.width="100%";
//     headarriba.style.transitionDuration="0.5s";
// });



//ventas
openwindows.addEventListener('click', function () {
 submenudos.classList.add("cerrar");
 submenudos.classList.remove("abrir");
 submenu.classList.remove("cerrar");
 submenu.classList.add("abrir");
 submenuocho.classList.add("cerrar");
 submenuocho.classList.remove("abrir");
 submenusiete.classList.add("cerrar");
 submenusiete.classList.remove("abrir");
 submenunueve.classList.add("cerrar");
submenunueve.classList.remove("abrir");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});



closewindow.addEventListener('click', function () {
 var submenu = document.getElementById('submenu');
 var headarriba = document.getElementById('headarriba');
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 headarriba.style.width="96%";
 headarriba.style.transitionDuration="0.5s";
});




//inventario con menu
var openwindowsDos = document.getElementById('openwindowsdos');
openwindowsDos.addEventListener('click', function () {
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 submenudos.classList.remove("cerrar");
 submenudos.classList.add("abrir");
 submenuocho.classList.add("cerrar");
 submenuocho.classList.remove("abrir");
 submenunueve.classList.add("cerrar");
submenunueve.classList.remove("abrir");
 submenusiete.classList.add("cerrar");
 submenusiete.classList.remove("abrir");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});


var closewindowdos = document.getElementById('closewindowdos');
closewindowdos.addEventListener('click', function () {
 let submenudos = document.getElementById('submenudos');
 let headarriba = document.getElementById('headarriba');
 submenudos.classList.add("cerrar");
 submenudos.classList.remove("abrir");
 headarriba.style.width="96%";
 headarriba.style.transitionDuration="0.5s";
});



//Menu empleaddo
var openwindowssiete = document.getElementById('openwindowssiete');
openwindowssiete.addEventListener('click', function () {
 var submenusiete = document.getElementById('submenusiete');
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 submenudos.classList.add("cerrar");
 submenudos.classList.remove("abrir");
 submenuocho.classList.add("cerrar");
submenuocho.classList.remove("abrir");
submenunueve.classList.add("cerrar");
submenunueve.classList.remove("abrir");
 submenusiete.classList.add("abrir");
 submenusiete.classList.remove("cerrar");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});

var closewindowsiete = document.getElementById('closewindowsiete');
closewindowsiete.addEventListener('click', function () {
 submenusiete.classList.add("cerrar");
 submenusiete.classList.remove("abrir");
 headarriba.style.width="96%";
 headarriba.style.transitionDuration="0.5s";
});


//Menu Reporte
var openwindowsocho = document.getElementById('openwindowsocho');
openwindowsocho.addEventListener('click', function () {
 var submenuocho = document.getElementById('submenuocho');
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 submenudos.classList.add("cerrar");
 submenudos.classList.remove("abrir");
 submenusiete.classList.add("cerrar");
 submenusiete.classList.remove("abrir");
 submenunueve.classList.add("cerrar");
 submenunueve.classList.remove("abrir");
 submenuocho.classList.remove("cerrar");
 submenuocho.classList.add("abrir");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});

var closewindowocho = document.getElementById('closewindowocho');
closewindowocho.addEventListener('click', function () {
submenuocho.classList.add("cerrar");
submenuocho.classList.remove("abrir");
 headarriba.style.width="96%";
 headarriba.style.transitionDuration="0.5s";
});

//Configuracion
var openwindowsnueve = document.getElementById('openwindowsnueve');
openwindowsnueve.addEventListener('click', function () {
 var submenunueve = document.getElementById('submenunueve');
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 submenudos.classList.add("cerrar");
 submenudos.classList.remove("abrir");
 submenusiete.classList.add("cerrar");
 submenusiete.classList.remove("abrir");
 submenuocho.classList.remove("abrir");
 submenuocho.classList.add("cerrar");
 submenunueve.classList.remove("cerrar");
 submenunueve.classList.add("abrir");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});

var closewindownueve = document.getElementById('closewindownueve');
closewindownueve.addEventListener('click', function () {
submenunueve.classList.add("cerrar");
submenunueve.classList.remove("abrir");
 headarriba.style.width="96%";
 headarriba.style.transitionDuration="0.5s";
});


// Menu Hover
//Home
var animationhover = document.getElementById('animationhover');
animationhover.addEventListener('mouseover', function (){
    liunohover.style.display="block";
    liunohover.style.opacity=" 1";
    submenudos.classList.add("cerrarhover");
});
animationhover.addEventListener('mouseout', function (){
    liunohover.style.display="none";
    liunohover.style.opacity=" 0.1";
});

//ventas
var animationhoverdos = document.getElementById('animationhoverdos');
animationhoverdos.addEventListener('mouseover', function (){
    liunohoverdos.style.display="block";
    liunohoverdos.style.opacity=" 1";
    submenudos.classList.add("cerrarhover");
});
animationhoverdos.addEventListener('mouseout', function (){
    liunohoverdos.style.display="none";
    liunohoverdos.style.opacity=" 0.1";
});

//inventario
var animationhovertres = document.getElementById('animationhovertres');
animationhovertres.addEventListener('mouseover', function (){
    liunohovertres.style.display="block";
    liunohovertres.style.opacity=" 1";
    submenudos.classList.add("cerrarhover");

});
animationhovertres.addEventListener('mouseout', function (){
    liunohovertres.style.display="none";
    liunohovertres.style.opacity=" 0.1";
});
 //compras


var animationhovercuatro = document.getElementById('animationhovercuatro');
animationhovercuatro.addEventListener('mouseover', function (){
    liunohovercuatro.style.display="block";
    liunohovercuatro.style.opacity=" 1";
    liunohovercuatro.classList.add("cerrarhover");

});
animationhovercuatro.addEventListener('mouseout', function (){
    liunohovercuatro.style.display="none";
    liunohovercuatro.style.opacity=" 0.1";
});

//proveedor
var animationhovercinco = document.getElementById('animationhovercinco');
animationhovercinco.addEventListener('mouseover', function (){
    liunohovercinco.style.display="block";
    liunohovercinco.style.opacity=" 1";
    liunohovercinco.classList.add("cerrarhover");

});
animationhovercinco.addEventListener('mouseout', function (){
    liunohovercinco.style.display="none";
    liunohovercinco.style.opacity=" 0.1";
});

//Cliente
var animationhoverseis = document.getElementById('animationhoverseis');
animationhoverseis.addEventListener('mouseover', function (){
    liunohoverseis.style.display="block";
    liunohoverseis.style.opacity=" 1";
    liunohoverseis.classList.add("cerrarhover");

});
animationhoverseis.addEventListener('mouseout', function (){
    liunohoverseis.style.display="none";
    liunohoverseis.style.opacity=" 0.1";
});

//usuario
var animationhoversiete = document.getElementById('animationhoversiete');
animationhoversiete.addEventListener('mouseover', function (){
    liunohoversiete.style.display="block";
    liunohoversiete.style.opacity=" 1";
    liunohoversiete.classList.add("cerrarhover");

});
animationhoversiete.addEventListener('mouseout', function (){
    liunohoversiete.style.display="none";
    liunohoversiete.style.opacity=" 0.1";
});


//reporte
var animationhoverocho = document.getElementById('animationhoverocho');
animationhoverocho.addEventListener('mouseover', function (){
    liunohoverocho.style.display="block";
    liunohoverocho.style.opacity=" 1";
    liunohoverocho.classList.add("cerrarhover");

});
animationhoverocho.addEventListener('mouseout', function (){
    liunohoverocho.style.display="none";
    liunohoverocho.style.opacity=" 0.1";
});

//Configuracion 
var animationhovernueve = document.getElementById('animationhovernueve');
animationhovernueve.addEventListener('mouseover', function (){
    liunohovernueve.style.display="block";
    liunohovernueve.style.opacity=" 1";
    liunohovernueve.classList.add("cerrarhover");

});
animationhovernueve.addEventListener('mouseout', function (){
    liunohovernueve.style.display="none";
    liunohovernueve.style.opacity=" 0.1";
});



//menu latera

var logincircle = document.getElementById('logincircle');
logincircle.addEventListener('click',function(){
    var windowsuserlogin = document.getElementById('windowsuserlogin');
    windowsuserlogin.classList.remove("closeuserlogin");
    windowsuserlogin.classList.add("openuserlogin");  
});

var iconcross = document.getElementById('iconcross');
iconcross.addEventListener('click',function(){
    windowsuserlogin.classList.add("closeuserlogin"); 
    windowsuserlogin.classList.remove("openuserlogin");
});