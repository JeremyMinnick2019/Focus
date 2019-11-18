export default function Task(tasks) {
    return `
    ${tasks
        .map(task => {
            return`
            <section class="task">
                <h3>${task.name}</h3>
                <h3>${task.importance}</h3>
                <h3>${task.urgency}</h3>
                <p>${task.decription}</p>
                <input class="task_id" type="hidden" value="${task.id}">
                <button class="edit-task">Edit</button>
                <button class="delete-task">Delete</button>
                </section>
                `;
            })
            .join("")}
            
            <section class="taskAdd">
                <input class="add-task_name" type"text" placeholder="Add a Task Name">
                <input class="add-task_importance" type"text" placeholder="Add a Task Importance 1-5">
                <input class="add-task_urgency" type"text" placeholder="Add a Task Urgency 1-5">
                <textarea rows="10" cols="30" class="add-task_description">Add a Task Description</textarea>
                <button class='add-task'>Submit</button>
            </section>
            `
}
            // <select class="add-task_importance" name='importance' placeholder="Add Task Importance">
            // <option value="1">Important</option>
            // <option value="2">Not Important</option>
            // </select>
            // <select class="add-task_uurgency" name='urgency' placeholder="Add Task Urgency">
            // <option value="1">Urgent</option>
            // <option value="2">Not Urgent</option>
            // </select>
            // <input class="add-task_time" type"text" placeholder="Add a Task Time">
            // <h3>${task.time}</h3>