import User from "./components/user"
import UserEdit from "./components/userEdit"
import Business from "./components/business"
import businessEdit from "./components/businessEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayUser()
    displayBusiness()
}

function displayUser(){
    const userBTN = document.querySelector("#profileButton");
    userBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/users", users =>{
            document.querySelector("#app").innerHTML = User(users);
        })
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("userName")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.getRequest(`https://localhost:44306/api/users/${userid}`, users =>{
                document.querySelector("#app").innerHTML = User(users);
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
            document.querySelector("#app").innerHTML = User(users)
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
            sign.innerHTML = ``
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
                document.querySelector("#app").innerHTML = User(users);
            })
        }
    })
}

function displayBusiness(){
    const businessBTN = document.querySelector("#profileButton");
    businessBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/businesses", businesses =>{
            document.querySelector("#sign").innerHTML = Business(businesses);
        })
    })

    const app = document.querySelector("#sign");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("businessName")){
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}`, businesses => {
            document.querySelector("#sign").innerHTML = Business(businesses);
            console.log(businesses);
        })

    }
})
app.addEventListener("click", function(){
    if(event.target.classList.contains("add-business")){
    const addName = event.target.parentElement.querySelector(".add-business_name").value;
    const addIndustry = event.target.parentElement.querySelector(".add-business_industry").value;
    const addOwner = event.target.parentElement.querySelector(".add-business_user").value;
    console.log(addName)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/businesses",{  
        name: addName,
        industry: addIndustry,
        userId: addOwner
        },

        businesses => {
            document.querySelector("#sign").innerHTML = Business(businesses)
        }
    )}
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-business")) {
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        console.log("delete" + businessId);
        apiActions.deleteRequest(`https://localhost:44306/api/businesses/${businessId}`,
        businesses => {
            app.innerHTML = Business(businesses)
        })
    }
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("edit-business")) {
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        console.log("edit"  + businessId);
        sign.innerHTML = ``
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}` , editBusiness => {
            app.innerHTML = businessEdit(editBusiness)
        })
    }
})

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-business_submit")) {
        const businessId = event.target.parentElement.querySelector(".update-business_id").value;
        const updateName = event.target.parentElement.querySelector(".update-business_name").value
        const updateindustry = event.target.parentElement.querySelector(".update-business_industry").value
        const updateOwner = event.target.parentElement.querySelector(".update-business_user").value;

        const businessData = {
            name: updateName,
            industry: updateindustry,
            id: businessId,
            userId: updateOwner
        }
        apiActions.putRequest(
            `https://localhost:44306/api/businesses/${businessId}`,
            businessData,
            businesses => {
                document.querySelector("#sign").innerHTML = Business(businesses)
            }
        )
    }
})
}