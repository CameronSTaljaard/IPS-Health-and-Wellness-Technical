import React from 'react';
import ReactDOM from "react-dom/client";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./components/Layout";
import LayoutNoNav from "./components/LayoutNoNav";
import ProductPage from './components/ProductPage';
import Contact from "./components/Contact";
import NoPage from "./components/NoPage";
import Login from './components/Login';
import ProductList from './components/ProductList';
import Cart from './components/Cart';
import ProductCategories from './components/ProductCategories';
import "./css/index.css";

export default function App() {

    return (
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Layout />} >
            <Route index element={<ProductCategories />} />
            <Route path="/categories" element={<ProductCategories />} />
            <Route path="/category/:productID" element={<ProductList />} />
            <Route path="/product/:productID" element={<ProductPage />} />
            <Route path="/contact" element={<Contact />} />
            <Route path="/login" element={<Login />} />
            <Route path="/cart" element={<Cart />} />
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