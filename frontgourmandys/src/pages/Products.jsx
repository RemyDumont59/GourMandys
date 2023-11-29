import {Await, NavLink, useLoaderData} from "react-router-dom";
import {Suspense} from "react";

function Products() {
    const { cakes } = useLoaderData();
    return (
        <div>
            <h1>Product page</h1>
            <Suspense fallback={'Chargement...'}>
                <Await resolve={cakes}>
                    {(cakes) => (
                        <ul>
                            {cakes.map((cake) => (
                                <li key={cake.id}>
                                    <NavLink to={`http://localhost:5173/products/${cake.id}`}>
                                        <h2>{cake.title}</h2>
                                        <img src={cake.picturePath[0] && cake.picturePath[0].path} alt={cake.title}/>
                                        <p>{cake.content}</p>
                                    </NavLink>
                                </li>
                            ))}
                        </ul>
                    )}
                </Await>
            </Suspense>
        </div>
    );
}

export default Products;