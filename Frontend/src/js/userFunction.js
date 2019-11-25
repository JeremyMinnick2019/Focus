import User from "./components/user"
import UserEdit from "./components/userEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayUser()
}

function displayUser(){
    const userBTN = document.querySelector("#profileButton");
    const app = document.querySelector("#app");
    userBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/users", users =>{
            app.innerHTML = User(users);
        })
    });

    app.addEventListener("click", function(){
        if(event.target.classList.contains("userName")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.getRequest(`https://localhost:44306/api/users/${userid}`, users =>{
                app.innerHTML = User(users);
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-user")){
        const addUser = event.target.parentElement.querySelector(".add-user_name").value;
        const addEmail = event.target.parentElement.querySelector(".add-user_email").value;
        const addPhone = event.target.parentElement.querySelector(".add-user_phone").value;
            console.log(addUser);
        apiActions.postRequest("https://localhost:44306/api/users",
        {
            name: addUser,
            email: addEmail,
            phone: addPhone
        },
        users => {
            app.innerHTML = User(users)
        })
        }
    });

    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-user")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.deleteRequest(`https://localhost:44306/api/users/${userid}`,
            users => {
                app.innerHTML = User(users);
            })
        }
    });

    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-user")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.getRequest(`https://localhost:44306/api/users/${userid}`,
            editUser => {
                app.innerHTML = UserEdit(editUser);
            })
        }
    })
    
    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-user_submit")){
            const userid = event.target.parentElement.querySelector(".update-user_id").value;
            const updateUser = event.target.parentElement.querySelector(".update-user_name").value;
            const updateEmail = event.target.parentElement.querySelector(".update-user_email").value;
            const updatePhone = event.target.parentElement.querySelector(".update-user_phone").value;
            
            const userdata = 
            {
                name: updateUser,
                email: updateEmail,
                phone: updatePhone,
                id: userid    
            }
            apiActions.putRequest(`https://localhost:44306/api/users/${userid}`,
            userdata,
            users => {
                app.innerHTML = User(users);
            })
        }
    })
}