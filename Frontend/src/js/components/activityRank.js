export default function ActivityRank(activities) {
    return `
    ${activities
        .map(activity => {
            // const createDisplay =new Date(activity.creation);
            // const completeDisplay =new Date(activity.completion);
            // const createMonth = dateDisplay.getMonth();
            // const createDay = dateDisplay.getDay()
            // const createHours = dateDisplay.getHours()
            // const createMinutes = dateDisplay.getMinutes()
            // const completeMonth = dateDisplay.getMonth();
            // const completeDay = dateDisplay.getDay()
            // const completeHours = dateDisplay.getHours()
            // const completeMinutes = dateDisplay.getMinutes()
            

            return `
            <section class="activity">
                <h3 class="activity_name">${activity.name}</h3>
                <p class="activity_description">Description: ${activity.description}</p>
                <p class="activity_importance">Importance: ${activity.importance}</p>
                <p class="activity_urgency">Urgency: ${activity.urgency}</p>
                <p class="activity_creation">Time Created: ${activity.creation}</p>
                <p class="activity_completion">Time ${activity.completion}</p>
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