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
}