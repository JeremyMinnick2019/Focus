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
                belts.innerHTML = `Black Belt Level`;
                break;
            //If points range 251-500
            case points >= 250:
                belts.innerHTML = `Brown Belt Level`;
                break;
            //If points range 101-250
            case points >= 100:
                belts.innerHTML = `Green Belt Level`;
                break;
            //If points range 51-100
            case points >= 50:
                belts.innerHTML = `Orange Belt Level`;
                break;
            //If points range 0-50
            case points >= 0:                   
                belts.innerHTML = `White Belt Level`;
                break;      
            }
    })
}
    // })

 