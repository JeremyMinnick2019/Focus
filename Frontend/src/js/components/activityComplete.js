export default function ActivityComplete(completedActivity) {
    return `
        <section class="activity">
            <h3>${completedActivity.name}</h3>
            <h3>Importance: ${completedActivity.importance}</h3>
            <h3>Urgency: ${completedActivity.urgency}</h3>
            <p>${completedActivity.description}</p>
        </section>
            
        <section class="complete-activity">
            <input class="complete-activity_name" type="hidden" value="${completedActivity.name}">
            <input class="complete-activity_importance" type="hidden" value="${completedActivity.importance}">
            <input class="complete-activity_urgency" type="hidden" value="${completedActivity.urgency}">
            <input class="complete-activity_creation" type="hidden" value="${completedActivity.creation}">
            
            <input class="complete-activity_creation" type="datetime-local"> 
            <input class="complete-activity_categoryId" type="hidden" value="${completedActivity.categoryID}">
            <input class="complete-activity_description" type="hidden" value="${completedActivity.description}">
            <input class="complete-activity" type="checkbox">
            <input class="complete-activity_id" type="hidden" value="${completedActivity.id}">
            <input class="complete-activity_done" type="hidden" value="${completedActivity.done}">
        </section>
    `
}