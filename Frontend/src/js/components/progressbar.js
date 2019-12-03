import apiActions from "../api/apiActions"

export default () =>{
    Bar();
}

function Bar() {
    const bars = document.querySelector("#progressbar");
    apiActions.getRequest("https://localhost:44306/api/activities/points", bar =>{
        const points =  bar;
        switch (true){
            //If points range 501-1000
            case points >= 500:
                bars.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/black_belt.png" class=beltIMG></img>
                <h3>Level: Black Belt</h3>
                </section>
                </section>`;
                break;
            //If points range 251-500
            case points >= 250:
                bars.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/brown_belt.png" class=beltIMG></img>
                <h3>Level: Brown Belt</h3>
                </section>
                </section>`;
                break;
            //If points range 101-250
            case points >= 100:
                bars.innerHTML = `<section class="userGrid">
                <section class="user" id="gridItemA">
                <img src="/images/green_belt.png" class=beltIMG></img>
                <h3>Level: Green Belt</h3>
                </section>
                </section>`;
                break;
            //If points range 51-100
            case points >= 50:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 75%"></div>
              </div>`;
                break;
            //If points range 0-50
            case points >= 0:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 75%"></div>
              </div>`;
                break;      
            }
    })
}
    // })

 