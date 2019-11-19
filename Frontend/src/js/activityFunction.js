import Activity from "./components/activity"
import activityEdit from "./components/activityEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayActivity()
}

function displayActivity(){
    const activityBTN = document.querySelector("#activityButton");
    activityBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/activities", activities =>{
            document.querySelector("#app").innerHTML = Activity(activities);
        })
    })
}