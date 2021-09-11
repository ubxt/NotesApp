import '../App.css';
import {useHistory} from 'react-router-dom';
import React, { useState } from 'react';
import {Link} from 'react-router-dom';
import axios from 'axios';

function LoginView () {

    const [email,setEmail] = useState("");
    const history = useHistory();

    const login = async () => {
        await axios.get('https://localhost:5001/api/User/getbyemail/'+email)
        .then(res => {
            if (res.data !== ""){
                localStorage.setItem("user",JSON.stringify(res.data));
                history.push("/home");
            }
        })
        .catch(err => {})
    }

    return(
        <div className="login">
            <h2 className="login-heading">Giriş Yap</h2>
            <input type="text" name="email" id="txtEmail" placeholder="Eposta Adresi" 
            className="form-control" autoFocus={true} autoComplete="false" onChange={e => setEmail(e.target.value)} />
            <button className="btn btn-lg btn-primary btn-block" onClick={login}>Giriş</button>
            <Link to='/register' className="btn btn-lg btn-warning btn-block" style={{float:"right"}} >Kayıt</Link>
        </div>
    );

}

export default LoginView;