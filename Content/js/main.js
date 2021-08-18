
var openwindows = document.getElementById('openwindows');
openwindows.addEventListener('click', function () {
 let submenu = document.getElementById('submenu');
 let headarriba = document.getElementById('headarriba');
 submenu.classList.remove("cerrar");
 submenu.classList.add("abrir");
 headarriba.style.width="78%";
 headarriba.style.right="0%"
});


var closewindow = document.getElementById('closewindow');
closewindow.addEventListener('click', function () {
 let submenu = document.getElementById('submenu');
 let headarriba = document.getElementById('headarriba');
 submenu.classList.add("cerrar");
 submenu.classList.remove("abrir");
 headarriba.style.width="100%";
 headarriba.style.transitionDuration="0.5s";
});
