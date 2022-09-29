import React from 'react';

import Nav from './Components/Nav/Nav';
import { BrowserRouter, Route, Routes } from 'react-router-dom';

import Labs from "./Pages/Labs/Labs";
import Main from './Pages/Main/Main';


function App(props) {
    return (
        <div>
            <BrowserRouter>
                <Nav />
                <Routes>
                    <Route path="/" element={<Main />} />
                    <Route path="/Labs" element={<Labs />} />
                </Routes>
            </BrowserRouter>
        </div>
    );
}

export default App;
