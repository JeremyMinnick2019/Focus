export default function Business(businesses) {
    return `
    <section class="userGrid">
    ${businesses
        .map(business => {
            return `
            <section class="business" id="gridItemA">
            <h3 class="businessName">Business Name: ${business.name}</h3>
            <h4>Industry: ${business.industry}</h4>
            <input class="business_id" type="hidden" value="${business.id}">
            </section>
            `;
        })
        .join("")}
        </section>
        `
        // <button class="edit-business" id="mainbutton">Edit</button>
}