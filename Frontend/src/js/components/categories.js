export default function Category(categories) {
    return `
    ${categories
        .map(category => {
            return`
            <section class="category">
                <h3 class ="categoryName">${category.name}</h3>
                <p>${category.description}</p>
                <input class="category_id" type="hidden" value="${category.id}">
                <button class="edit-category">Edit</button>
                <button class="delete-category">Delete</button>
            </section>
            `;
        })
    .join("")}

        <section class="categoryAdd">
            <input class="add-category_name" type="text" placeholder="Add a Category Name">
            <textarea rows="10" cols="30" class="add-category_description" placeholder="Add a Category Description"></textarea>
            <select class= 'add-category_business' name="User">
            <option value="1">Small Business</option>
            <option value="2">Fish Shop</option>
            </select>
            <button class='add-category'>Submit</button>
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