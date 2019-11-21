export default function Activity(activities) {
    return `
    <section class="gridAct">
        <section class="activityAdd" id="grid-Item">
            <input class="add-activity_name" id="input" type="text" placeholder="Add an Activity Name">
            <input class="add-activity_importance" id="input" type="text" placeholder="Add an Activity Importance 1-10">
            <input class="add-activity_urgency" id="input" type="text" placeholder="Add an Activity Urgency 1-10">
            <select class="add-activity_categoryId" id="input" name="Category">
                <option value="1">Marketing</option>
                <option value="2">Payroll</option>
                <option value="3">Accounting/Auditing</option>
                <option value="4">Customer Service</option>
                <option value="5">Budgeting</option>
                <option value="6">Sales</option>
                <option value="7">Operations</option>
                <option value="8">Small Tasks</option>
            </select>
            <textarea rows="5" cols="20" class="add-activity_description" id="input" placeholder="Add an Activity Description"></textarea>
            <button class='add-activity' id="button">Submit</button>
        </section>
        
    ${activities
        .map(activity => {
            return `
            <section class="activity" id="grid-Item">
                <h3 class="activityName">${activity.name}</h3>
                <h5>Importance: ${activity.importance}</h5>
                <h5>Urgency: ${activity.urgency}</h5>
                <p>${activity.description}</p>
                <h5>Created: ${activity.creation}</h5>
                <h5>Completed: ${activity.completion}</h5>
                <input class="activity_id" type="hidden" value="${activity.id}">
                <button class="edit-activity" id="button">Edit</button>
                <button class="delete-activity" id="button">Delete</button>
                </section>
                `;
            })
            .join("")}
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