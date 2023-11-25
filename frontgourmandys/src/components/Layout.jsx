import { Outlet } from "react-router-dom";
import Footer from "./Footer.jsx";
import NavBar from "./NavBar.jsx";

function Layout() {
    return (
        <>
            <header>
                <NavBar />
            </header>
            <div>
                <Outlet />
            </div>
            <Footer />
        </>
    );
}

export default Layout;