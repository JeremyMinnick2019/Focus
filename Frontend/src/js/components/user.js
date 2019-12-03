import Point from "./points"
import apiActions from "../api/apiActions";

export default function User(users) {
    return `
    ${users
        .map(user => {
            return `
            <section class="userGrid">
            <section class="user" id="gridItemA">
            <img src=${user.image} class="userIcon"></img>
            <h3 class="userName">User Name: ${user.name}</h3>
            <h5>Email: ${user.email}</h5>
            <h5>Phone: "${user.phone}"</h5>
            <input class="user_id" type="hidden" value="${user.id}">
            <button class="edit-user" id="mainbutton">Edit</button>
            </section>
            `;
        })
        .join("")}
        </section>
    `
}