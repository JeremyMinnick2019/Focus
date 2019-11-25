export default function CategoryActivity(category){
    return `
    <section clas="category">
    <h3>Category ${category.name}</h3>
    </section>

    ${category.activities
    .map(activity => {
        return `
        <section class="activity">
        <h3 class="activity_name">${activity.name}</h3>
        <h3 class="activity_importance">${activity.importance}</h3>
        <h3 class="activity_urgency">${activity.urgency}</h3>
        <h2 class="activity_description">${activity.description}</h2>
        <h3 class="activity_creation">${activity.creation}</h3>
        <h3 class="activity_completion">${activity.completion}</h3>
        <h3 class="activity_done">Completed: ${activity.done}</h3>
        <input class="activity_id" type="hidden" value="${activity.id}">
        </section>
        `;
    })
    .join("")}
    `
};