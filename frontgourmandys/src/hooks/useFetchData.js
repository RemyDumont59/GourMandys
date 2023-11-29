async function useFetchData(url){
    const response = await fetch(url);
    return await response.json();
}

export default useFetchData;