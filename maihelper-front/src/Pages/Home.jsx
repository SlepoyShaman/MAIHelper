import React from 'react'
import logo from '../logo.svg';
import { Link } from 'react-router-dom'
import axios from 'axios'
import {useState,useEffect} from 'react'
import fetchData from '../Hooks/FetchHook';

export default function Home() {
    const [test, setTest] = useState();

  const tes=async () => setTest(await fetchData("WeatherForecast",{id:3}))
    tes()
  return (
      
    <div><header className="App-header">
    Id:{test}
    <img src={logo} className="App-logo" alt="logo" />
    <p>
              Edit <code>src/App.js</code> and save to reload.
              {test}
    </p>
    <a
      className="App-link"
      href="https://reactjs.org"
      target="_blank"
      rel="noopener noreferrer"
    >
      Learn React
    </a>
  </header>
  <Link to ="sas">To Test</Link>
  </div>

  )
}
