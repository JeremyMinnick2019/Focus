export default () =>{
    Belt();
}

function Belt() {
    const userBTN = document.querySelector("#profileButton");
    const belts = document.querySelector("#belt");
    userBTN.addEventListener("click", function(){
        belts.innerHTML = `Get Your Belts here`;
        let a = Activity.Rank;
            switch (a)
                        {
                        case a >= 0:
                            belts.innerHTML == `White Belt Level`;
                        break;
                        case a >= 51:
                            belts.innerHTML == `Orange Belt Level`;
                        break;
            
                        case a >= 101:
                            belts.innerHTML == `Green Belt Level`;
                        break;
            
                        case a >= 251:
                            belts.innerHTML == `Brown Belt Level`;
                        break;
            
                        case a >= 501:
                            belts.innerHTML == `Black Belt Level`;
                        break;
                        }
    })
}
    // apiActions.getRequest("https://localhost:44306/api/activities/points", points =>{
    //             belts.innerHTML = Point(points);
    //         })

 