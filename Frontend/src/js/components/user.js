export default function User(users) {
    return `
    ${users
        .map(user => {
            return`
            <section class="user">
                <h3 class="userName">${user.name}</h3>
                <h3>${user.email}</h3>
                <h3>${user.phone}</h3>
                <input class="user_id" type="hidden" value="${user.id}">
                <button class="edit-user">Edit</button>
                <button class="delete-user">Delete</button>
            </section>
            `;
        })
    .join("")}

        <section class="userAdd">
            <input class="add-user_name" type"text" placeholder="Add your name">
            <input class="add-user_email" type"text" placeholder="Add your email">
            <input class="add-user_phone" type"text" placeholder="Add your phone number">
            <button class='add-user'>Submit</button>
        </section>    
    `
}