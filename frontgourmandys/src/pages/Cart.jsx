import { Fragment, useState, useEffect } from "react";
import { BsChevronLeft } from "react-icons/bs";
import { RiDeleteBin5Line } from "react-icons/ri";
const HandleClickDelete = () => {
  console.log("Je supprime");
};
const HandleClickIncrement = () => {
  console.log("incrémente");
};
const HandleClickDeCrement = () => {
  console.log("Décrémente");
};

function Cart() {
  const [basketContain, setBasketContain] = useState([
    {
      id: 1,
      Title: "LA FORET NOIRE",
      Age: "8",
      FirstName: "Bastien",
      Text: "JOYEUX ANNIVERSAIRE" /*Il faut essayer de récuperer l'énum pour le transformer en string*/,
      Flavour: "Chocolat",
      Pieces: 1,
      Price: 22.54,
    },
    {
      id: 2,
      Title: "Fraisier",
      Age: "20",
      FirstName: "Aurélie",
      Text: "non" /*Il faut essayer de récuperer l'énum pour le transformer en string*/,
      Flavour: "Fraise",
      Pieces: 1,
      Price: 15.2,
    },
  ]);

  return (
    <Fragment>
      <div className="container-cart">
        <section>
          <div className="basket-payment">
            <div className="card-block-header">
              <img
                style={{ width: "100%" }}
                src="src/assets/images/formeRecap.svg"
                alt="représente une forme rose"
              />
              <h2 className="h2-left">MON PANIER</h2>
              <h2 className="h2-right">LIVRAISON & PAIEMENT</h2>
            </div>
            <div className="progress-block">
              <div className="round-left"></div>
              <hr />
              <div className="round-right"></div>
            </div>
          </div>
          {basketContain.map((name) => (
            <div key={name.id} className="basket-summary">
              <div className="recap">
                <h3>RECAPITULATIF</h3>
                <div className="bloc-image-recap">
                  <img src="src/assets/images/le-plus-meilleur-gateau-au-monde.jpeg" />
                  <ul>
                    <li className="cake-name">{name.Title.toUpperCase()}</li>
                    <li>PRENOM : {name.FirstName} </li>
                    <li>AGE : {name.Age} </li>
                    <li>TEXTE : {name.Text} </li>
                    <li>PARFUM : {name.Flavour}</li>
                  </ul>
                </div>
                <div className="footer-cart">
                  <button
                    className="delete-basket-cake"
                    onClick={HandleClickDelete}
                  >
                    Supprimer
                  </button>
                  <button
                    className="delete-basket-cake-icon"
                    onClick={HandleClickDelete}
                  >
                    <RiDeleteBin5Line />
                  </button>
                  <button
                    className="increment-basket-cake"
                    onClick={HandleClickDeCrement}
                  >
                    -
                  </button>
                  <input type="text" value="1" />
                  <button
                    className="decrement-basket-cake"
                    onClick={HandleClickIncrement}
                  >
                    +
                  </button>
                  <p>{name.Price}€</p>
                </div>
              </div>
            </div>
          ))}
          <div className="keep-going">
            <a href="#">
              <button>
                {" "}
                <BsChevronLeft className="arrow-icon" /> Continuer vos achats
              </button>
            </a>
          </div>
        </section>
        <aside>
          <div className="summary-card">
            <h4>RECAPITULATIF</h4>
            <ul>
              <li>
                Nombre d'Articles <span>1</span>
              </li>
              <hr />
              <li>
                Sous-total <span>4,25 €</span>
              </li>
              <hr />
              <li className="li-summary-card">
                Total TTC <span>4,25 €</span>
              </li>
            </ul>
            <a href="#">
              <button>Précommander</button>
            </a>
          </div>
        </aside>
      </div>
      <div className="join">
        <h4>VOUS AUSSI VOUS AIMEZ LA GOURMANDY'S ? REJOIGNEZ NOUS ! 😍</h4>
      </div>
    </Fragment>
  );
}

export default Cart;
