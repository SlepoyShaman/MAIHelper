import React from 'react';
import ReactDOM from 'react-dom/client';
import reportWebVitals from './reportWebVitals';

import state from './redux/state';

import App from './App';

import manifest from './manifest.json';

import './index.css'

console.log(manifest);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <React.StrictMode>
        <App state={state} manifest={manifest} />
    </React.StrictMode>
);

reportWebVitals();
