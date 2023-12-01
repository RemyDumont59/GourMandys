import {Await, NavLink, useLoaderData} from "react-router-dom";
import {Suspense} from "react";
import {Button, Card, CardBody, CardLink, CardSubtitle, CardText, CardTitle} from "reactstrap";

function Products() {
    const { cakes } = useLoaderData();
    return (
        <div className="h-100">
            <h1 className="text-center m-5">Product page</h1>
            <Suspense fallback={'Chargement...'}>
                <Await resolve={cakes}>
                    {(cakes) => (
                        <div className="d-flex flex-wrap gap-3 h-100 w-100 justify-content-center">
                            {cakes.map((cake) => (
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