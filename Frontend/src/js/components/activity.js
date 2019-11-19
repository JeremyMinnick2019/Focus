export default function Activity(activities) {
    return `
    ${activities
        .map(activity => {
            return`
            <section class="activity">
                <h3>${activity.name}</h3>
                <h3>${activity.importance}</h3>
                <h3>${activity.urgency}</h3>
                <p>${activity.description}</p>
                <input class="activity_id" type="hidden" value="${activity.id}">
                <button class="edit-activity">Edit</button>
                <button class="delete-activity">Delete</button>
                </section>
                `;
            })
            .join("")}
            
            <section class="activityAdd">
                <input class="add-activity_name" type"text" placeholder="Add a Activity Name">
                <input class="add-activity_importance" type"text" placeholder="Add a Activity Importance 1-5">
                <input class="add-activity_urgency" type"text" placeholder="Add a Activity Urgency 1-5">
                <textarea rows="10" cols="30" class="add-activity_description">Add a Activity Description</textarea>
                <button class='add-activity'>Submit</button>
            </section>
            `
}
            // <select class="add-Activity_importance" name='importance' placeholder="Add Activity Importance">
            // <option value="1">Important</option>
            // <option value="2">Not Important</option>
            // </select>
            // <select class="add-Activity_uurgency" name='urgency' placeholder="Add Activity Urgency">
            // <option value="1">Urgent</option>
            // <option value="2">Not Urgent</option>
            // </select>
            // <input class="add-Activity_time" type"text" placeholder="Add a Activity Time">
            // <h3>${Activity.time}</h3>