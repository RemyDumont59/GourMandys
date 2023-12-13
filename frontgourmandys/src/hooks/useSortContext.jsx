import {createContext, useContext, useEffect, useState} from 'react';

export const SortContext = createContext({
    cakes: [],
    sortedCakes: [],
    sortByCategory: () => {},
    allCakes: () => {},
});

export function SortContextProvider({ children }) {
    const [cakes, setCakes] = useState([]);
    const [sortedCakes, setSortedCakes] = useState([]);

    const fetchData = async () => {
        await fetch("http://localhost:5016/api/Cake")
            .then(res => res.json())
            // 4. Setting *dogImage* to the image url that we received from the response above
            .then(data => {setCakes(data); setSortedCakes(data)});
    }

    useEffect(() => {
        fetchData().catch();
    }, []);

    const sortByCategory = (cat) => {
        setSortedCakes(cakes.filter((cake) => cake.category === cat));
    };
    const allCakes = () => {
        setSortedCakes(cakes);
    };

    return (
        <SortContext.Provider
            value={{
                cakes,
                sortedCakes,
                sortByCategory,
                allCakes,
            }}
        >
            {children}
        </SortContext.Provider>
    );
}
