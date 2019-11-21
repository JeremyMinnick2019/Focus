export default function Navbar() {
    return `
    // constructor / variables
    function StopWatch(){

        var startTime = null; 
        var stopTime = null; 
        var running = false; 
      }

    //   methods...
    //   timestamp method

      function getTime(){
        var day = new Date();
        return day.getTime();
      }

    //   start method

      this.start = function(){ 

        if (running == true)
            return;
        else if (startTime != null) 
            stopTime = null; 
        
        running = true;    
        startTime = getTime();
        
        }

        // stop method

        this.stop = function(){ 

            if (running == false)
                return;    
            
            stopTime = getTime();
            running = false; 
            
            }

            // duration method

        this.duration = function(){ 

            if(startTime == null || stopTime == null)
            return 'Undefined';
            else  
            return (stopTime - startTime) / 1000;
                
                }
    `
}

var _StopWatch = new StopWatch();  //new instance of StopWatch

_StopWatch.start();  // start call

_StopWatch.stop();  // stop call

alert(_StopWatch.duration());  //duration call