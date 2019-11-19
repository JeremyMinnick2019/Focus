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

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("businessName")){
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}`, businesses => {
            document.querySelector("#app").innerHTML = Business(businesses);
            console.log(businesses);
        })

    }
})
app.addEventListener("click", function(){
    const addName = event.target.parentElement.querySelector(".add-business_name").value
    const addIndustry = event.target.parentElement.querySelector(".add-business_industry").value
    console.log(addName)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/businesses",{  
        name: addName,
        industry: addIndustry
        },

        businesses => {
            document.querySelector("#app").innerHTML = Businesses(businesses)
        }
       
    )
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-business")) {
        const businessId = event.target.parentElement.querySelector("business_id").value;
        console.log("delete" + businessId);
        apiActions.deleteRequest(`https://localhost:44306/api/businesses/${businessId}`,
        businesses => {
            app.innerHTML = Business(businesses)
        })
    }
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("edit-business")) {
        const businessId = event.target.parentElement.querySelector("business_id").value;
        console.log("edit"  + businessId);
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}` , editBusiness => {
            app.innerHTML = businessEdit(editBusiness)
        })
    }
})

app.addEventListener("click", function() {
    if(event,target.classList.contains("update-business")) {
        const businessId = event.target.parentElement.querySelector("business_id").value;
        const updateName = event.target.parentElement.querySelector(".update-business_name").value
        const updateindustry = event.target.parentElement.querySelector(".update-business_industry").value

        const businessData = {
            name: updateName,
            industry: updateindustry,
            id: businessId
        }
        apiActions.putRequest(
            `https://localhost:44306/api/businesses/${businessId}`,
            businessData,
            businesses => {
                document.querySelector("#app").innerHTML = Business(businesses)
            }
        )
    }
})
}