import {Await, NavLink} from "react-router-dom";
import {Suspense, useEffect} from "react";
import {Card, CardBody, CardText} from "reactstrap";
import {useSort} from "../hooks/useSort.jsx";

function Products() {
    const { sortedCakes } = useSort();

    useEffect(() => {
        console.log("sortedCakes qty : ", sortedCakes.length);
    }, [sortedCakes]);

    return (
        <div className="position-relative">
            <button data-bs-toggle="offcanvas"
                data-bs-target="#offcanvasLeft"
                aria-controls="offcanvasLeft"
                className="btnResetFilter"><img src="/src/assets/icons/filter_icon.svg"
                                                                       alt="icône boutton reset"/></button>
            <NavLink to="/promotions">
                <div className="banner-promo mt-5 position-relative">
                    <div className="position-absolute w-100 h-100 d-flex flex-row-reverse align-items-center">
                        <h2 className="banner-promo__text">{"Découvrez nos offres de noël !".toUpperCase()}</h2>
                    </div>
                    <img className="" src="/src/assets/images/banniere-web-noel-gourmandys.webp" alt="bannière avec des gâteaux de noël alignés"/>
                </div>
            </NavLink>
            <Suspense fallback={'Chargement...'}>
                <Await resolve={sortedCakes}>
                    {(sortedCakes) => (
                        <div className="d-flex flex-wrap gap-5 h-100 w-100 justify-content-center p-5">
                            {sortedCakes.map((cake) => (
                                    <Card
                                        key={cake.id}
                                        style={{
                                            width: '18rem',
                                            height: '400px'
                                        }}
                                        className="myCard position-relative"
                                    >
                                        {/*<CardBody>*/}
                                        {/*    <CardTitle tag="h5">*/}
                                        {/*        {cake.title}*/}
                                        {/*    </CardTitle>*/}
                                        {/*</CardBody>*/}
                                        <CardBody className="overflow-hidden h-50">
                                            <NavLink
                                                to={`http://localhost:5173/products/${cake.id}`}>
                                                <img
                                                    alt={cake.title}
                                                    src={cake.picturePath[0] && cake.picturePath[0].path}
                                                    width="100%"
                                                />
                                            </NavLink>
                                        </CardBody>
                                        <CardBody>
                                            <CardText className="text-center">
                                                {cake.content}
                                            </CardText>
                                            <button className="myCard__btnProductsAddToCart position-absolute bottom-0 start-0">
                                                <span>
                                                    <img src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyMC41NyIgaGVpZ2h0PSIxNS45OTkiIHZpZXdCb3g9IjAgMCAyMC41NyAxNS45OTkiPgogIDxwYXRoIGlkPSJJY29uX2F3ZXNvbWUtc2hvcHBpbmctYmFza2V0IiBkYXRhLW5hbWU9Ikljb24gYXdlc29tZS1zaG9wcGluZy1iYXNrZXQiIGQ9Ik0yMC41Nyw4LjgyMXYuNTcxYS44NTcuODU3LDAsMCwxLS44NTcuODU3aC0uMjg2bC0uOTMzLDYuNTI4YTEuNzE0LDEuNzE0LDAsMCwxLTEuNywxLjQ3MkgzLjc3MmExLjcxNCwxLjcxNCwwLDAsMS0xLjctMS40NzJsLS45MzMtNi41MjhILjg1N0EuODU3Ljg1NywwLDAsMSwwLDkuMzkyVjguODIxYS44NTcuODU3LDAsMCwxLC44NTctLjg1N2gyLjRMNy4wNzUsMi43MjFBMS4xNDMsMS4xNDMsMCwxLDEsOC45MjQsNC4wNjVsLTIuODM2LDMuOWg4LjM5NGwtMi44MzYtMy45YTEuMTQzLDEuMTQzLDAsMCwxLDEuODQ4LTEuMzQ0bDMuODEzLDUuMjQzaDIuNEEuODU3Ljg1NywwLDAsMSwyMC41Nyw4LjgyMVptLTkuNDI4LDYuMjg1di00YS44NTcuODU3LDAsMSwwLTEuNzE0LDB2NGEuODU3Ljg1NywwLDAsMCwxLjcxNCwwWm00LDB2LTRhLjg1Ny44NTcsMCwwLDAtMS43MTQsMHY0YS44NTcuODU3LDAsMCwwLDEuNzE0LDBabS04LDB2LTRhLjg1Ny44NTcsMCwwLDAtMS43MTQsMHY0YS44NTcuODU3LDAsMCwwLDEuNzE0LDBaIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgwIC0yLjI1KSIgZmlsbD0iI2ZmZiIvPgo8L3N2Zz4K" alt="icône panier" />
                                                </span> Ajouter au panier
                                            </button>
                                        </CardBody>
                                    </Card>
                            ))}
                        </div>
                    )}
                </Await>
            </Suspense>
        </div>
    );
}

export default Products;