import Category from "./components/categories"
import categoryEdit from "./components/categoriesEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayCategory()
}

function displayCategory(){
    const categoryBTN = document.querySelector("#categoryButton");
    categoryBTN.addEventListener("click", function(){
        const sign = document.querySelector("#sign")
        sign.innerHTML = ``
        apiActions.getRequest("https://localhost:44306/api/categories", categories =>{
            document.querySelector("#app").innerHTML = Category(categories);
        })
    })

const app = document.querySelector("#app");
app.addEventListener("click", function(){
    if(event.target.classList.contains("categoryName")){
        const categoryId = event.target.parentElement.querySelector(".category_id").value;
        apiActions.getRequest(`https://localhost:44306/api/categories/${categoryId}`, categories =>{
            document.querySelector("#app").innerHTML = Category(categories);
            console.log(categories);
        })
    }
})
app.addEventListener("click", function(){
    if(event.target.classList.contains("add-category")){
    const addName = event.target.parentElement.querySelector(".add-category_name").value
    const addDescription = event.target.parentElement.querySelector(".add-category_description").value
    const addBusiness = event.target.parentElement.querySelector(".add-category_business").value;

    console.log(addName)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/categories",{  
        name: addName,
        description: addDescription,
        businessID: addBusiness
        },

        categories => {
            document.querySelector("#app").innerHTML = Category(categories)
        }
    )}
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-category")) {
        const categoryId = event.target.parentElement.querySelector(".category_id").value;
        console.log("delete" + categoryId);
        apiActions.deleteRequest(`https://localhost:44306/api/categories/${categoryId}`,
        categories => {
            app.innerHTML = Category(categories)
        })
    }
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("edit-category")) {
        const categoryId = event.target.parentElement.querySelector(".category_id").value;
        console.log("edit"  + categoryId);
        apiActions.getRequest(`https://localhost:44306/api/categories/${categoryId}` , editCategories => {
            app.innerHTML = categoryEdit(editCategories)
        })
    }
})
app.addEventListener("click", function() {
    if(event.target.classList.contains("update-category_submit")) {
        const categoryId = event.target.parentElement.querySelector(".update-category_id").value;
        const updateName = event.target.parentElement.querySelector(".update-category_name").value
        const updateDescription = event.target.parentElement.querySelector(".update-category_description").value
        const updateBusiness = event.target.parentElement.querySelector(".update-category_business").value;

        const categoryData = {
            name: updateName,
            description: updateDescription,
            id: categoryId,
            businessID: updateBusiness
        }
        apiActions.putRequest(
            `https://localhost:44306/api/categories/${categoryId}`,
            categoryData,
            categories => {
                document.querySelector("#app").innerHTML = Category(categories)
            }
        )
    }
})
}