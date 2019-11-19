export default function Activity(activities) {
    return `
    ${activities
        .map(activity => {
            return`
            <section class="activity">
                <h3 class="activityName">${activity.name}</h3>
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
                <input class="add-activity_name" type="text" placeholder="Add an Activity Name">
                <input class="add-activity_description" type="text" placeholder="Add a Description">
                <input class="add-activity_importance" type="text" placeholder="Add an Activity Importance 1-10">
                <input class="add-activity_urgency" type="text" placeholder="Add an Activity Urgency 1-10">
                <select class="add-activity_categoryId" name="Category">
                    <option value="1">Marketing</option>
                    <option value="2">Payroll</option>
                    <option value="3">Accounting/Auditing</option>
                    <option value="4">Customer Service</option>
                    <option value="5">Budgeting</option>
                    <option value="6">Sales</option>
                    <option value="7">Operations</option>
                    <option value="8">Small Tasks</option>
                </select>
                <textarea rows="10" cols="30" class="add-activity_description">Add an Activity Description</textarea>
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