import displayProfile from "./profile"
import displayCategory from "./categoryFunction"
import displayActivity from "./activityFunction"
import displaySuccess from "./successFunction"
import Header from "./components/header"
import Footer from "./components/footer"
import Navbar from "./components/navbar"
import displayHome from "./components/home"




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
    const landing = document.querySelector("#app");
    const sign = document.querySelector("#sign")
    landing.innerHTML = displayHome()
    sign.innerHTML = ``
}

function homeAction(){
    const homeBTN = document.querySelector("#homeButton");
    const sign = document.querySelector("#sign")
    const landing = document.querySelector("#app");
    homeBTN.addEventListener("click", function(){
        landing.innerHTML = displayHome();    
    sign.innerHTML = ``
    })
}

function profileAction(){
    displayProfile()
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