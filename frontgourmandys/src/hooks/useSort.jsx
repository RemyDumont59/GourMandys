import {useContext} from "react";
import {SortContext} from "./useSortContext.jsx";

export function useSort () {
    const {
        cakes,
        sortedCakes,
        sortByCategory,
        allCakes} = useContext(SortContext);
    return {
        cakes,
        sortedCakes,
        sortByCategory,
        allCakes,
    }
}