import Success from "./components/success"
import Header from "./components/header"
import apiActions from "./api/apiActions"

export default () =>{
    displaySuccess();
    displayHeader();
}

function displayHeader(){
    const successBTN = document.querySelector("#successButton");
    const head = document.querySelector("#header");
    successBTN.addEventListener("click", function(){
            head.innerHTML = Header();
        })
}

function displaySuccess(){
    const successBTN = document.querySelector("#successButton");
    const app = document.querySelector("#app");
    const sign = document.querySelector("#sign")
    successBTN.addEventListener("click", function(){
        sign.innerHTML = ``
        apiActions.getRequest(`https://localhost:44306/api/activities/done`, activities =>{
        app.innerHTML = Success(activities)
        });
    })
}