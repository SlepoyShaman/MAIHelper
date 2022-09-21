import React from 'react';
import './App.css';
import { BrowserRouter, Link, Route,Routes } from 'react-router-dom';

import Nav from './Components/Nav';
import Header from './Components/Header/Header';


function App() {
    return (
        <div className="App">
            <Nav />
            <Header />
        </div>
    );
}

export default App;
