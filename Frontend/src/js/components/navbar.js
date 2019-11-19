export default function Navbar() {
    return `
    
    
    <nav class='navbar'>
    <div class='navwrap'>
        <ul>
            <li><a id="nav__home">Home</a></li>
            <li><a id="nav__profile">Profile</a></li>
            <li><a id="nav__todo">To-Do</a></li>
            <li><a id="nav__planner">Planner</a></li>
        </ul>
        <div class="burger">
            <div class="line1"></div>
            <div class="line2"></div>
            <div class="line3"></div>
        </div>
        
    </div>
    </nav>
    `;
}