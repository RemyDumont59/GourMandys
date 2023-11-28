import {useParams} from "react-router-dom";
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
                <h2>{cake.title}</h2>
                {cake.picturePath.map(picture => (
                    <img key={picture.id} src={picture.path} alt={picture.title} />
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