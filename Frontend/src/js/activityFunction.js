import Activity from "./components/activity"
import ActivityEdit from "./components/activityEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayActivity()
}

function displayActivity(){
    const activityBTN = document.querySelector("#activityButton");
    activityBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/activities", activities =>{
            document.querySelector("#app").innerHTML = Activity(activities);
        });
    });
    const app = document.querySelector("#app");
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
    if(event.target.classList.contains("add-activity")){
    const addName = event.target.parentElement.querySelector(".add-activity_name").value
    const addDescription = event.target.parentElement.querySelector(".add-activity_description").value
    const addCreation = Date.now;
    const addCompletion = Date.now;
    const addImportance = event.target.parentElement.querySelector(".add-activity_importance").value
    const addUrgency = event.target.parentElement.querySelector(".add-activity_urgency").value
    const addCategoryid = event.target.parentElement.querySelector(".add-activity_categoryId").value
    console.log(addName, addDescription, addImportance, addUrgency, addCategoryid)
    apiActions.postRequest
    ( 
        "https://localhost:44306/api/activities",{  
        name: addName,
        description: addDescription,
        creation: addCreation,
        completion: addCompletion,
        importance: addImportance,
        urgency: addUrgency,
        categoryID: addCategoryid
        },

        activities => {
            document.querySelector("#app").innerHTML = Activity(activities)
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
        const updateCategoryid = event.target.parentElement.querySelector(".update-activity_categoryId").value
        console.log(updateName, updateImportance, updateCategoryid)
        
        const activityData = {
            id: activityid,
            name: updateName,
            description: updateDescription,
            creation: updateCreation,
            completion: updateCompletion,
            importance: updateImportance,
            urgency: updateUrgency,
            categoryID: updateCategoryid,
        }
        apiActions.putRequest(`https://localhost:44306/api/activities/${activityid}`,
            activityData,
            activities => {
                console.log(activities);
                document.querySelector("#app").innerHTML = Activity(activities);
            }
        )
    }
})
app.addEventListener("click", function() {
    if(event.target.classList.contains("complete-activity")) {
        const activityid = event.target.parentElement.querySelector(".activity_id").value
        const name = event.target.parentElement.querySelector(".activity_name").value
        const description = event.target.parentElement.querySelector(".activity_description").value
        const creation = event.target.parentElement.querySelector(".activity_creation").value
        const completion = event.target.parentElement.querySelector(".activity_completion").value 
        const importance = event.target.parentElement.querySelector(".activity_importance").value
        const urgency = event.target.parentElement.querySelector(".activity_urgency").value
        const categoryid = event.target.parentElement.querySelector(".activity_categoryId").value
        const done = true
        console.log(name, importance, categoryid, done)
        
        const activityData = {
            id: activityid,
            name: name,
            description: description,
            creation: creation,
            completion: completion,
            importance: importance,
            urgency: urgency,
            categoryID: categoryid,
            done: done
        }
        apiActions.putRequest(`https://localhost:44306/api/activities/${activityid}`,
            activityData,
            activities => {
                console.log(activities);
                document.querySelector("#app").innerHTML = Activity(activities);
            }
        )
    }
})
}