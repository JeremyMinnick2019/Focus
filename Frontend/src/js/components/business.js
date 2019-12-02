export default function Business(businesses) {
    return `
    ${businesses
        .map(business => {
            return `
            <section class="userGrid">
            <section class="business" id="gridItemA">
            <h3 class="businessName">Business Name: ${business.name}</h3>
            <h5>Industry: ${business.industry}</h5>
            <input class="business_id" type="hidden" value="${business.id}">
            <button class="edit-business" id="mainbutton">Edit</button>
            </section>
            `;
        })
        .join("")}
        </section>
        `
        // <button class="delete-business" id="mainbutton">Delete</button>

    // <section class="gridMain">
    //     <section class="businessAdd" id="gridItem">
    //         <input class="add-business_name" id="input" type="text" placeholder="Add your business">
    //         <input class="add-business_industry" id="input"type="text" placeholder="Add your business industry">
    //         <select class= 'add-business_user' id="input" name="User">
    //         <option value="1">John Smith</option>
    //         <option value="2">Brad Jones</option>
    //         </select>
    //         <button class="add-business" id="mainbutton">Submit</button>
    //     </section>
}