import Business from "./components/business"
import businessEdit from "./components/businessEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayBusiness()
}

function displayBusiness(){
    const businessBTN = document.querySelector("#businessButton");
    businessBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/businesses", businesses =>{
            document.querySelector("#app").innerHTML = Business(businesses);
        })
    })
}