import apiActions from "../api/apiActions"
import Activity from "./activity"
export default () => {
    displayHome()}

    function displayHome(){
        // const activityBTN = document.querySelector("#homeButton");
        const app = document.querySelector("#app");
        // activityBTN.addEventListener("click", function(){
            const sign = document.querySelector("#sign")
            sign.innerHTML = ``
            apiActions.getRequest(`https://localhost:44306/api/activities/suggested`, activities =>{
                app.innerHTML = Activity(activities);
            });
        // });
}