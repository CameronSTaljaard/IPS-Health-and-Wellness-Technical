import React, { useState } from 'react';
import PropTypes from 'prop-types';
import '../css/login.css';
import { useNavigate } from 'react-router-dom';

async function loginUser(credentials) {
    return fetch('http://localhost:8080/login', {
        method: 'POST',
        headers: {
        'Content-Type': 'application/json'
        },
        body: JSON.stringify(credentials)
    })
    .then(data => data.json())
}

export default function Login() {
    const navigate = useNavigate();
    const [username, setUserName] = useState();
    const [password, setPassword] = useState();
    
    const handleSubmit = async e => {
        e.preventDefault();
        const token = await loginUser({
          username,
          password
        });
        setToken(token);
    }
    
    function setToken(token) {

        localStorage.setItem('token', JSON.stringify(token));
        navigate('/', { replace: true })
    }

    return(
    <div className="full-container">
        <div className="login-container">
        <h1 className="login-header">Please log in, or register</h1>
            <div className="login-card">
                <form className="login-form" onSubmit={handleSubmit}>
                    <input className="login-input" type="text" placeholder="Username" required onChange={e => setUserName(e.target.value)}/>
                    <input className="login-input" type="password" placeholder="Password" required onChange={e => setPassword(e.target.value)}/>
                    <div className="login-buttons">
                        <button className="register-button">Register</button>
                        <button type="submit" className="login-button">Login</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
    )
}


Login.propTypes = {
    setToken: PropTypes.func.isRequired
}