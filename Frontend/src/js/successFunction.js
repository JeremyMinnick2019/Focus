import Success from "./components/success"
import apiActions from "./api/apiActions"

export default () =>{
    displaySuccess()
}

function displaySuccess(){
    const successBTN = document.querySelector("#successButton");
    successBTN.addEventListener("click", function(){
        const sign = document.querySelector("#sign")
        sign.innerHTML = ``
        apiActions.getRequest("https://localhost:44306/api/activities", activities =>{
            document.querySelector("#app").innerHTML = Success(activities);
        })
    });
}