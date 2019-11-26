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
                <p class="activity_completion">Time ${timeCompleted}</p>

                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <button class="mark-complete-activity" id="mainbutton">Mark Complete</button>
                <button class="edit-activity" id="mainbutton">Edit</button>
                <button class="delete-activity" id="mainbutton">Delete</button>
            </section>
                `;
            })
            .join("")}
    </section>
    `
}