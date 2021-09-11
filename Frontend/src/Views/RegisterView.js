import axios from 'axios';
import React, {useState} from 'react';
import {useHistory} from 'react-router-dom';

function RegisterView(){

    const history = useHistory();
    const [user, setUser] = useState({'email':'', 'firstName':'', "lastName":''});
    const handleEmailChange = (e) => {
        setUser({...user, 'email':e.target.value});
    } 
    const handleFNameChange = (e) => {
        setUser({...user, 'firstName':e.target.value});
    } 
    const handleLNameChange = (e) => {
        setUser({...user, 'lastName':e.target.value});
    }
    const register = async () => {
        await axios.post('https://localhost:5001/api/User',user)
        .then(res => {
            localStorage.setItem("user",JSON.stringify(res.data));
        })
        .catch(err => {
            console.log(err);
        })
        history.push("/home");
    }
    
    return(
        <form>
            <legend>
                <h1>Kayıt Ol</h1>
            </legend>
            <div className="form-group">
                <input type="email" className="form-control" id="email" placeholder="Eposta" value={user.email} onChange={handleEmailChange}/>
            </div>
            <div className="form-group">
                <input type="email" className="form-control" id="firstName" placeholder="Ad" value={user.firstName} onChange={handleFNameChange}/>
            </div>
            <div className="form-group">
                <input type="email" className="form-control" id="lastName"placeholder="Soyad" value={user.lastName} onChange={handleLNameChange}/>
            </div>
            <button type="button" className="btn btn-primary" style={{width:"100%"}} onClick={register}>Kayıt</button>
        </form>
    )
}

export default RegisterView;