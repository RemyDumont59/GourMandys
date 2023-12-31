import { Outlet } from "react-router-dom";
import Footer from "./Footer.jsx";
import NavBar from "./NavBar.jsx";
import Header from "./Header.jsx";
import MyOffcanvas from "./MyOffcanvas.jsx";
import {SortContextProvider} from "../hooks/useSortContext.jsx";

function Layout() {
    return (
        <>
            <header>
                <Header />
            </header>
            <div>
                <div className='sticky-top bg-white'>
                    <NavBar />
                </div>
                <SortContextProvider>
                    <MyOffcanvas />
                    <Outlet />
                </SortContextProvider>
            </div>
            <Footer />
        </>
    );
}

export default Layout;
