const setColor = (element) => {
  element.setAttribute("style", "background-color: rgb(238, 150, 24); color: rgb(0,0,0); text-shadow: none;");
}

const date = new Date();
var day;
switch(date.getDay()) {
  case 0:
    day = "weekend";
    break;
  case 1:
    day = "monday";
    break;
  case 2:
    day = "tuesday";
    break;
  case 3:
    day = "wednesday";
    break;
  case 4:
    day = "thursday";
    break;
  case 5:
    day = "friday";
    break;
  case 6:
    day = "weekend";
    break;
  default:
      console.log("jrwkgb?")
}

setColor(document.getElementById(day));

const showInfo = () => {
  Swal.fire({
    title: '<span class="swalert-title">Informace o stránce</span>',
    html: '<div class="swalert-text">1. Stránka není oficiální stránkou produktu a neslouží jako jeho reklama. <br> 2. Tesla Tequila slouží jako předmět pro tvorbu ukázkové stránky pomocí WebSlides <br> 3. Stránka nesbírá žádná data, používá fonty třetích stran, pro vyskakovací okna používá Sweet alert a pro ikonky Font awesome.</div>',
    width: "50rem"
  })
}