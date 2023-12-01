import { Outlet } from "react-router-dom";
import Footer from "./Footer.jsx";
import NavBar from "./NavBar.jsx";
import {NavbarBrand} from "reactstrap";
import logoutIcon from "../assets/icons/logout.svg";

function Layout() {
    return (
        <>
            <header>
                <div className="d-flex align-items-center" style={{height: '100px', padding: '0 50px'}}>
                    <NavbarBrand href="/" className="me-auto" style={{fontSize: '2.2rem'}}>
                        Gourmandy's
                    </NavbarBrand>
                    <div>
                        <img width={20} height={20} src={logoutIcon} alt="icon logout"/>
                    </div>
                </div>
            </header>
            <div>
                <div className='sticky-top bg-white'>
                    <NavBar />
                </div>
                <Outlet />
            </div>
            <Footer />
        </>
    );
}

export default Layout;