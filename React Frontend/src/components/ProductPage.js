import "../css/product.css"
import React, { useEffect, useState } from "react";
import { useParams, useNavigate } from 'react-router-dom';
import Login from "./Login";
import { useToken } from "./UseToken";

const ProductPage = () => {
    const { token, setToken } = useToken();

    useEffect(() => {
        if (!token) {
            token = <Login setToken={setToken} />
        }
    })
    
    const [products, setProducts] = useState([]);
    const { productID } = useParams();
    const navigate = useNavigate();

    const fetchProductData = () => {
        fetch("http://localhost:8080/product/" + productID, {
            method: "post",
            headers: new Headers({
                'token': token
            })
        })
            .then(response => {
                return response.json()
            })
            .then(data => {
                setProducts(data);
            })
            .catch(error => {
                navigate('/404', { replace: true })
            })
    }

    useEffect(() => {
        fetchProductData()
    }, [])

    return (
        <div className="product-container">
            <div className="image-container">
                <img src={products.productImage} loading="lazy" alt="" className="product-image" />
            </div>
            <div className="product-information">
                <h2 className="heading-2 product-name">{products.productName}</h2>
                <h4 className="heading-2 product-price">{products.productPrice}</h4>
                <p className="product-description">{products.productDescription}</p>
            </div>
        </div>

    );
}

export default ProductPage;
