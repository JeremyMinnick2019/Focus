export default function User(users) {
    return `
        <section class="userAdd">
            <input class="add-user_name" type="text" placeholder="Add your name">
            <input class="add-user_email" type="text" placeholder="Add your email">
            <input class="add-user_phone" type="text" placeholder="Add your phone number">
            <button class='add-user'>Submit</button>
        </section>
        
    ${users
        .map(user => {
            return `
            <section class="user">
                <h3 class="userName">${user.name}</h3>
                <h5>${user.email}</h5>
                <h5>${user.phone}</h5>
                <input class="user_id" type="hidden" value="${user.id}">
                <button class="edit-user">Edit</button>
                <button class="delete-user">Delete</button>
            </section>
            `;
        })
    .join("")}

    `
}