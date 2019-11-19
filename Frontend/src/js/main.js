import displayUser from "./userFunction"
import displayBusiness from "./businessFunction"
import displayCategory from "./categoryFunction"
import displayActivity from "./activityFunction"
import Header from "./components/header"
import Footer from "./components/footer"
import Navbar from "./components/navbar"
import Home from "./components/home"



export default () => {
    pageBuild();
}

function pageBuild(){
    header();
    navbar();
    footer();
    home();
    userAction();
    businessAction();
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
    landing.innerHTML = Home()
    const homeBTN = document.querySelector("#homeButton");
    homeBTN.addEventListener("click", function(){
    document.querySelector("#app").innerHTML = Home();    
    })
}

function userAction(){
    displayUser()
}

function businessAction(){
    displayBusiness()
}

function categoryAction(){
    displayCategory()
}

function activityAction(){
    displayActivity()
}