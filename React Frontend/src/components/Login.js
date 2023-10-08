import React, { useEffect, useState } from 'react';
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

async function registerUser(credentials) {
    return fetch('https://localhost:55491/api/Register', {
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
    const queryParameters = new URLSearchParams(window.location.search)
    const error = queryParameters.get("error")

    useEffect(()=>{
        if (error)
        setErrorMessage("Your login token has expired, please login again");
    }, [])

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

    const handleRegister = async () => {
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
        navigate('/', { replace: true })
    }

    return (
        <div className="full-container">
            <div className="login-container">
                <h1 className="login-header">Please log in, or register</h1>
                <div className="login-card">
                    <form className="login-form">
                        <input className="login-input" type="text" placeholder="Username" required onChange={e => setUserName(e.target.value)} />
                        <input className="login-input" type="password" placeholder="Password" required onChange={e => setPassword(e.target.value)} />
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


Login.propTypes = {
    setToken: PropTypes.func.isRequired
}