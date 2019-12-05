export default function Category(categories) {
    return `
        <section class="gridCat">
    ${categories
        .map(category => {
            return `
            <section class="category" id="grid-Item">
            <h3 class ="categoryName" id="name">${category.name}</h3>
            <h4 id="catdep">${category.description}</h4>
            <input class="category_id" type="hidden" value="${category.id}">
            </section>
            `;
        })
        .join("")}
        </section>
        `
}