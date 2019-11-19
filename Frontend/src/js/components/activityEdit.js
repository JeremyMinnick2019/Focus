export default function ActivityEdit(editActivity) {
    return `
        <section class="activity">
            <h3>${editActivity.name}</h3>
            <h3>${editActivity.importance}</h3>
            <h3>${editActivity.urgency}</h3>
            <p>${editActivity.description}</p>
        </section>
            
        <section class="update-activity">
            <input class="update-activity_name" type"text" value="${editActivity.name}">
            <input class="update-activity_importance" type"text" value="${editActivity.importance} 1-10">
            <input class="update-activity_urgency" type"text" value="${editActivity.urgency} 1-10">
            <textarea rows="10" cols="30" class="update-activity_description" value="${editActivity.description}"></textarea>
            <button class='update-activity'>Update</button>
            <input class="update-activity_id" type="hidden" value="${editActivity.id}">
        </section>
    `
}