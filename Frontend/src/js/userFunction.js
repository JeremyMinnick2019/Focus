import User from "./components/user"
import userEdit from "./components/userEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayUser()
}

function displayUser(){
    const userBTN = document.querySelector("#userButton");
    userBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/users", users =>{
            document.querySelector("#app").innerHTML = User(users);
        })
    })
}