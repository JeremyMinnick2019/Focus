export default function User(users) {
    return `
    ${users
        .map(user => {
            return `
            <section class="user" id="gridItemA">
            <h3 class="userName">${user.name}</h3>
            <h5>${user.email}</h5>
            <h5>${user.phone}</h5>
            <input class="user_id" type="hidden" value="${user.id}">
            <button class="edit-user" id="mainbutton">Edit</button>
            </section>
            `;
        })
        .join("")}
        </section>
        `
        // <button class="delete-user" id="mainbutton">Delete</button>

    // <section class="gridMain">
    //     <section class="userAdd" id="gridItem">
    //         <input class="add-user_name" id="input" type="text" placeholder="Add your name">
    //         <input class="add-user_email" id="input" type="text" placeholder="Add your email">
    //         <input class="add-user_phone" id="input" type="text" placeholder="Add your phone number">
    //         <button class='add-user' id="mainbutton">Submit</button>
    //     </section>
}