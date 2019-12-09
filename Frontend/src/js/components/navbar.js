export default function Navbar() {
    return `
    <nav class='navbar'>
    <span id="Logo" title="Click to see Your Profile">FOCUS</span>
        <ul>
            <li><a id="homeButton">Priorities</a></li>
            <li><a id="profileButton">Rewards</a></li>
            <li><a id="categoryButton">Departments</a></li>
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

