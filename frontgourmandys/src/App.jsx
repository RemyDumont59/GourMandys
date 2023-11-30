import './App.css'
import Products from "./pages/Products.jsx";
import {createBrowserRouter, defer, RouterProvider} from "react-router-dom";
import Layout from "./components/Layout.jsx";
import Contact from "./pages/Contact.jsx";
import ErrorPage from "./pages/ErrorPage.jsx";
import Product from "./pages/Product.jsx";
import HomePage from "./pages/HomePage.jsx";
import AddCake from "./pages/admin/AddCake.jsx";

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
                children: [
                    {
                        path: '',
                        element: <Products />,
                        loader: () => {
                            const cakes = fetch('http://localhost:5016/api/Cake')
                                .then(r => r.json());
                            return defer({
                                cakes,
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
            {
                path: 'admin',
                element: <AddCake />
            }
        ],
    }
]);

function App() {
  return <RouterProvider router={router}/>
}

export default App
