import "../css/product.css"
import React, { useEffect, useState } from "react";
import { useParams, useNavigate } from 'react-router-dom';
import { useToken } from "./UseToken";
import Button from '@mui/material/Button';

const ProductPage = () => {
    var token = useToken();

    const [products, setProducts] = useState([]);
    const { productID } = useParams();
    const navigate = useNavigate();

    const fetchProductData = () => {
        const requestOptions = {
            method: 'POST',
            mode: "cors",
            headers: {
                'Authorization': 'Bearer '.concat(token)
            },
            body: JSON.stringify({ "item": productID })
        };
        fetch("http://localhost:8080/product/" + productID, requestOptions, {
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

    const addToCart = () => {
        fetch("http://localhost:8080/addToCart/" + productID, {
            method: "post",
            headers: new Headers({
                'token': token
            })
        })
            .then(response => {
                if (response.ok) {
                    setProducts(response);
                    return (response);
                } else {
                    navigate('/login?error=Invalid_Token', { replace: true })
                }
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
                <h4 className="heading-2 product-price">${products.productPrice}</h4>
                <p className="product-description">{products.productDescription}</p>
                <Button onClick={addToCart} variant="contained">Add to Cart</Button>
            </div>
        </div>

    );
}

export default ProductPage;
