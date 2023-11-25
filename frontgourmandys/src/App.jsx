import './App.css'
import NavBar from "./components/NavBar.jsx";
import Products from "./pages/Products.jsx";
import Footer from "./components/Footer.jsx";
import {createBrowserRouter, defer, NavLink, Outlet, RouterProvider} from "react-router-dom";
import Layout from "./components/Layout.jsx";
import Contact from "./pages/Contact.jsx";
import ErrorPage from "./pages/ErrorPage.jsx";
import Product from "./pages/Product.jsx";
import HomePage from "./pages/HomePage.jsx";

const router = createBrowserRouter([
    {
        path:'/',
        element: <Layout />,
        errorElement: <ErrorPage />,
        children: [
            {
                path: '',
                element: <HomePage />,
            },
            {
                path: 'products',
                element: <div>
                    <h2>asideBar</h2>
                    <main>
                        <Outlet />
                    </main>
                </div>,
                children: [
                    {
                        path: '',
                        element: <Products />,
                        loader: () => {
                            const posts = fetch('https://jsonplaceholder.typicode.com/posts?_limit=10')
                                .then(r => r.json());
                            return defer({
                                posts,
                            })
                        }
                    },
                    {
                        path: ':id',
                        element: <Product />,
                    }
                ]
            },
            {
                path: 'contact',
                element: <Contact />,
            },
        ],
    }
]);

function App() {
  return <RouterProvider router={router}/>
}

export default App
