export default function Navbar() {
    return `
    <nav class='navbar'>
    <span id="Logo">FOCUS</span>
        <ul>
            
            <li><a id="homeButton">Home</a></li>
            <li><a id="profileButton">Rewards</a></li>
            <li><a id="categoryButton">Department</a></li>
            <li><a id="activityButton">Actions</a></li>
            <li><a id="successButton">Completed</a></li>    
        </ul>
            <div class="burger" onclick="myFunction(this)">
            <div class="line1"></div>
            <div class="line2"></div>
            <div class="line3"></div>
            </div>
    </nav>
            `;
}

