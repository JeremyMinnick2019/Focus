export default function categoryEdit(editCategory) {
    return `
        <section class="category">
            <h3>${editCategory.name}</h3>
            <p>${editCategory.decription}</p>
            <input class="category_id" type="hidden" value="${editCategory.id}">
        </section>

        <secction class="update-category">
            <input class="add-category_name" type"text" value="${editCategory.name}">
            <textarea rows="10" cols="30" class="add-category_description" value="${editCategory.description}"></textarea>
            <button class="update-category_submit">Update</button>
            <input class="update-category_id" type="hidden" value="${editCategory.id}">
        </section>
    `
}