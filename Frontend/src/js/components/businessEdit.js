export default function businessEdit(editBusiness) {
    return `
        <section class="business">
            <h3>${editBusiness.name}</h3>
            <h3>${editBusiness.industry}</h3>
        </section>
            
        <secction class="update-business">
            <input class="update-business_name" type"text" value="${editBusiness.name}">
            <input class="update-business_industry" type"text"value="${editBusiness.industry}">
            <select class="update-business_user" name="User">
            <option value="1">John Smith</option>
            <option value="2">Brad Jones</option>
            </select>
            <button class="update-business_submit">Edit</button>
            <input class="update-business_id" type="hidden" value="${editBusiness.id}">
        </section>
            `
}
            // <input class="update-business_email" type"text" value="${editBusiness.zipcode}">
            // <h3>${editBusiness.zipcode}</h3>