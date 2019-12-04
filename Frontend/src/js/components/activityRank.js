import moment from "moment";


export default function ActivityRank(activities) {
    return `
    <section class="gridRank">
    ${activities
        .map(activity => {
            
            return `
            <section class="activity">
                <button class="activity-details" id="mainbutton"><h3 class="activity_name">
                ${activity.name}</h3></button>
                
                <p class="activity_point">Point Value: ${activity.rank}


                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <section class="complete-activity">
                    <input class="complete-activity_name" type="hidden" value="${activity.name}">
                    <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                    <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                    <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                    <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                    <input class="complete-activity_description" type="hidden" value="${activity.description}">
                    
                    <input class="complete-activity" type="checkbox">
                    <input class="complete-activity_id" type="hidden" value="${activity.id}">
                    <input class="complete-activity_done" type="hidden" value="${activity.done}">
                </section>
            </section>
                `;
            })
            .join("")}
    </section>
    `
}