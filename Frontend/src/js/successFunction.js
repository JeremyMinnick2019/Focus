import Success from "./components/success"
import apiActions from "./api/apiActions"

export default () =>{
    displaySuccess()
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