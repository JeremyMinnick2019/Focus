export default function Category(categories) {
    return `
    <section class="gridCat">
        <section class="categoryAdd" id="gridItem">
            <input class="add-category_name" id="input" type="text" placeholder="Add a Category Name">
            <article><textarea rows="5" cols="21" class="add-category_description" id="input" placeholder="Add a Category Description"></textarea>
            </article>
            <article><select class= "add-category_business" id="input" name="User">
            <option value="1">Small Business</option>
            <option value="2">Fish Shop</option>
            </select></article>
            <button class="add-category" id="button">Submit</button>
        </section>

    ${categories
        .map(category => {
            return`
            <section class="category" id="gridItem">
                <h3 class ="categoryName">${category.name}</h3>
                <p>${category.description}</p>
                <input class="category_id" type="hidden" value="${category.id}">
                <button class="edit-category" id="button">Edit</button>
                <button class="delete-category" id="button">Delete</button>
            </section>
            `;
        })
    .join("")}
    </section>
        `
    }
        // <select class="add-category_importance" name='importance' placeholder="Add Category Importance">
        // <option value="1">Important</option>
        // <option value="2">Not Important</option>
        // </select>
        // <select class="add-category_uurgency" name='urgency' placeholder="Add Category Urgency">
        // <option value="1">Urgent</option>
        // <option value="2">Not Urgent</option>
        // </select>