import {NavbarBrand} from "reactstrap";
import {NavLink} from "react-router-dom";

function Header() {
    return (
        <div className="header d-flex align-items-center px-3 px-md-5" style={{height: '100px'}}>
            <NavbarBrand href="/" className="me-auto">
                <p className="header__brand-title">Gourmandy&apos;s</p>
            </NavbarBrand>
            <div className="d-flex align-items-center gap-4 gap-md-5">
                <button className="my-account p-3 rounded-4 d-none d-sm-block">Mon Compte</button>
                <NavLink to="/cart">
                    <div className="position-relative border-0 bg-white rounded-5">
                            <div className="rounded-5 border border-black text-center fw-bold bg-info position-absolute"
                                 style={{width: '25px', height: '25px', left: '7px'}}>0
                            </div>
                            <img width={45} height={45} src="/src/assets/icons/cart.svg" alt="icon panier"/>
                    </div>
                </NavLink>
            </div>
        </div>
    );
}

export default Header;