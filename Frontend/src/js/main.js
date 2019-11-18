import displayUser from "./userFunction"
import displayBusiness from "./businessFunction"
import displayCategory from "./categoryFunction"
import displayTask from "./taskFunction"


export default () => {
    pageBuild();
}

function pageBuild(){
    userAction();
    businessAction();
    categoryAction();
    taskAction();
}

function userAction(){
    displayUser()
}

function businessAction(){
    displayBusiness()
}

function categoryAction(){
    displayCategory()
}

function taskAction(){
    displayTask()
}