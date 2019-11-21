// import Activity from "./activity"

export default function Success(activity) {
    if(activity.done = true){
        return `
        ${activity
            .map(activity => {
                return `
            <section class="activity">
                <h3 class="activity_name">${activity.name}</h3>
                <h2 class="activity_description">${activity.description}</h2>
                <h3 class="activity_creation">${activity.creation}</h3>
                <h3 class="activity_completion">${activity.completion}</h3>
                <input class="activity_id" type="hidden" value="${activity.id}">
                <h3>${activity.done}</h3>
            </section>
            `;
        })
        .join("")}
        `
    }
}