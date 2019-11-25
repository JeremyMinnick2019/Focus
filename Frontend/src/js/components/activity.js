export default function Activity(activities) {
    return `
    <section class="gridAct">
        <section class="activityAdd" id="grid-Item">
            <input class="add-activity_name" id="input" type="text" placeholder="Add an Activity Name">
            <input class="add-activity_importance" id="input" type="text" placeholder="Add an Activity Importance 1-10">
            <input class="add-activity_creation" type="datetime-local"> 
            <input class="add-activity_urgency" id="input" type="text" placeholder="Add an Activity Urgency 1-10">
            <input class="add-activity_done" type="hidden">
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
            <button class='add-activity' id="mainbutton">Submit</button>
        </section>
        
    ${activities
        .map(activity => {
            return `

            <section class="activity" id="grid-Item">

                <h3 class="activity_name">${activity.name}</h3>
                <p class="activity_importance">${activity.importance}</p>
                <p class="activity_urgency">${activity.urgency}</p>
                <p class="activity_description">${activity.description}</p>
                <p class="activity_creation">${activity.creation}</p>
                <p class="activity_completion">${activity.completion}</p>

                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <p class="activity_done">Completed: ${activity.done}</p>
                <button class="mark-complete-activity" id="button">Mark Complete</button>
                <button class="edit-activity" id="button">Edit</button>
                <button class="delete-activity" id="button">Delete</button>

                </section>
                `;
            })
            .join("")}
    </section>
    `
}