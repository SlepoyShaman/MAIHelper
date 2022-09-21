import fetchData from '../Hooks/FetchHook';

let state = fetchData('Home').then(res => res);


export default state;