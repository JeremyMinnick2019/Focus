export default function Success(activity) {
    if (activity.done = true)
    return `
        <section class="activity">
            <h3 class="activityName">${activity.name}</h3>
            <p>${activity.description}</p>
            <h5>Created: ${activity.creation}</h5>
            <h5>Completed: ${activity.completion}</h5>
            <h5>${activity.done}</h5>
            <input class="activity_id" type="hidden" value="${activity.id}">
        </section>
    `
}
