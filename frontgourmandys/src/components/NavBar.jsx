import {NavLink} from "react-router-dom";

function NavBar() {
    return (
        <div>

            <nav>
                <span>Ma navBar</span>
                <NavLink to="/">Accueil</NavLink>
                <NavLink to="/contact">Contact</NavLink>
                <NavLink to="/products">Products</NavLink>
                <NavLink to="/admin">Administrator</NavLink>
            </nav>
        </div>
    );
}

export default NavBar;