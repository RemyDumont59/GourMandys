import {useSort} from "../hooks/useSort.jsx";
import {FormGroup, Input} from "reactstrap";

export function FilterCakes () {
    const {sortByCategory, allCakes} = useSort();
    return(
        <FormGroup>
            <Input
                id="btnCategories"
                name="btnCategories"
                type="select"
                // style={{boxShadow: 'none', border: '0', color: 'white'}}
            >
                <option>
                    CATEGORIES
                </option>
                <option data-bs-dismiss="offcanvas" onClick={() => sortByCategory(0)}>
                    Marriage
                </option>
                <option data-bs-dismiss="offcanvas" onClick={() => sortByCategory(1)}>
                    Anniversaire
                </option>
                <option data-bs-dismiss="offcanvas" onClick={() => sortByCategory(2)}>
                    Naissance
                </option>
                <option data-bs-dismiss="offcanvas" onClick={() => sortByCategory(3)}>
                    Personnalisé
                </option>
                <option data-bs-dismiss="offcanvas" onClick={allCakes}>
                    Tous les gâteaux
                </option>
            </Input>
        </FormGroup>
    );

}