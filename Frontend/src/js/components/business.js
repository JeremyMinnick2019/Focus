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
}