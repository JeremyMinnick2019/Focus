import apiActions from "../api/apiActions"
import Activity from "./activity"

export default () => {
    displayHome()
}

function displayHome(){
    const app = document.querySelector("#app");
    const sign = document.querySelector("#sign")
    sign.innerHTML = ``
    apiActions.getRequest(`https://localhost:44306/api/activities/suggest`, activities =>{
    app.innerHTML = Activity(activities);
    });
}