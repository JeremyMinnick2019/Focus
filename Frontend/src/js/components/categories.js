export default function Category(categories) {
    return `
        <section class="gridCat">
    ${categories
        .map(category => {
            return `
            <section class="category" id="grid-Item">
            <h3 class ="categoryName" id="catName">${category.name}</h3>
            <p id="catdep">${category.description}</p>
            <input class="category_id" type="hidden" value="${category.id}">
            </section>
            `;
        })
        .join("")}
        </section>
        `
}