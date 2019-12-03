import moment from "moment";

export default function ActivityDetails(detailActivity) {
    var timeCreated = moment(detailActivity.creation).format('MMMM Do YYYY, h:mm a');
    
    return `
        <section>
            <h3>${detailActivity.name}</h3>
            <p>${detailActivity.description}</p>
            <h3>Importance: ${detailActivity.importance}</h3>
            <h3>Urgency: ${detailActivity.urgency}</h3>
            <h3> Time Created: ${timeCreated}</h3>
            
            
        </section>
            `
}