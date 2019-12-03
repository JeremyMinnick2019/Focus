import moment from "moment";


export default function ActivityRank(activities) {
    return `
    ${activities
        .map(activity => {
            
            return `
            <section class="activity">
                <h3 class="activity_name">${activity.name}</h3>
                <p class="activity_description">Description: ${activity.description}</p>
                <p class="activity_rank">Point Value: ${activity.rank}


                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <section class="complete-activity">
                    <input class="complete-activity_name" type="hidden" value="${activity.name}">
                    <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                    <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                    <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                    <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                    <input class="complete-activity_description" type="hidden" value="${activity.description}">
                    
                    <input class="complete-activity" type="checkbox" <p>Mark Complete</p>
                    <input class="complete-activity_id" type="hidden" value="${activity.id}">
                    <input class="complete-activity_done" type="hidden" value="${activity.done}">
                </section>
                <button class="activity-details" id="mainbutton">View Details</button>
            </section>
                `;
            })
            .join("")}
    </section>
    `
}