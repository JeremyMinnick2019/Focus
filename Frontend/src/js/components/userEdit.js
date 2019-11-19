export default function UserEdit(editUser) {
    return `
        <section class="user">
            <h3>${editUser.name}</h3>
            <h3>${editUser.email}</h3>
            <h3>${editUser.phone}</h3>
        </section>
        
        <secction class="update-user">
            <input class="update-user_name" type"text" value="${editUser.name}">
            <input class="update-user_email" type"text" value="${editUser.email}">
            <input class="update-user_phone" type"text"value="${editUser.phone}">
            <button class="update-user_submit">Update</button>
            <input class="update-user_id" type="hidden" value="${editUser.id}">
        </section>
    `
}