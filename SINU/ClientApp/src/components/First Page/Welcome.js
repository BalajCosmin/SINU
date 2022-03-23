import Login from "./Login";
import Register from "./Register";
import React from "react";
import Teacher from "./Teacher"
import Student from "./Student"
import '../../index.css'



function Welcome(props) {




    return (

     

        <div class="container" style={{ width: "100%", height: "100%", position: "static", top: "0%", left:"0%" }}>
            <div class="teacherContainer">
            <Teacher />
            </div>
            <div class="studentContainer">
                <Student />
                </div>

        </div>
    );
}

export default Welcome;
