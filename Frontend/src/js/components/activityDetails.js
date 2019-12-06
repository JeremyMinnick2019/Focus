import moment from "moment";

export default function ActivityDetails(detailActivity) {
    var timeCreated = moment(detailActivity.creation + "Z").format('MMM Do YY, h:mm a');
    
    return `
        <section class="userGrid">
            <section class="user" id="gridItemA">
                <h3 class="userName" id="title">${detailActivity.name}</h3>
                <h3 id="cathead">${detailActivity.description}</p>
                <h3>Importance: ${detailActivity.importance}</h3>
                <h3>Urgency: ${detailActivity.urgency}</h3>
                <h3 id="cathead"> Time Created: ${timeCreated}</h3>
            </section>
            
        </section>
            `
}