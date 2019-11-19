import Category from "./components/categories"
import categoryEdit from "./components/categoriesEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayCategory()
}

function displayCategory(){
    const categoryBTN = document.querySelector("#categoryButton");
    categoryBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/categories", categories =>{
            document.querySelector("#app").innerHTML = Category(categories);
        })
    })

const app = document.querySelector("#app");
app.addEventListener("click", function(){
    if(event.target.classList.contains("categotyName")){
        const categotyId = event.target.parentElement.querySelector(".categoty_id").value;
        apiActions.getRequest(`https://localhost:44306/api/categories/${categotyId}`, categories =>{
            document.querySelector("#app").innerHTML = Category(categories);
            console.log(categories);
        })
    }
})
app.addEventListener("click", function(){
    if(event.target.classList.contains("add-category")){
    const addName = event.target.parentElement.querySelector(".add-category_name").value
    const addDescription = event.target.parentElement.querySelector(".add-category_description").value
    console.log(addName)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/categories",{  
        name: addName,
        description: addDescription
        },

        categories => {
            document.querySelector("#app").innerHTML = Category(categories)
        }
    )}
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-category")) {
        const categotyId = event.target.parentElement.querySelector(".category_id").value;
        console.log("delete" + categotyId);
        apiActions.deleteRequest(`https://localhost:44306/api/categories/${categotyId}`,
        categories => {
            app.innerHTML = Category(categories)
        })
    }
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("edit-category")) {
        const categotyId = event.target.parentElement.querySelector(".category_id").value;
        console.log("edit"  + categotyId);
        apiActions.getRequest(`https://localhost:44306/api/categories/${categotyId}` , editCategories => {
            app.innerHTML = categoryEdit(editCategories)
        })
    }
})
app.addEventListener("click", function() {
    if(event.target.classList.contains("update-category")) {
        const categotyId = event.target.parentElement.querySelector(".category_id").value;
        const updateName = event.target.parentElement.querySelector(".update-category_name").value
        const updateDescription = event.target.parentElement.querySelector(".update-category_description").value

        const categoryData = {
            name: updateName,
            description: updateDescription,
            id: categotyId
        }
        apiActions.putRequest(
            `https://localhost:44306/api/businesses/${categotyId}`,
            categoryData,
            categories => {
                document.querySelector("#app").innerHTML = Category(categories)
            }
        )
    }
})
}