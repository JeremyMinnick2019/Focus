import moment from "moment";

export default function CategoryActivity(category){
    return `
    <section>
    <h1 id="cathead">${category.name}</h1>
    </section>
    <section class="gridAct">
    ${category.activities
    .map(activity => {
        var timeCreated = moment(activity.creation).format('MMM Do YYYY, h:mm a');
        var timeCompleted = moment(activity.completion).format('MMM Do YYYY, h:mm a');
        return `
        <section class="activity-card-deparment">
            <h3 class="activity_name deparment_name">${activity.name}</h3>
            <p class="activity_description deparment_description">${activity.description}</p>
            <p class="activity_importance deparment_importance">Importance: <span class="importance-urgency"><br>${activity.importance}</span></p>
            <p class="activity_urgency deparment_urgency">Urgency: <span class="importance-urgency"><br>${activity.urgency}</span></p>
            <p class="activity_creation deparment_creation">Started: <br>${timeCreated}</p>
            <p class="activity_completion deparment_completion">Completed: <br>${timeCompleted}</p>

            <section class="complete-activity deparment_done">
                <input class="complete-activity checkBoxButton" type="checkbox" title="Complete ${activity.name} Action">
                <input class="complete-activity_name" type="hidden" value="${activity.name}">
                <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                <input class="complete-activity_description" type="hidden" value="${activity.description}">
                <input class="complete-activity_id" type="hidden" value="${activity.id}">
                <input class="complete-activity_done" type="hidden" value="${activity.done}">
            </section>
        </section>
        `;
    })
    .join("")}
    </section>
    `
};