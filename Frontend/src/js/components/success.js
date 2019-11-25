export default function Success(activities) {
    // if(activtiy.done == true){
        return `
            ${activities
                .map(activity => {
                return `
                <section id="Success">
                <section class="Success">
                    <h3 class="activity_name">${activity.name}</h3>
                    <p class="activity_category">Category: ${activity.category.name}</p>
                    <p class="activity_description">${activity.description}</p>
                    <p class="activity_creation">Creation Date: ${activity.creation}</p>
                    <p class="activity_completion">Completion Date: ${activity.completion}</p>
                    <input class="activity_id" type="hidden" value="${activity.id}">
                    <p>Done: ${activity.done}</p>
                </section>
                `;
                
            })
            .join("")}
            </section>
            `
        }
    // }
