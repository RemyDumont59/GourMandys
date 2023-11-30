import {useState} from 'react';

function AddCake() {
    const [cake, setCake] = useState({
        title: "",
        content: "",
        category: 0,
        flavour: 0,
        price: 0,
        pieces: 1,
        minimalQuantity: 0,
        lot: 1,
    });

    const [files, setFiles] = useState([]);

    const handleChange = (e) => {
        setFiles(e.target.files);
    }

    const onSubmit = (e) => {
        e.preventDefault();
        let cakeId;
        fetch("http://localhost:5016/api/Cake", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                title: cake.title,
                category: cake.category,
                flavour: cake.flavour,
                price: cake.price,
                pieces: cake.pieces,
                minimalQuantity: cake.minimalQuantity,
                lot: cake.lot,
            })
        })
            .then((res) => res.json())
            .then((data) => {
                console.log("RESPONSE from api success ", data);
                cakeId = data.cakeId;
                for(let i = 0; i < files.length; i++) {
                    const formData = new FormData();
                    formData.append(`formFile`, files[i], cakeId);
                    fetch("http://localhost:5016/api/PicturePath", {
                        method: "POST",
                        body: formData // working -> JSON.stringify("3")
                    })
                        .then((res) => res.json())
                        .then((data) => {
                            console.log("RESPONSE from api picture ", data);
                        });
                }
            });
    };

    return (
        <form>
            <label>
                Title :
                <input value={cake.title} onChange={(e) => setCake({...cake, title: e.target.value})} />
            </label>
            <label>
                Content :
                <input value={cake.content} onChange={(e) => setCake({...cake, content: e.target.value})} />
            </label>
            <label>
                Price :
                <input type="number" step=".01" value={cake.price === 0 ? '' : cake.price} onChange={(e) => setCake({...cake, price: +e.target.value})} />
            </label>
            <div>
                <label>
                    Category :
                    <input type="number" value={cake.category} onChange={(e) => setCake({...cake, category: +e.target.value})} />
                </label>
                <label>
                    Flavour :
                    <input type="number" value={cake.flavour} onChange={(e) => setCake({...cake, flavour: +e.target.value})} />
                </label>
            </div>
            <div>
                <label>
                    Pieces :
                    <input type="number" value={cake.pieces} onChange={(e) => setCake({...cake, pieces: +e.target.value})} />
                </label>
                <label>
                    Lot :
                    <input type="number" value={cake.lot} onChange={(e) => setCake({...cake, lot: +e.target.value})} />
                </label>
                <label>
                    MinimalQuantity :
                    <input type="number" value={cake.minimalQuantity} onChange={(e) => setCake({...cake, minimalQuantity: +e.target.value})} />
                </label>
            </div>
            {/*<div>*/}
            {/*    <label>*/}
            {/*        Number Cake :*/}
            {/*        <input type="checkbox" checked={cake.isNumberCake} onChange={(e) => setCake({...cake, isNumberCake: e.target.checked})} />*/}
            {/*    </label>*/}
            {/*    <label>*/}
            {/*        Letter Cake :*/}
            {/*        <input type="checkbox" checked={cake.isLetterCake} onChange={(e) => setCake({...cake, isLetterCake: e.target.checked})} />*/}
            {/*    </label>*/}
            {/*</div>*/}
            <div>
                <label>
                    Picture :
                    <input type="file" multiple={true} onChange={(e) => handleChange(e)} />
                </label>
            </div>
            <button onClick={onSubmit}>Submit</button>
        </form>
    );
}

export default AddCake;
