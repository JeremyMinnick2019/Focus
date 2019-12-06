import moment from "moment";

export default function ActivityEdit(editActivity) {
    var timeCreated = moment(editActivity.creation + 'Z').format('MMM Do YYYY, h:mm a');
    return `
        <section class="edit-activity-card-pending">
            <h3 class="edit_name">${editActivity.name}</h3>
            <p class="activity_description edit_description">${editActivity.description}</p>
            <p class="activity_importance edit_importance">Importance: ${editActivity.importance}</p>
            <p class="activity_urgency edit_urgency">Urgency: ${editActivity.urgency}</p>
            <p class="activity_creation edit_creation">Started: <br>${timeCreated}</p>
        </section>
        
        <section class="userGrid">
        <section class="update-activity" id="gridItemA">
        <a href="#popup1"><button class="popupButton">Update Action</button></a>
        <div id="popup1" class="overlay">
        <div class="popup">
        <a class="close" href="#">&times;</a>
        <div class="content">
            <input class="update-activity_name" id="input1" type"text" value="${editActivity.name}">
            <input class="update-activity_creation" type="hidden" value="${editActivity.creation}">
            <input class="update-activity_completion" type="hidden" value="${editActivity.completion}">
            <input class="update-activity_done" type="hidden" value="${editActivity.done}">
            <select class="update-activity_categoryId" id="input1" name="Category">
                <option value="1">Marketing</option>
                <option value="2">Payroll</option>
                <option value="3">Accounting/Auditing</option>
                <option value="4">Customer Service</option>
                <option value="5">Budgeting</option>
                <option value="6">Sales</option>
                <option value="7">Operations</option>
                <option value="8">Small Tasks</option>
            </select>
            <input class="update-activity_importance" id="input1" type="number" name="quantity" min="1" max="10" placeholder="Importance 1-10">
            <input class="update-activity_urgency" id="input1" type="number" name="quantity" min="1" max="10" placeholder="Urgency 1-10">
            <textarea rows="5" cols="30" class="update-activity_description" id="input1" value="${editActivity.description}"></textarea>
            <button class='update-activity' id="popupbutton">Update</button>
            <input class="update-activity_id" type="hidden" value="${editActivity.id}">
            </div>
        </div>
        </div>
        </section>
        </section>
    `
}