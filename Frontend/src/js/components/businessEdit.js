export default function businessEdit(editBusiness) {
    return `
        <section class="business">
            <h3>${editBusiness.title}</h3>
            <h3>${editBusiness.industry}</h3>
        </section>
            
        <secction class="update-business">
            <input class="update-business_title" type"text" value="${editBusiness.title}">
            <input class="update-business_industry" type"text"value="${editBusiness.industry}">
            <button class="update-business_submit">Edit</button>
            <input class="update-business_id" type="hidden" value="${editBusiness.id}">
        </section>
            `
}
            // <input class="update-business_email" type"text" value="${editBusiness.zipcode}">
            // <h3>${editBusiness.zipcode}</h3>