import apiActions from "../api/apiActions"

export default () =>{
    Bar();
}

function Bar() {
    const bars = document.querySelector("#ProgressBar");
    apiActions.getRequest("https://localhost:44306/api/activities/points", bar =>{
        const points =  bar;
        switch (true){
          //If points range 0-50
          case points <= 0:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW0"></div>
              </div>`;
              break; 
          case points <= 10:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW10"></div>
              </div>`;
              break;    
          case points <= 20:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW20"></div>
              </div>`;
              break; 
          case points <= 30:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW30"></div>
              </div>`;
              break;
          case points <= 40:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW40"></div>
              </div>`;
              break;
          case points <= 50:
              bars.innerHTML = `
              <div id="myProgressW">
                <div id="myBarW50"></div>
              </div>`;
              break;
              //If points range 51-100
            case points <= 51:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr0"></div>
                </div>`;
                break; 
            case points <= 60:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr10"></div>
                </div>`;
                break;    
            case points <= 70:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr20"></div>
                </div>`;
                break; 
            case points <= 80:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr30"></div>
                </div>`;
                break;
            case points <= 90:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr40"></div>
                </div>`;
                break;
            case points <= 100:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarOr50"></div>
                </div>`;
                break;
                //If points range 101-250
            case points <= 101:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG0"></div>
                </div>`;
                break; 
            case points <= 125:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG10"></div>
                </div>`;
                break;    
            case points <= 150:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG20"></div>
                </div>`;
                break; 
            case points <= 175:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG30"></div>
                </div>`;
                break;
            case points <= 200:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG40"></div>
                </div>`;
                break;
            case points <= 250:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarG50"></div>
                </div>`;
                break;
                //If points range 251-500
            case points <= 251:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB0"></div>
                </div>`;
                break; 
            case points <= 300:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB10"></div>
                </div>`;
                break;    
            case points <= 350:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB20"></div>
                </div>`;
                break; 
            case points <= 400:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB30"></div>
                </div>`;
                break;
            case points <= 450:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB40"></div>
                </div>`;
                break;
            case points <= 500:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarB50"></div>
                </div>`;
                break;
            //If points range 501-1000
            case points <= 501:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack0"></div>
                </div>`;
                break; 
            case points <= 600:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack10"></div>
                </div>`;
                break;    
            case points <= 700:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack20"></div>
                </div>`;
                break; 
            case points <= 800:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack30"></div>
                </div>`;
                break;
            case points <= 900:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack40"></div>
                </div>`;
                break;
            case points <= 1000:
                bars.innerHTML = `
                <div id="myProgressG">
                  <div id="myBarBlack50"></div>
                </div>`;
                break;
            }
    })
}

 