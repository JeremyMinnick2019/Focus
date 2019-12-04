export default function User(users) {
    return `
    <section class="userGrid">
    ${users
        .map(user => {
            return `
            <section class="user" id="gridItemA">
            <img src=${user.image} class="userIcon"></img>
            <h3 class="userName" id="name">User Name: ${user.name}</h3>
            <h4>Email: ${user.email}</h4>
            <h4>Phone: "${user.phone}"</h4>
            <input class="user_id" type="hidden" value="${user.id}">
            </section>
            `;
        })
        .join("")}
        </section>
        `
        // <button class="edit-user" id="mainbutton">Edit</button>
}