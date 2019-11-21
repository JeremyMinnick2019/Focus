import Success from "./components/success"
import apiActions from "./api/apiActions"

export default () =>{
    displaySuccess()
}

function displaySuccess(){
    const successBTN = document.querySelector("#successButton");
    const app = document.querySelector("#app");
    successBTN.addEventListener("click", function(){
        const sign = document.querySelector("#sign")
        sign.innerHTML = ``
        apiActions.getRequest(`https://localhost:44306/api/activities/`, activity =>{
        app.innerHTML = Success(activity)});
            // console.log(activity)
        })
}