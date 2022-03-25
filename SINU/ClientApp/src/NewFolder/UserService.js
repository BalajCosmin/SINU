import axios from "axios";
const SIGNUP_REST_API_URL = 'https://localhost:44328/api/user';
const LOGIN_REST_API_URL = 'http://localhost:8080/api/auth/signin';


class UserService {
    singUpRequest(item) {
        return axios.post(SIGNUP_REST_API_URL, item, {
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json"
            }, mode: 'no-cors'
        });
    }

    logInRequest(item) {
        return axios.post(LOGIN_REST_API_URL, item, {
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json"
            }, mode: 'no-cors', responseType: "json"
        });
    }

    
}
export default new UserService();