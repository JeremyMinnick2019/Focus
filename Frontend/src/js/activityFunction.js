import Activity from "./components/activity"
import ActivityEdit from "./components/activityEdit"
import apiActions from "./api/apiActions"
import ActivityComplete from "./components/activityComplete"
import HeaderAct from "./components/headerAct"
import Success from "./components/success"
import Point from "./components/points"
import ActivityDetails from "./components/activityDetails"


export default () =>{
    displayActivity();
    displayHeader();
}

function displayHeader(){
    const activityBTN = document.querySelector("#activityButton");
    const head = document.querySelector("#header");
    activityBTN.addEventListener("click", function(){
            head.innerHTML = HeaderAct();
        })
}

function displayActivity(){
    const activityBTN = document.querySelector("#activityButton");
    const app = document.querySelector("#app");
    const sign = document.querySelector("#sign");
    const total = document.querySelector("#points");
    const belts = document.querySelector("#belt");
    activityBTN.addEventListener("click", function(){
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        apiActions.getRequest(`https://localhost:44306/api/activities/notdone`, activities =>{
            app.innerHTML = Activity(activities);
        });
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("activityName")){
        const activityid = event.target.parentElement.querySelector(".activity_id").value;
        apiActions.getRequest(`https://localhost:44306/api/activities/${activityid}`, activities => {
            document.querySelector("#app").innerHTML = Activity(activities);
            console.log(activities);
        })

    }
})

app.addEventListener("click", function(){
    if(event.target.classList.contains("activityName")){
    const activityid = event.target.parentElement.querySelector(".activity_id").value;
    apiActions.getRequest(`https://localhost:44306/api/activities/${activityid}`, activities => {
        document.querySelector("#app").innerHTML = Activity(activities);
        console.log(activities);
    })

}
})

app.addEventListener("click", function(){
    var newTime = new Date();
    if(event.target.classList.contains("add-activity")){
    const addName = event.target.parentElement.querySelector(".add-activity_name").value
    const addDescription = event.target.parentElement.querySelector(".add-activity_description").value
    const addCreation = newTime.toUTCString();
    const addCompletion = newTime.toUTCString();
    const addImportance = event.target.parentElement.querySelector(".add-activity_importance").value
    const addUrgency = event.target.parentElement.querySelector(".add-activity_urgency").value
    const addRank = parseInt(addImportance) + parseInt(addUrgency)
    const addCategoryid = event.target.parentElement.querySelector(".add-activity_categoryId").value
    console.log(`Name: ${addName} \nDescription: ${addDescription} \nImportance: ${addImportance} \nUrgency: ${addUrgency} \nCategoryid: ${addCategoryid} \nStarted: ${addCreation} \nCompleted: ${addCompletion}`)
    apiActions.postRequest
    (
        "https://localhost:44306/api/activities/notdone",{
        name: addName,
        description: addDescription,
        creation: addCreation,
        completion: addCompletion,
        importance: addImportance,
        urgency: addUrgency,
        rank: addRank,
        categoryID: addCategoryid
        },

        activities => {
            app.innerHTML = Activity(activities)
        }
       
    )}
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("delete-activity")) {
        const activityId = event.target.parentElement.querySelector(".activity_id").value;
        console.log("delete" + activityId);
        apiActions.deleteRequest(`https://localhost:44306/api/activities/${activityId}`,
        activities => {
            app.innerHTML = Activity(activities)
        })
    }
});

app.addEventListener("click", function(){
    if(event.target.classList.contains("edit-activity")) {
        const activityid = event.target.parentElement.querySelector(".activity_id").value;
        console.log("edit"  + activityid);
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
        apiActions.getRequest(`https://localhost:44306/api/activities/${activityid}`, 
        editActivity => {
            app.innerHTML = ActivityEdit(editActivity)
        })
    }
});

