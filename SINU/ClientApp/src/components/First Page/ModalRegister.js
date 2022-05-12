import React from "react";
import UserService from "../../NewFolder/UserService"
import { useEffect, useState } from 'react';
import { useForm } from "react-hook-form";
import { useNavigate } from 'react-router-dom';






function ModalRegister() {


    const { register,handleSubmit } = useForm();
    const [password, setPassword] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");
    const [userName, setUserName] = useState("");
    const [id, setId] = useState("");
    const [email, setEmail] = useState("");


    console.log(password);
    const navigate = useNavigate();
    navigate('/Home');

    console.log(userName);
    const onSubmit = (data) => {

   
       
        return UserService.singUpRequest(JSON.stringify(data)).then(console.log(data))

    };





  return (
      <div id="registerModal" className="modal">
          <form >
        <h3>Register</h3>

              <input
          name="firstName"
           required
           id="firstName"
          type="text"
          className="password-modal"
          placeholder="Enter username"
          value={userName}
          onChange={(e) => setUserName(e.target.value)}
        />

              <input type="email"
              className="email-modal"
                  placeholder="Enter email"
                  required
                  id="email-modal"
                  type="text"
                  className="password-modal"
                  placeholder="Enter Email"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}              />

              <input
          name="password-modal"
          required
          id="password-modal"
          type="password"
          className="password-modal"
           placeholder="Enter password"
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
        />

              <input
          name="confirm-password-modal"
          required
          id="confirm-password-modal"
          type="password"
          className="password-modal"
                  placeholder="Confirm password"
                  value={confirmPassword}
                  onChange={(e) => setConfirmPassword(e.target.value)}
        />

        <div className="form-group">
          <label>Identification Code</label>
                  <input
            name="id-modal"
            required
            id="id-modal"
            type="text"
            className="password-modal"
            placeholder="Enter ID"
            value={id}
            onChange={(e) => setId(e.target.value)}
          />
        </div>
        
        
              <button type="submit" className="button-login" onClick={navigate} >
            Sign up
          </button>       
      </form>
    </div>
  );
}

export default ModalRegister;
