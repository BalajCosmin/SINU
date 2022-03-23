import Login from "./Login";
import Register from "./Register";

function Student(props) {
  
  return (
    <div className="studentContainer">
      <div className="studentText">
        <p>Student</p>
      </div>
      <div className="loginRegister">
        <Login />
        <Register/>
      </div>
     
    </div>
  );
}

export default Student;
