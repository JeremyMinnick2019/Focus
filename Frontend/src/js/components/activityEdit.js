export default function ActivityEdit(editActivity) {
    return `
        <section class="activity">
            <h3>${editActivity.name}</h3>
            <h3>Importance: ${editActivity.importance}</h3>
            <h3>Urgency: ${editActivity.urgency}</h3>
            <p>${editActivity.description}</p>
        </section>
            
        <section class="update-activity">
            <input class="update-activity_name" type"text" value="${editActivity.name}">
            <input class="update-activity_importance" type"text" placeholder="Importance 1-10">
            <input class="update-activity_urgency" type"text" placeholder="Urgency 1-10">
            <input class="update-activity_creation" type="hidden" value="${editActivity.creation}">
            <input class="update-activity_completion" type="hidden" value="${editActivity.completion}">
            <input class="update-activity_done" type="hidden" value="${editActivity.done}">
            <select class="update-activity_categoryId" name="Category">
                <option value="1">Marketing</option>
                <option value="2">Payroll</option>
                <option value="3">Accounting/Auditing</option>
                <option value="4">Customer Service</option>
                <option value="5">Budgeting</option>
                <option value="6">Sales</option>
                <option value="7">Operations</option>
                <option value="8">Small Tasks</option>
            </select>
            <textarea rows="10" cols="30" class="update-activity_description" value="${editActivity.description}"></textarea>
            <button class='update-activity'>Update</button>
            <input class="update-activity_id" type="hidden" value="${editActivity.id}">
        </section>
    `
}