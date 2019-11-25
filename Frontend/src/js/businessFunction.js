import Business from "./components/business"
import businessEdit from "./components/businessEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayBusiness()
}

function displayBusiness(){
    const businessBTN = document.querySelector("#profileButton");
    const app = document.querySelector("#app");
    businessBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/businesses", businesses =>{
            app.innerHTML = Business(businesses);
        })
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("businessName")){
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}`, businesses => {
            app.innerHTML = Business(businesses);
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
            app.innerHTML = Business(businesses)
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
                app.innerHTML = Business(businesses)
            }
        )
    }
})
}