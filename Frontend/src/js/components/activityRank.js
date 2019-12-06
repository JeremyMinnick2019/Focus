import moment from "moment";

export default function ActivityRank(activities) {
    return `
    <section class="gridRank">
    ${activities
        .map(activity => {
            var timeCreated = moment(activity.creation + 'Z').fromNow();

            return `
            <section class="activity-card-priority">
                <h3 class="activity_name priority_name"><span id="priorityButton">${activity.name}</span></h3>
                <p class="activity_point priority_creation1">Created:</p>
                <p class="activity_point priority_creation2">${timeCreated}</p>
                <p class="activity_point priority_point1">Point Value:</p>
                <p class="activity_point priority_point2">${activity.rank}</p>
                <input class="activity_id" type="hidden" value="${activity.id}">
                <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
                <section class="complete-activity priority_complete">
                    <input class="complete-activity" type="radio">
                    <input class="complete-activity_name" type="hidden" value="${activity.name}">
                    <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                    <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                    <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                    <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                    <input class="complete-activity_description" type="hidden" value="${activity.description}">
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