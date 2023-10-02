import React, { useState } from 'react';
import '../css/login.css';
import PropTypes from 'prop-types';

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

export default function Login({ setToken }) {
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