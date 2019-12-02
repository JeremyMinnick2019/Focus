import moment from "moment";

export default function ActivityDetails(activity) {
    return `
    ${activity
        .map(activities => {
            var timeCreated = moment(activities.creation).format('MMMM Do YYYY, h:mm a');
            var timeCompleted = moment(activities.completion).format('MMMM Do YYYY, h:mm a');

            return `
            <section class="activity-details">
                <h3 class="activity-details_name">${activities.name}</h3>
                <p class="activity-details_description">Description: ${activities.description}</p>
                <p class="activity-details_importance">Importance: ${activities.importance}</p>
                <p class="activity-details_urgency">Urgency: ${activities.urgency}</p>
                <p class="activity-details_creation">Time Created:<br> ${timeCreated}</p>
                <p class="activity-details_completion">Time ${timeCompleted}</p>
                    <input class="activity-details_id" type="hidden" value="${activities.id}">
                    <input class="activity-details_categoryId" type="hidden" value="${activities.categoryID}">
                    <input class="complete-activity_name" type="hidden" value="${activities.name}">
                    <input class="complete-activity_importance" type="hidden" value="${activities.importance}">
                    <input class="complete-activity_urgency" type="hidden" value="${activities.urgency}">
                    <input class="complete-activity_creation" type="hidden" value="${activities.creation}">
                    <input class="complete-activity_description" type="hidden" value="${activities.description}">
                    <input class="complete-activity" type="checkbox" <p>Mark Complete</p>
                    <input class="complete-activity_done" type="hidden" value="${activities.done}">
                    <button class="edit-activity" id="mainbutton">Edit</button>
                    <button class="delete-activity" id="mainbutton">Delete</button>
            </section>
                `;
            })
            .join("")}
    `
}