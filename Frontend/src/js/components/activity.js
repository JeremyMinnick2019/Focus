import moment from "moment";

export default function Activity(activities) {
    return `
    <section>
        <a href="#popup1"><button class="popupButton">Add A New Action</button></a>
        <div id="popup1" class="overlay">
            <div class="popup">
            <a class="close" href="#">&times;</a>
                <div class="content">
                    <input class="add-activity_name" id="input1" type="text" placeholder="Add an Action Name" size="40px">
                    <select class="add-activity_categoryId" id="input1" name="Category">
                        <option value="1">Marketing</option>
                        <option value="2">Payroll</option>
                        <option value="3">Accounting/Auditing</option>
                        <option value="4">Customer Service</option>
                        <option value="5">Budgeting</option>
                        <option value="6">Sales</option>
                        <option value="7">Operations</option>
                        <option value="8">Small Tasks</option>
                    </select>
                    <input class="add-activity_importance" id="input1" type="number" name="quantity" min="1" max="10" placeholder=" Importance 1-10" size="30px">
                    <input class="add-activity_urgency" id="input1" type="number" name="quantity" min="1" max="10" placeholder=" Urgency 1-10" size="40px">
                    <textarea rows="5" cols="30" class="add-activity_description" id="input1" placeholder="Add an Action Description"></textarea>
                    <input class="add-activity_done" type="hidden">
                    <button class='add-activity' id="popupbutton">Add</button>
                </div>
            </div>
        </div>
    </section>
    
    <section class="gridAct">
        ${activities
            .map(activity => {
                var timeCreated = moment(activity.creation + 'Z').format('MMM Do YY, h:mm a');
                
                return `
                <section class="activity-card-pending">
                    <h3 class="activity_name pending_name">${activity.name}</h3>
                    <p class="activity_description pending_description">${activity.description}</p>
                    <p class="activity_importance pending_importance">Importance: 
                        <span class="importance-urgency">
                            <br>${activity.importance}
                        </span>
                    </p>
                    <p class="activity_urgency pending_urgency">Urgency: 
                        <span class="importance-urgency">
                            <br>${activity.urgency}
                        </span>
                    </p>
                    <p class="activity_creation pending_creation">Started: <br>${timeCreated}</p>
                    <input class="activity_id" type="hidden" value="${activity.id}">
                    <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                    <button class="edit-activity pending_edit" id="mainbutton">Update</button>
                    <button class="delete-activity pending_delete" id="mainbutton">Delete</button>
                    
                    <section class="complete-activity pending_complete">
                        <input class="complete-activity radioButton" type="radio">
                        <input class="complete-activity_name" type="hidden" value="${activity.name}">
                        <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                        <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                        <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                        <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                        <input class="complete-activity_description" type="hidden" value="${activity.description}">
                        <input class="complete-activity_id" type="hidden" value="${activity.id}">
                        <input class="complete-activity_done" type="hidden" value="${activity.done}">
                    </section>
                </section>
                        `;
                    })
        .join("")}
    </section>
    `
                    // <p class="activity_category">Department: ${activity.category.name}</p>
}