app.addEventListener("click", function() {
    if(event.target.classList.contains("update-activity")) {
        const activityid = event.target.parentElement.querySelector(".update-activity_id").value
        const updateName = event.target.parentElement.querySelector(".update-activity_name").value
        const updateDescription = event.target.parentElement.querySelector(".update-activity_description").value
        const updateCreation = event.target.parentElement.querySelector(".update-activity_creation").value
        const updateCompletion = event.target.parentElement.querySelector(".update-activity_completion").value 
        const updateImportance = event.target.parentElement.querySelector(".update-activity_importance").value
        const updateUrgency = event.target.parentElement.querySelector(".update-activity_urgency").value
        const updateRank = parseInt(updateImportance) + parseInt(updateUrgency)
        const updateCategoryid = event.target.parentElement.querySelector(".update-activity_categoryId").value
        const updateDone = event.target.parentElement.querySelector(".update-activity_done").value
        console.log(updateName, updateImportance, updateCategoryid)
        
        const activityData = {
            id: activityid,
            name: updateName,
            description: updateDescription,
            creation: updateCreation,
            completion: updateCompletion,
            importance: updateImportance,
            urgency: updateUrgency,
            rank: updateRank,
            categoryID: updateCategoryid,
            done: updateDone
        }
        sign.innerHTML = ``
        total.innerHTML = ``
        belts.innerHTML = ``;
        apiActions.putRequest(`https://localhost:44306/api/activities/${activityid}`,
            activityData,
            activities => {
                console.log(activities);
                app.innerHTML = Activity(activities);
            }
        )
    }
})
app.addEventListener("click", function(){
    if(event.target.classList.contains("mark-complete-activity")) {
        const activityid = event.target.parentElement.querySelector(".activity_id").value;
        console.log("edit"  + activityid);
        apiActions.getRequest(`https://localhost:44306/api/activities/${activityid}`, 
        completedActivity => {
            app.innerHTML = ActivityComplete(completedActivity)
        })
    }
});
app.addEventListener("click", function(){
    if(event.target.classList.contains("activity-details")) {
        const activityid = event.target.parentElement.querySelector(".activity_id").value;
        console.log(activityid);
        sign.innerHTML = ``
        total.innerHTML = ``
        belts.innerHTML = ``;
        apiActions.getRequest(`https://localhost:44306/api/activities/${activityid}`, 
        detailActivity => {
            app.innerHTML = ActivityDetails(detailActivity)
        })
    }
});

app.addEventListener("click", function(){
    var newTime = new Date();
    if(event.target.classList.contains("complete-activity")) {
        const completeActivityid = event.target.parentElement.querySelector(".complete-activity_id").value
        const completeName = event.target.parentElement.querySelector(".complete-activity_name").value
        const completeDescription = event.target.parentElement.querySelector(".complete-activity_description").value
        const completeCreation = event.target.parentElement.querySelector(".complete-activity_creation").value
        const completeCompletion = newTime.toUTCString();
        const completeImportance = event.target.parentElement.querySelector(".complete-activity_importance").value
        const completeUrgency = event.target.parentElement.querySelector(".complete-activity_urgency").value
        const completeRank = parseInt(completeImportance) + parseInt(completeUrgency)
        const completeCategoryid = event.target.parentElement.querySelector(".complete-activity_categoryId").value
        const completeDone = true
        console.log(completeName, completeImportance, completeCategoryid)
        
        const activityData = {
            id: completeActivityid,
            name: completeName,
            description: completeDescription,
            creation: completeCreation,
            completion: completeCompletion,
            importance: completeImportance,
            urgency: completeUrgency,
            rank: completeRank,
            categoryID: completeCategoryid,
            done: completeDone
        }        
        apiActions.putRequest(`https://localhost:44306/api/activities/points`,
        apiActions.getRequest("https://localhost:44306/api/activities/points", points =>{
            total.innerHTML = Point(points);
        })
        )
        apiActions.putRequest(`https://localhost:44306/api/activities/${completeActivityid}`,
            activityData,
            activities => {
                console.log(activities);
                apiActions.getRequest(`https://localhost:44306/api/activities/done`, activities =>{
                app.innerHTML = Success(activities);
            });
        }
        )}
    })
}