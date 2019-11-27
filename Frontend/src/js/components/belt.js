import Points from "./points"
import Activity from "./activity"
export default () =>{
    Belt();
}

function Belt() {
    // const userBTN = document.querySelector("#profileButton");
    const belts = document.querySelector("#belt");
    // belts.innerHTML = `Get Your Belts here`;
    // userBTN.addEventListener("click", function(){
        const points = Activity.points;
            switch (true){
                //If points range 501-1000
                case points >= 500:
                    console.log("Black")
                    belts.innerHTML = `Black Belt Level`;
                    break;
                //If points range 251-500
                case points >= 250:
                    console.log("Brown")
                    belts.innerHTML = `Brown Belt Level`;
                    break;
                //If points range 101-250
                case points >= 100:
                    console.log("Green")
                    belts.innerHTML = `Green Belt Level`;
                    break;
                //If points range 51-100
                case points >= 50:
                    console.log("Orange")
                    belts.innerHTML = `Orange Belt Level`;
                    break;
                //If points range 0-50
                default:                   
                    console.log("White")
                    belts.innerHTML = `White Belt Level`;         
                }
    // })
}
    // apiActions.getRequest("https://localhost:44306/api/activities/points", points =>{
    //             belts.innerHTML = Point(points);
    //         })

 