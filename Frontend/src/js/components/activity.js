export default function Activity(activities) {
    return `
    <section class="gridAct">
        <section class="activityAdd" id="grid-Item">
            <input class="add-activity_name" id="input" type="text" placeholder="Add an Activity Name">
            <input class="add-activity_importance" id="input" type="text" placeholder="Add an Activity Importance 1-10">
            <input class="add-activity_creation" type="datetime-local"> 
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

                <h3 class="activity_name">${activity.name}</h3>
                <h3 class="activity_importance">${activity.importance}</h3>
                <h3 class="activity_urgency">${activity.urgency}</h3>
                <h2 class="activity_description">${activity.description}</h2>
                <h3 class="activity_creation">${activity.creation}</h3>
                <h3 class="activity_completion">${activity.completion}</h3>

                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <input class="activity_done" type="hidden" value="${activity.done}">
                <button class="edit-activity" id="button">Edit</button>
                <button class="mark-complete-activity" id="button">Mark Activity Complete</button>
                <button class="delete-activity" id="button">Delete</button>

                </section>
                `;
            })
            .join("")}
    </section>
            `
}