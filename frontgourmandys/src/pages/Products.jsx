import {Await, NavLink} from "react-router-dom";
import {Suspense} from "react";
import {Button, Card, CardBody, CardText, CardTitle} from "reactstrap";
import {useSort} from "../hooks/useSort.jsx";

function Products() {
    const { sortedCakes } = useSort();

    return (
        <div className="position-relative">
            <button data-bs-toggle="offcanvas"
                data-bs-target="#offcanvasLeft"
                aria-controls="offcanvasLeft"
                className="btnResetFilter"><img src="/src/assets/icons/filter_icon.svg"
                                                                       alt="icône boutton reset"/></button>
            <h1 className="text-center m-5">Product page</h1>
            <Suspense fallback={'Chargement...'}>
                <Await resolve={sortedCakes}>
                    {(sortedCakes) => (
                        <div className="d-flex flex-wrap gap-3 h-100 w-100 justify-content-center">
                            {sortedCakes.map((cake) => (
                                <NavLink
                                    key={cake.id} to={`http://localhost:5173/products/${cake.id}`}>
                                    <Card
                                        style={{
                                            width: '18rem',
                                            height: '400px'
                                        }}
                                    >
                                        <CardBody>
                                            <CardTitle tag="h5">
                                                {cake.title}
                                            </CardTitle>
                                        </CardBody>
                                        <CardBody className="overflow-hidden h-50">
                                            <img
                                                className="imgCake"
                                                alt={cake.title}
                                                src={cake.picturePath[0] && cake.picturePath[0].path}
                                                width="100%"
                                            />
                                        </CardBody>
                                        <CardBody>
                                            <CardText>
                                                {cake.content}
                                            </CardText>
                                            <Button>
                                                Voir
                                            </Button>
                                        </CardBody>
                                    </Card>
                                </NavLink>
                            ))}
                        </div>
                    )}
                </Await>
            </Suspense>
        </div>
    );
}

export default Products;