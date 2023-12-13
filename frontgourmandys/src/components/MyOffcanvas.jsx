import {NavLink} from "react-router-dom";
import {FilterCakes} from "./FilterCakes.jsx";
import {CuteCakes} from "./CuteCakes.jsx";

function MyOffcanvas() {
    return (
        <div className="myOffcanvas offcanvas offcanvas-start" id="offcanvasLeft" aria-labelledby="offcanvasLeftLabel">
            <div className="offcanvas-header position-relative d-flex justify-content-center">
                <h5 className="myOffcanvas__brand-title">Gourmandy&apos;s</h5>
                <button type="button" className="btn-close text-reset shadow-none position-absolute" style={{top: '25px', right: '25px'}} data-bs-dismiss="offcanvas" aria-label="Close"></button>
            </div>
            <div className="offcanvas-body p-0">
                <div className="d-flex justify-content-center p-3 myOffcanvas__account-btn mb-5">
                    <button className="my-account p-3 rounded-4 d-none d-sm-block">Mon Compte</button>
                </div>
                <div className="text-center mb-5">
                    <NavLink to="/" className="text-decoration-none text-black fw-bold">
                        {({isActive}) => (
                        <p data-bs-dismiss="offcanvas" className="myOffcanvas__item--onHover" style={{backgroundColor: isActive ? "#fb889c" : "", color: isActive ? 'white' : ''}}>
                                <span>
                                    <img className="mx-2" height={20} width={20}
                                         src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOS40MjEiIGhlaWdodD0iMTkuNDIxIiB2aWV3Qm94PSIwIDAgMTkuNDIxIDE5LjQyMSI+CiAgPGcgaWQ9ImJhZGdlXzJfIiBkYXRhLW5hbWU9ImJhZGdlICgyKSIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMC4xNTkgMC4xMDcpIj4KICAgIDxwYXRoIGlkPSJUcmFjw6lfNzM4NDYiIGRhdGEtbmFtZT0iVHJhY8OpIDczODQ2IiBkPSJNMTIuNjE0LDE5LjFhMi4xNTgsMi4xNTgsMCwwLDEtLjg5NS0uMTkzbC0xLjYtLjcyOGExLjM2NywxLjM2NywwLDAsMC0xLjEzLDBsLTEuNi43MjhBMi4xNjIsMi4xNjIsMCwwLDEsNC40NjgsMTcuN0wzLjg1LDE2LjA1NGExLjM2MywxLjM2MywwLDAsMC0uOC0uOEwxLjQsMTQuNjM4QTIuMTYyLDIuMTYyLDAsMCwxLC4yLDExLjcxOWwuNzI4LTEuNmExLjM3LDEuMzcsMCwwLDAsMC0xLjEzbC0uNzI5LTEuNkEyLjE2MiwyLjE2MiwwLDAsMSwxLjQsNC40NjdsMS42NDgtLjYxOGExLjM2MywxLjM2MywwLDAsMCwuOC0uOEw0LjQ2NywxLjRBMi4xNjIsMi4xNjIsMCwwLDEsNy4zODYuMTk0bDEuNi43MjhhMS4zNjcsMS4zNjcsMCwwLDAsMS4xMywwTDExLjcxOS4yQTIuMTYyLDIuMTYyLDAsMCwxLDE0LjYzOCwxLjRsLjYxOCwxLjY0OGExLjM2MywxLjM2MywwLDAsMCwuOC44bDEuNjQ4LjYxOEEyLjE2MiwyLjE2MiwwLDAsMSwxOC45MSw3LjM4N2wtLjcyOCwxLjZhMS4zNywxLjM3LDAsMCwwLDAsMS4xM2wuNzI4LDEuNkEyLjE2MiwyLjE2MiwwLDAsMSwxNy43LDE0LjYzOWwtMS42NDguNjE4YTEuMzYzLDEuMzYzLDAsMCwwLS44LjhMMTQuNjM3LDE3LjdhMi4xNiwyLjE2LDAsMCwxLTIuMDIzLDEuNFptLTMuMDYyLTEuODRhMi4xNjMsMi4xNjMsMCwwLDEsLjg5NC4xOTNsMS42LjcyOGExLjM2NiwxLjM2NiwwLDAsMCwxLjg0NC0uNzYzbC42MTgtMS42NDhhMi4xNTksMi4xNTksMCwwLDEsMS4yNjQtMS4yNjRsMS42NDgtLjYxOGExLjM2NiwxLjM2NiwwLDAsMCwuNzYzLTEuODQ0bC0uNzI4LTEuNmEyLjE2NCwyLjE2NCwwLDAsMSwwLTEuNzg5bC43MjgtMS42YTEuMzY2LDEuMzY2LDAsMCwwLS43NjMtMS44NDRMMTUuNzc1LDQuNmEyLjE1OSwyLjE1OSwwLDAsMS0xLjI2NC0xLjI2NGwtLjYxOC0xLjY0OEExLjM2NiwxLjM2NiwwLDAsMCwxMi4wNDkuOTJsLTEuNi43MjhhMi4xNjgsMi4xNjgsMCwwLDEtMS43ODgsMGwtMS42LS43M2ExLjM2NiwxLjM2NiwwLDAsMC0xLjg0NC43NjNMNC42LDMuMzNBMi4xNjIsMi4xNjIsMCwwLDEsMy4zMzEsNC42bC0xLjY0OC42MThBMS4zNjcsMS4zNjcsMCwwLDAsLjkxOSw3LjA1NmwuNzI4LDEuNmEyLjE2NCwyLjE2NCwwLDAsMSwwLDEuNzg5bC0uNzI4LDEuNmExLjM2NiwxLjM2NiwwLDAsMCwuNzYzLDEuODQ0bDEuNjQ4LjYxOGEyLjE1OSwyLjE1OSwwLDAsMSwxLjI2NCwxLjI2NGwuNjE4LDEuNjQ4YTEuMzY2LDEuMzY2LDAsMCwwLDEuODQ0Ljc2M2wxLjYtLjcyOGEyLjE4NywyLjE4NywwLDAsMSwuOS0uMTkzWm0uNzMtMTUuOThoLjAwOFoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0wLjAwMSAwLjA1MSkiIGZpbGw9IiNFNzYwODciIHN0cm9rZT0iI0U3NjA4NyIgc3Ryb2tlLXdpZHRoPSIwLjMiLz4KICAgIDxwYXRoIGlkPSJUcmFjw6lfNzM4NDciIGRhdGEtbmFtZT0iVHJhY8OpIDczODQ3IiBkPSJNNy45OSw4Ljk4QTEuOTksMS45OSwwLDEsMSw5Ljk4LDYuOTksMS45OTMsMS45OTMsMCwwLDEsNy45OSw4Ljk4Wm0wLTMuMTg0QTEuMTk0LDEuMTk0LDAsMSwwLDkuMTg0LDYuOTksMS4yLDEuMiwwLDAsMCw3Ljk5LDUuOFoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xLjIyNSAtMS4wMjEpIiBmaWxsPSIjRTc2MDg3IiBzdHJva2U9IiNFNzYwODciIHN0cm9rZS13aWR0aD0iMC4zIi8+CiAgICA8cGF0aCBpZD0iVHJhY8OpXzczODQ4IiBkYXRhLW5hbWU9IlRyYWPDqSA3Mzg0OCIgZD0iTTE0Ljk5LDE3Ljk4YTEuOTksMS45OSwwLDEsMSwxLjk5LTEuOTlBMS45OTMsMS45OTMsMCwwLDEsMTQuOTksMTcuOThabTAtMy4xODRhMS4xOTQsMS4xOTQsMCwxLDAsMS4xOTQsMS4xOTRBMS4yLDEuMiwwLDAsMCwxNC45OSwxNC44WiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTIuNjUyIC0yLjg1NikiIGZpbGw9IiNFNzYwODciIHN0cm9rZT0iI0U3NjA4NyIgc3Ryb2tlLXdpZHRoPSIwLjMiLz4KICAgIDxwYXRoIGlkPSJUcmFjw6lfNzM4NDkiIGRhdGEtbmFtZT0iVHJhY8OpIDczODQ5IiBkPSJNOC40LDE1LjU1M2EuNC40LDAsMCwxLS4zMzUtLjYxMWw1LjU3Mi04Ljc1NmEuNC40LDAsMSwxLC42NzEuNDI3TDguNzM0LDE1LjM2OWEuNC40LDAsMCwxLS4zMzYuMTg0WiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTEuNjMzIC0xLjIyNSkiIGZpbGw9IiNFNzYwODciIHN0cm9rZT0iI0U3NjA4NyIgc3Ryb2tlLXdpZHRoPSIwLjMiLz4KICA8L2c+Cjwvc3ZnPgo="
                                         alt="icon promo %"
                                    />
                                </span> PROMO
                        </p>
                        )}
                    </NavLink>
                    <NavLink to="/products" className="text-decoration-none text-black fw-bold">
                        {({isActive}) => (
                            <p data-bs-dismiss="offcanvas" className="myOffcanvas__item--onHover" style={{backgroundColor: isActive ? "#fb889c" : "", color: isActive ? 'white' : ''}}>
                                    <span>
                                        <img className="mx-2" height={20} width={20} src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOS4wODMiIGhlaWdodD0iMTkuMDgzIiB2aWV3Qm94PSIwIDAgMTkuMDgzIDE5LjA4MyI+CiAgPHBhdGggaWQ9ImNoZWYiIGQ9Ik0xMy45MzcsMi4zMjNhNC4yNjYsNC4yNjYsMCwwLDAtLjYxOC4wNTEsNC42LDQuNiwwLDAsMC04LjA1NSwwLDQuMjY2LDQuMjY2LDAsMCwwLS42MTgtLjA1MUE0LjY1MSw0LjY1MSwwLDAsMCwwLDYuOTY5YTQuNiw0LjYsMCwwLDAsMi4zMjMsNC4wMDl2NS44NjNhMS43NDQsMS43NDQsMCwwLDAsMS43NDIsMS43NDJIMTQuNTE4YTEuNzQ0LDEuNzQ0LDAsMCwwLDEuNzQyLTEuNzQyVjEwLjk3OGE0LjYsNC42LDAsMCwwLDIuMzIzLTQuMDA5LDQuNjUxLDQuNjUxLDAsMCwwLTQuNjQ2LTQuNjQ2Wm0uNTgxLDE1LjFINC4wNjVhLjU4MS41ODEsMCwwLDEtLjU4MS0uNTgxVjE1LjFIMTUuMXYxLjc0MkEuNTgxLjU4MSwwLDAsMSwxNC41MTgsMTcuNDIyWm0uOTExLTcuMzE4YS41ODIuNTgyLDAsMCwwLS4zMy41MjR2My4zMUgzLjQ4NHYtMy4zMWEuNTgyLjU4MiwwLDAsMC0uMzMtLjUyNEEzLjQ3NiwzLjQ3NiwwLDAsMSw0LjY0NiwzLjQ4NGMuMDQ5LDAsLjEwOC4wMTcuMTU5LjAyYTQuNiw0LjYsMCwwLDAtLjE1OSwxLjE0MS41ODEuNTgxLDAsMSwwLDEuMTYxLDAsMy40ODQsMy40ODQsMCwwLDEsNi45NjksMCwuNTgxLjU4MSwwLDAsMCwxLjE2MSwwQTQuNiw0LjYsMCwwLDAsMTMuNzc5LDMuNWMuMDUxLDAsLjEwOS0uMDIuMTU5LS4wMkEzLjQ3NiwzLjQ3NiwwLDAsMSwxNS40MjksMTAuMVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKDAuMjUgMC4yNSkiIGZpbGw9IiNlNzYwODciIHN0cm9rZT0iI2U3NjA4NyIgc3Ryb2tlLXdpZHRoPSIwLjUiLz4KPC9zdmc+Cg==" alt="icon toque de chef"/>
                                    </span> LES GOURMANDY&apos;S
                            </p>
                        )}
                    </NavLink>
                    <NavLink to="/contact" className="text-decoration-none text-black fw-bold">
                        {({isActive}) => (
                        <p data-bs-dismiss="offcanvas" className="myOffcanvas__item--onHover" style={{backgroundColor: isActive ? "#fb889c" : "", color: isActive ? 'white' : ''}}>
                                <span>
                                    <img className="mx-2" height={20} width={20} src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxOC41IiBoZWlnaHQ9IjE4LjUiIHZpZXdCb3g9IjAgMCAxOC41IDE4LjUiPgogIDxwYXRoIGlkPSJUcmFjw6lfNzM4OTQiIGRhdGEtbmFtZT0iVHJhY8OpIDczODk0IiBkPSJNMTUuOTY1LDkuMzQ3aC0uOTQ0QTUuNTg4LDUuNTg4LDAsMCwwLDkuNDM5LDMuNzY0VjIuODIxQTYuNTMxLDYuNTMxLDAsMCwxLDE1Ljk2NSw5LjM0N1ptLTYuNTI2LTQuOXYuOTQyYTMuOTU3LDMuOTU3LDAsMCwxLDMuOTU0LDMuOTU1aC45NDRBNC45LDQuOSwwLDAsMCw5LjQzOSw0LjQ0OVpNOS4yNSwwYTkuMjUsOS4yNSwwLDEsMCwwLDE4LjUuNTcxLjU3MSwwLDAsMCwwLTEuMTQyLDguMTA5LDguMTA5LDAsMSwxLDguMTA4LTguMTA4LDUuMjU2LDUuMjU2LDAsMCwxLTIuNDE4LDQuNSwzLjUsMy41LDAsMCwxLTEuNjc2LjQzMSwyLjY4MSwyLjY4MSwwLDAsMCwuOS0uODY2LDEuMjE2LDEuMjE2LDAsMCwwLC4xMzUtLjIsOS4yLDkuMiwwLDAsMCwuMzE0LTEuNDI2Yy4xMzgtLjYtMi42MzgtMS43OC0yLjg3OS0xLjAyN2E3LjIsNy4yLDAsMCwxLS40LDEuMzkyYy0uMTU2LjIwNy0uNTQuMTA5LS43OC0uMUM5LjkyNywxMS40MjEsOS4yMjEsMTAuNjI5LDguNiwxMGgwTDguNTUxLDkuOTUsOC41LDkuOWgwQzcuODcyLDkuMjc4LDcuMDc5LDguNTc0LDYuNTQsNy45NGMtLjItLjI0LS4zLS42MjQtLjEtLjc4YTcuMiw3LjIsMCwwLDEsMS4zOTItLjRjLjc1MS0uMjQtLjQyNS0zLjAxNy0xLjAyOC0yLjg3OUE5LjE0Nyw5LjE0NywwLDAsMCw1LjM4NCw0LjJhMS4zMzksMS4zMzksMCwwLDAtLjIuMTM2Yy0xLjU4NSwxLTEuNzksMy40NDQtLjI0Miw1LjI2Mi41OS43LDEuMiwxLjM2OCwxLjgzOCwyLjAyNWwwLDAsLjA1NC4wNTEuMDUuMDU0LDAsMGExNy40MDksMTcuNDA5LDAsMCwwLDIuNywyLjQxYzIuNjYzLDEuNzc5LDQuNzA3LDEuMjgyLDUuOTExLjYyMmE2LjM4NCw2LjM4NCwwLDAsMCwzLjAwOC01LjVBOS4yNjEsOS4yNjEsMCwwLDAsOS4yNSwwWiIgZmlsbD0iI2U3NjA4NyIvPgo8L3N2Zz4K" alt="icon promo %"/>
                                </span> CONTACT
                        </p>
                        )}
                    </NavLink>
                </div>
                <div className="mb-5">
                    <div className="myOffcanvas__item ps-3 mb-2 fw-bold p-1">
                        FILTRES
                    </div>
                    <FilterCakes/>
                    <CuteCakes/>
                </div>
            </div>
        </div>
    );
}

export default MyOffcanvas;