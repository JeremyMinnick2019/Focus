// import displayUser from "./userFunction"
// import displayBusiness from "./businessFunction"
import displayProfile from "./profile"
// import businessProfile from "./profile"
import displayCategory from "./categoryFunction"
import displayActivity from "./activityFunction"
import displaySuccess from "./successFunction"
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
    const sign = document.querySelector("#sign")
    sign.innerHTML = ``
    const landing = document.querySelector("#app");
    landing.innerHTML = Home()
    const homeBTN = document.querySelector("#homeButton");
    homeBTN.addEventListener("click", function(){
    sign.innerHTML = ``
    document.querySelector("#app").innerHTML = Home();    
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