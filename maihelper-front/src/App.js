

import { BrowserRouter, Link, Route,Routes } from 'react-router-dom';
import './App.css';

import Test from './Pages/Test';
import Home from './Pages/Home';

function App() {
   

  return (
    <div className="App">
     <BrowserRouter>
     <Routes>
      <Route path = "/" element ={<Home/>}/>
     <Route path ="sas" element={<Test/>}/>
     </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
