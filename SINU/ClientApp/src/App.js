import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import registerServiceWorker from './registerServiceWorker';
import './index.css';
import LayoutLoggedIn from "./LayoutLoggedIn";

import { BrowserRouter as Router, Redirect, Route, Switch } from 'react-router-dom'
import Home from './Home.js';
import { useEffect } from 'react';



const LoggedInLayout = () => {
    return (

            <Switch>
                <Redirect exact from="/" to="/home" />
                <Route exact path="/home">
                    <Home />
                </Route>
            </Switch>
      
    )
}


function App() {

    return (
  
       <h1>test</h1>
    );
}

export default App;

