import {useParams} from "react-router-dom";

function Product() {
    const {id} = useParams();

    return (
        <div>
            <h2>Ma page produit</h2>
            <p>Produit Id : {id}</p>
        </div>
    );
}

export default Product;