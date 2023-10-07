import { useState } from 'react';
import { useNavigate } from 'react-router-dom';

export function useToken() {
  const getToken = () => {
    const tokenString = localStorage.getItem('token');
    const userToken = JSON.parse(tokenString);
    return userToken?.token
  };

  const [token, setToken] = useState(getToken());

  const saveToken = userToken => {
    localStorage.setItem('token', JSON.stringify(userToken));
    setToken(userToken.token);
  }

  return {
    setToken: saveToken,
    token
  }
}

export function GetToken() {
  const navigate = useNavigate();

  if (localStorage.getItem('token')) {
    return (localStorage.getItem('token'))
  } else {
    navigate('/login', {
      authenticated: false,
    });
  }
}