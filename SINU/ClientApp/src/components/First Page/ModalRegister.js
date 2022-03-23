function ModalRegister() {
  return (
    <div id="registerModal" className="modal">
      <form>
        <h3>Register</h3>

        <input
          type="text"
          className="email-modal"
          placeholder="Enter username"
        />

        <input type="email" className="email-modal" placeholder="Enter email" />

        <input
          type="password"
          className="password-modal"
          placeholder="Enter password"
        />

        <input
          type="password"
          className="password-modal"
          placeholder="Confirm password"
        />

        <div className="form-group">
          <label>Identification Code</label>
          <input
            type="text"
            className="password-modal"
            placeholder="Enter ID"
          />
        </div>
        
        
 <button type="submit" className="button-login">
            Sign up
          </button>       
      </form>
    </div>
  );
}

export default ModalRegister;
