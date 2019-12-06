import moment from "moment";
import ConfettiGenerator from "confetti-js"

export default function Success(activities) {
        return `
            <canvas id="my-canvas"></canvas>
            ${activities
                .map(activity => {
            var timeCreated = moment(activity.creation).format('MMM Do YYYY, h:mm a');
            var timeCompleted = moment(activity.completion).format('MMM Do YYYY, h:mm a');

            return `
            <section class="gridAct">
                <section class="completed-actions-card">
                    <p class="activity_name completed_name">${activity.name}</p>
                    <p class="activity_description completed_description">${activity.description}</p>
                    <p class="activity_point completed_point">Points Earned: 
                        <span class="importance-urgency">
                            <br>${activity.rank}
                        </span>
                    </p>
                    <p class="activity_creation completed_creation">Started: <br>${timeCreated}</p>
                    <p class="activity_completion completed_time">Completed: <br>${timeCompleted}</p>
                    <input class="activity_id" type="hidden" value="${activity.id}">
                </section>
                    `;
                })
            .join("")}
        </section>
        `
                // <p class="activity_category">Category: ${activity.category.name}</p>
        }