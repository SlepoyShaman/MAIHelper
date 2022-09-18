import axios from "axios";

export default async function fetchData(path, data) {

    const result = await axios.post(`https://localhost:7266/${path}`, data, { headers: { 'Content-Type': 'application/json' } }).then(result => { return result.data })


    return result;
}