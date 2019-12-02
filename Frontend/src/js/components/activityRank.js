import moment from "moment";

export default function ActivityRank(activities) {
    return `
    ${activities
        .map(activity => {
            var timeCreated = moment(activity.creation).format('MMMM Do YYYY, h:mm a');
            var timeCompleted = moment(activity.completion).format('MMMM Do YYYY, h:mm a');
            return `
            <section class="activity">
                <h3 class="activity_name">${activity.name}</h3>
                <p class="activity_description">Description: ${activity.description}</p>
                <p class="activity_importance">Importance: ${activity.importance}</p>
                <p class="activity_urgency">Urgency: ${activity.urgency}</p>
                <p class="activity_creation">Time Created:<br> ${timeCreated}</p>


                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <section class="complete-activity">
                    <input class="complete-activity_name" type="hidden" value="${activity.name}">
                    <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                    <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                    <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                    <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                    <input class="complete-activity_description" type="hidden" value="${activity.description}">
                    <p class="activity_completion">Time Completed: ${timeCompleted}</p>                    <input class="complete-activity_id" type="hidden" value="${activity.id}">
                    <input class="complete-activity_done" type="hidden" value="${activity.done}">
                </section>
                <button class="edit-activity" id="mainbutton">Edit</button>
                <button class="delete-activity" id="mainbutton">Delete</button>
            </section>
                `;
            })
            .join("")}
    </section>
    `
}