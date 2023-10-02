import React from 'react';
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./components/Layout";
import LayoutNoNav from "./components/LayoutNoNav";
import Home from "./components/Home";
import ProductPage from './components/ProductPage';
import Contact from "./components/Contact";
import NoPage from "./components/NoPage";
import Login from './components/Login';
import TempHome from './components/TempHome';
import useToken from './components/UseToken';
import "./css/index.css";

export default function App() {
  const { token, setToken } = useToken();

  if(!token) {
    return <Login setToken={setToken} />
  }

  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />} >
          <Route index element={<TempHome />} />
          <Route path="/product" element={<ProductPage />} />
          <Route path="/contact" element={<Contact />} />
        </Route>
        <Route path="*" element={<LayoutNoNav />} >
          <Route path="*" element={<NoPage />} >
        </Route>
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(<App />);