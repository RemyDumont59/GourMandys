import {NavLink} from "react-router-dom";

function MyOffcanvas() {
    return (
        <div className="offcanvas offcanvas-start" id="offcanvasLeft" aria-labelledby="offcanvasLeftLabel">
            <div className="offcanvas-header">
                <h5 className="navbar-brand-title fs-1">Gourmandy&apos;s</h5>
                <button type="button" className="btn-close text-reset shadow-none" data-bs-dismiss="offcanvas" aria-label="Close"></button>
            </div>
            <div className="offcanvas-body">
                <ul>
                    <li data-bs-dismiss="offcanvas">
                        <NavLink to="/" className="text-decoration-none text-black fw-bold">
                            PROMO
                        </NavLink>
                    </li>
                    <li data-bs-dismiss="offcanvas">
                        <NavLink to="/products" className="text-decoration-none text-black fw-bold">
                            LES GOURMANDY&apos;S
                        </NavLink>
                    </li>
                    <li data-bs-dismiss="offcanvas">
                        <NavLink to="/contact" className="text-decoration-none text-black fw-bold">
                            CONTACT
                        </NavLink>
                    </li>
                </ul>
            </div>
        </div>
    );
}

export default MyOffcanvas;