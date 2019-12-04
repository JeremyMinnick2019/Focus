import Category from "./components/categories"
import categoryEdit from "./components/categoriesEdit"
import CategoryActivity from "./components/categoryActivity"
import HeaderCat from "./components/headerCat"
import apiActions from "./api/apiActions"

export default () =>{
    displayCategory();
    displayHeader();
}

function displayHeader(){
    const categoryBTN = document.querySelector("#categoryButton");
    const head = document.querySelector("#header");
    categoryBTN.addEventListener("click", function(){
            head.innerHTML = HeaderCat();
        })
}

function displayCategory(){
    const categoryBTN = document.querySelector("#categoryButton");
    const app = document.querySelector("#app");
    const head = document.querySelector("#header");
    const sign = document.querySelector("#sign");
    const total = document.querySelector("#points");
    const belts = document.querySelector("#belt");
    const available = document.querySelector("#available");
    categoryBTN.addEventListener("click", function(){
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        available.innerHTML = ``;
        apiActions.getRequest("https://localhost:44306/api/categories", categories =>{
            app.innerHTML = Category(categories);
        })
    })
    app.addEventListener("click", function(){
        if(event.target.classList.contains("categoryName")){
            const categoryId = event.target.parentElement.querySelector(".category_id").value;
            apiActions.getRequest(`https://localhost:44306/api/categories/${categoryId}`, category =>{
                head.innerHTML =`<h1></h1>`;
                app.innerHTML = CategoryActivity(category);
                console.log(category);
            })
        }
    })

app.addEventListener("click", function(){
    if(event.target.classList.contains("categoryName")){
        const categoryId = event.target.parentElement.querySelector(".category_id").value;
        apiActions.getRequest(`https://localhost:44306/api/categories/${categoryId}`, categories =>{
            app.innerHTML = Category(categories);
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
    sign.innerHTML = ``;
    total.innerHTML = ``;
    belts.innerHTML = ``;
    available.innerHTML = ``;
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/categories",{  
        name: addName,
        description: addDescription,
        businessID: addBusiness
        },

        categories => {
            app.innerHTML = Category(categories)
        }
    )}
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-category")) {
        const categoryId = event.target.parentElement.querySelector(".category_id").value;
        console.log("delete" + categoryId);
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        available.innerHTML = ``;
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
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        available.innerHTML = ``;
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
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        available.innerHTML = ``;
        apiActions.putRequest(
            `https://localhost:44306/api/categories/${categoryId}`,
            categoryData,
            categories => {
                app.innerHTML = Category(categories)
            }
        )
    }
})
}