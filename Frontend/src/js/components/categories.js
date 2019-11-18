export default function Category(categories) {
    return `
    ${categories
        .map(category => {
            return`
            <section class="category">
                <h3>${category.name}</h3>
                <p>${category.decription}</p>
                <input class="category_id" type="hidden" value="${category.id}">
                <button class="edit-task">Edit</button>
                <button class="delete-task">Delete</button>
            </section>
            `;
        })
    .join("")}

        <section class="categoryAdd">
            <input class="add-category_name" type"text" placeholder="Add a Category Name">
            <textarea rows="10" cols="30" class="add-category_description">Add a Category Description</textarea>
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