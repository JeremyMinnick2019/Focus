import moment from "moment";

export default function CategoryActivity(category){
    return `
    <section>
    <h1 id="cathead">${category.name}</h1>
    </section>

    ${category.activities
    .map(activity => {
        var timeCreated = moment(activity.creation).format('MMMM Do YYYY, h:mm a');
        var timeCompleted = moment(activity.completion).format('MMMM Do YYYY, h:mm a');
        return `
        <section class="activity">
        <h3 class="activity_name">${activity.name}</h3>
        <p class="activity_importance">Importance: ${activity.importance}</p>
        <p class="activity_urgency">Urgency: ${activity.urgency}</p>
        <p class="activity_description">${activity.description}</p>
        <p class="activity_creation">${timeCreated}</p>
        <p class="activity_completion">${timeCompleted}</p>
        <input class="activity_id" type="hidden" value="${activity.id}">
        </section>
        `;
    })
    .join("")}
    `
};