import apiActions from "../api/apiActions"

export default () =>{
    Bar();
}

function Bar() {
    const bars = document.querySelector("#userProgressBar");
    apiActions.getRequest("https://localhost:44306/api/activities/points", bar =>{
        const points =  bar;
        switch (true){
            //If points range 501-1000
            case points >= 500:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 100%"></div>
              </div>`;
                break;
            //If points range 251-500
            case points >= 250:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 80%"></div>
              </div>`;
                break;
            //If points range 101-250
            case points >= 100:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 60%"></div>
              </div>`;
                break;
            //If points range 51-100
            case points >= 50:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 40%"></div>
              </div>`;
                break;
            //If points range 0-50
            case points >= 0:
                bars.innerHTML = `<div class="progress">
                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 20%"></div>
              </div>`;
                break;      
            }
    })
}
    // })

 