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
        if(event.target.classList.contains("businessTitle")){
        const businessId = event.target.parentElement.querySelector(".business_id").value;
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}`, businesses => {
            document.querySelector("#app").innerHTML = Business(businesses);
            console.log(businesses);
        })

    }
})
app.addEventListener("click", function(){
    const addTitle = event.target.parentElement.querySelector(".add-business_title").value
    const addIndustry = event.target.parentElement.querySelector(".add-business_industry").value
    console.log(addTitle)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/businesses",{  
        title: addTitle,
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
        apiActions.getRequest(`https://localhost:44306/api/businesses/${businessId}` , businesses => {
            app.innerHTML = Business(businesses)
        })
    }
})

app.addEventListener("click", function() {
    if(event,target.classList.contains(update-business)) {
        const updateTitle = event.target.parentElement.querySelector(".update-business_title").value
        const updateindustry = event.target.parentElement.querySelector(".update-business_industry").value

        const businessData = {
            title: updateTitle,
            industry: updateindustry
        }
        apiActions.putRequest(
            `https://localhost:44306/api/businesses/${businessId}`,
            businessData,
            businesses => {
                document.querySelector("#app").innerHTML = Business(businesses)
            }
        )
    }
} )
}