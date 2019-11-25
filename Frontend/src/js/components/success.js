export default function Success(activities) {
    if(activtiy.done == true){
        return `
            ${activities
                .map(activity => {
                return `
                <section class="activity">
                    <h3 class="activity_name">${activity.name}</h3>
                    <h3 class="activity_category">Category: ${activity.category.name}</h3>
                    <p class="activity_description">${activity.description}</p>
                    <h3 class="activity_creation">Creation Date: ${activity.creation}</h3>
                    <h3 class="activity_completion">Completion Date: ${activity.completion}</h3>
                    <input class="activity_id" type="hidden" value="${activity.id}">
                    <h3>Done: ${activity.done}</h3>
                </section>
                `;
                
            })
            .join("")}
            `
        }
    }
