export default function taskEdit(editTask) {
    return `
        <section class="task">
            <h3>${editTask.name}</h3>
            <h3>${editTask.importance}</h3>
            <h3>${editTask.urgency}</h3>
            <p>${editTask.decription}</p>
        </section>
            
        <section class="update-task">
            <input class="update-task_name" type"text" value="${editTask.name}">
            <input class="update-task_importance" type"text" value="${editTask.importance}">
            <input class="update-task_urgency" type"text" value="${editTask.urgency}">
            <textarea rows="10" cols="30" class="update-task_description" value="${editTask.decription}"></textarea>
            <button class='add-task'>Update</button>
            <input class="update-task_id" type="hidden" value="${editTask.id}">
        </section>
    `
}