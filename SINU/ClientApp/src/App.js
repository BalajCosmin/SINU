import Student from "./components/First Page/Student";
import Teacher from "./components/First Page/Teacher";
import React, { useState } from "react";
import {Routes, Route, Switch } from 'react-router-dom'
import Home from "./components/First Page/Home"
import Welcome from "./components/First Page/Welcome"


function App() {
  return (
      <div className="container">
          <Routes>
              <Route exact path="/" element={<Welcome/>}> </Route>
              <Route exact path="/home" element={<Home />}> </Route>
         
          </Routes>
    </div>
    
  );
}

export default App;
