export default function Business(businesses) {
    return `
    ${businesses
        .map(business => {
            return`
            <section class="business">
                <h3 class = "businessName">${business.name}</h3>
                <h3>${business.industry}</h3>
                <input class="business_id" type="hidden" value="${business.id}">
                <button class="edit-business">Edit</button>
                <button class="delete-business">Delete</button>
            </section>
            `;
        })
    .join("")}

    <section class="businessAdd">
        <input class="add-business_name" type="text" placeholder="Add your business">
        <input class="add-business_industry" type="text" placeholder="Add your business industry">
        <select class= 'add-business_user' name="User">
        <option value="1">John Smith</option>
        <option value="2">Brad Jones</option>
        </select>
        <button class="add-business">Submit</button>
    </section>    
    `
}