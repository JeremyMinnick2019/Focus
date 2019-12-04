export default function Available(availables) {
    return `
    <section class="userGrid">
        <section class="user" id="gridItemA">
            <h2><span class="color">Points Unearned:</span><span id="number">${availables}</span></h2>
        </section>
    </section>
    `
}