import apiActions from "../api/apiActions"

export default () =>{
    Belt();
}

function Belt() {
    const belts = document.querySelector("#belt");
    apiActions.getRequest("https://localhost:44306/api/activities/points", belt =>{
        const points =  belt;
        switch (true){
            //If points range 501-1000
            case points >= 500:
                belts.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/black_belt.png" class=beltIMG></img>
                <h3>Level: <span id="number">Black Belt</span></h3>
                </section>
                </section>`;
                break;
            //If points range 251-500
            case points >= 250:
                belts.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/brown_belt.png" class=beltIMG></img>
                <h3>Level: <span id="number">Purple Belt</span></h3>
                </section>
                </section>`;
                break;
            //If points range 101-250
            case points >= 100:
                belts.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/green_belt.png" class=beltIMG></img>
                <h3>Level: <span id="number">Green Belt</span></h3>
                </section>
                </section>`;
                break;
            //If points range 51-100
            case points >= 50:
                belts.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/orange_belt.png" class=beltIMG></img>
                <h3>Level: <span id="number">Orange Belt</span></h3>
                </section>
                </section>`;
                break;
            //If points range 0-50
            case points >= 0:
                belts.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/white_belt.png" class=beltIMG></img>
                <h2><span class="color">Level:</span><span id="number">White Belt</span></h2>
                </section>
                </section>`;
                break;      
            }
    })
}
 