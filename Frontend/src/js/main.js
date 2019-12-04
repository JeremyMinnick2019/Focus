import displayProfile from "./profile"
import displayCategory from "./categoryFunction"
import displayActivity from "./activityFunction"
import displaySuccess from "./successFunction"
import Header from "./components/header"
import Footer from "./components/footer"
import Navbar from "./components/navbar"
import displayHome from "./components/home"
import displayBar from "./components/progressbar"
import ConfettiGenerator from "confetti-js"


export default () => {
    pageBuild();
}

function pageBuild(){
    header();
    navbar();
    footer();
    home();
    homeAction();
    profileAction();
    successAction();
    categoryAction();
    activityAction();
    barAction();
    confetti();
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()
}

function navbar(){
    const navbar = document.getElementById("navbar")
    navbar.innerHTML = Navbar()
}

function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer()
}

function home(){
    const head = document.querySelector("#header");
    const landing = document.querySelector("#app");
    const belts = document.querySelector("#belt")
    const available = document.querySelector("#available");
    head.innerHTML = Header();
    belts.innerHTML = ``;
    available.innerHTML = ``;
    landing.innerHTML = displayHome();
}

function homeAction(){
    const homeBTN = document.querySelector("#homeButton");
    const sign = document.querySelector("#sign")
    const head = document.querySelector("#header");
    const landing = document.querySelector("#app");
    const total = document.querySelector("#points")
    const available = document.querySelector("#available");
    const belts = document.querySelector("#belt");
    homeBTN.addEventListener("click", function(){
        head.innerHTML = Header();
        sign.innerHTML = ``;
        total.innerHTML = ``;
        available.innerHTML = ``;
        belts.innerHTML = ``;
        landing.innerHTML = displayHome();    
    })
}
function barAction(){
    displayBar();
}
function profileAction(){
    displayProfile();
}

function successAction(){
    displaySuccess()
}

function categoryAction(){
    displayCategory()
}

function activityAction(){
    displayActivity()
}
