import React, { useEffect, useState } from 'react';
import '../css/login.css';
import { useNavigate } from 'react-router-dom';

async function loginUser(credentials) {
    return fetch('https://localhost:5000/api/login', {
        mode: 'cors',
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(credentials)
    })
    .then(data => data.json())
}

async function registerUser(credentials) {
    return fetch('https://localhost:5000/api/Register', {
        mode: 'cors',
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
    const [errorMessage, setErrorMessage] = useState();

    const handleLogin = async e => {
        e.preventDefault();
        const token = await loginUser({
            username,
            password
        });
        if (!token.error) {
            setToken(token);
        } else {
            setErrorMessage(token.error)
            navigate("?error=Incorrect_Login");
        }
    }

    const handleRegister = async e => {
        e.preventDefault();
        const token = await registerUser({
            username,
            password
        });
        if (!token.error) {
            setToken(token);
        } else {
            setErrorMessage(token.error)
            navigate("?error=Username_Taken");
        }
    }

    function setToken(token) {

        localStorage.setItem('token', JSON.stringify(token));
        navigate('/categories', { replace: true })
    }

    return (
        <div className="full-container">
            <div className="login-container">
                <h1 className="login-header">Please log in, or register</h1>
                <div className="login-card">
                    <form className="login-form">
                        <input className="login-input" type="text" placeholder="Username" required onChange={e => setUserName(e.target.value)} onKeyDown={(e) => { e.key === 'Enter' && e.preventDefault(); }}/>
                        <input className="login-input" type="password" placeholder="Password" required onChange={e => setPassword(e.target.value)} onKeyDown={(e) => { e.key === 'Enter' && e.preventDefault(); }}/>
                        <div className="login-buttons">
                            <button onClick={handleRegister} className="register-button">Register</button>
                            <button onClick={handleLogin} type="submit" className="login-button">Login</button>
                        </div>
                        <span style={{color: "red"}}>{errorMessage}</span>
                    </form>
                </div>
            </div>
        </div>
    )
}