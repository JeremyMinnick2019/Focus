import moment from "moment";
import ConfettiGenerator from "confetti-js"

export default function Success(activities) {
        return `
            <canvas id="my-canvas"></canvas>
            ${activities
                .map(activity => {
            var timeCreated = moment(activity.creation).format('MMMM Do YYYY, h:mm a');
            var timeCompleted = moment(activity.completion).format('MMMM Do YYYY, h:mm a');

                return `
                <section id="Success">
                <section class="Success">
                    <h3 class="activity_name">${activity.name}</h3>
                    <p class="activity_category">Category: ${activity.category.name}</p>
                    <p class="activity_description">${activity.description}</p>
                    <p class="activity_creation">Started: <br>${timeCreated}</p>
                    <p class="activity_completion">Completed: <br>${timeCompleted}</p>
                    <input class="activity_id" type="hidden" value="${activity.id}">
                </section>
                `;
            })
            .join("")}
            </section>
            `
        }