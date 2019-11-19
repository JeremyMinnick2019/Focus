import displayUser from "./userFunction"
import displayBusiness from "./businessFunction"
import displayCategory from "./categoryFunction"
import displayActivity from "./activityFunction"
import Header from "./components/header"
import Footer from "./components/footer"
import Navbar from "./components/navbar"


export default () => {
    pageBuild();
}

function pageBuild(){
    userAction();
    businessAction();
    categoryAction();
    activityAction();
    header();
    navbar();
    footer();
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