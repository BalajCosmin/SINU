import React from 'react';

function Modal() {



  return (
    <div className="modal">
      <form>
        <h3>Login</h3>
        <input type="email" className="email-modal" placeholder="Email or Phone" />
        <input type="password" className="password-modal" placeholder="Password"/>  
        <p className="forgot-password">
          Forgot&nbsp;<a href=""> password</a>?
        </p>
        <button type="submit" className="button-login">Log in</button>
        <h4>or  <a href="">Sign Up </a>
    </h4>
      </form>
      
    </div>
  )
}

export default Modal;
