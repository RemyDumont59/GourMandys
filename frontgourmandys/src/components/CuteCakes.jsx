import {FormGroup, Input} from "reactstrap";

export function CuteCakes () {
    return(
        <FormGroup>
            <Input
                id="btnCategories"
                name="btnCuteCategories"
                type="select"
            >
                <option>
                    MIGNIARDISES
                </option>
                <option data-bs-dismiss="offcanvas">
                    Cup Cakes
                </option>
                <option data-bs-dismiss="offcanvas">
                    Minis façon number
                </option>
                <option data-bs-dismiss="offcanvas">
                    Minis façon letter
                </option>
                <option data-bs-dismiss="offcanvas">
                    Macarons
                </option>
                <option data-bs-dismiss="offcanvas">
                    Toutes les mignardises
                </option>
            </Input>
        </FormGroup>
    );

}