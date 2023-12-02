import {Button, NavbarBrand} from "reactstrap";
import cart from "../assets/icons/cart.svg";

function Header() {
    return (
        <div className="d-flex align-items-center px-3 px-md-5" style={{height: '100px'}}>
            <NavbarBrand href="/" className="me-auto">
                <p className="navbar-brand-title">Gourmandy&apos;s</p>
            </NavbarBrand>
            <div className="d-flex align-items-center gap-4 gap-md-5">
                <button className="my-count p-3 rounded-4 d-none d-sm-block">Mon Compte</button>
                <Button className="position-relative border-0 bg-white rounded-5">
                    <div className="rounded-5 border border-black text-center fw-bold bg-info position-absolute" style={{width: '25px', height: '25px', left: '19px'}}>0</div>
                    <img width={45} height={45} src={cart} alt="icon panier"/>
                </Button>
            </div>
        </div>
    );
}

export default Header;