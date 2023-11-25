import {Await, NavLink, useLoaderData} from "react-router-dom";
import {Suspense} from "react";

function Products() {
    const { posts } = useLoaderData();
    return (
        <div>
            <h1>Product page</h1>
            <Suspense fallback={'Chargement...'}>
                <Await resolve={posts}>
                    {(posts) => (
                        <ul>
                            {posts.map((post) => (
                                <li key={post.id}>
                                    <NavLink to={`http://localhost:5173/products/${post.id}`}>{post.title}</NavLink>
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