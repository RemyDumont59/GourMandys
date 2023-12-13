import {NavLink, useParams} from "react-router-dom";
import {useEffect, useState} from "react";
import UseFetchData from "../hooks/useFetchData.js";

function Product() {
    const {id} = useParams();
    const [data, setData] = useState([])

    useEffect(() => {
        UseFetchData(`http://localhost:5016/api/Cake/${id}`)
            .then(data => setData(data));
    }, [id]);

    const { cake } = data;

    if (cake !== undefined) {
        return (
            <div>
                <NavLink to="/products">
                    <button className="fs-3 btn btn-primary m-3">Retour vers les produits</button>
                </NavLink>
                <h2>{cake.title}</h2>
                {cake.picturePath.map(picture => (
                    <img width={100} height={100} key={picture.id} src={picture.path} alt={picture.title} />
                ))}
                <p>{cake.content}</p>
            </div>
        )
    } else {
        return (
            <div>
                <h2>chargement...</h2>
            </div>
        )
    }
}

export default Product;