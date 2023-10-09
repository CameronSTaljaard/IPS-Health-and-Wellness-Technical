import "../css/product.css"
import React, { useEffect, useState } from "react";
import { useParams, useNavigate } from 'react-router-dom';
import { GetToken } from "./UseToken";
import Button from '@mui/material/Button';

const ProductPage = () => {
    var token = GetToken();

    const [products, setProducts] = useState([]);
    const { productID } = useParams();
    const navigate = useNavigate();

    const fetchProductData = () => {
        const requestOptions = {
            method: 'GET',
            mode: "cors",
            headers: {
                'Authorization': 'Bearer '.concat(token)
            },
        };
        fetch("https://localhost:5000/api/Product/" + productID, requestOptions, {})
            .then(response => {
                return response.json()
            })
            .then(data => {
                setProducts(data);
            })
            .catch(error => {
                console.log(error);
                // navigate('/404', { replace: true })
            })
    }

    const addToCart = () => {
        const requestOptions = {
            method: 'POST',
            mode: "cors",
            headers: {
                'Authorization': 'Bearer '.concat(token)
            },
        };
        fetch("https://localhost:5000/api/Cart/add/" + productID, requestOptions, {
        })
            .then(response => {
                if (response.ok) {
                    setProducts(response);
                    navigate('/cart', { replace: true })
                    return (response);
                } else {
                    navigate('/login?error=Invalid_Token', { replace: true })
                }
            })
            .catch(error => {
                // navigate('/404', { replace: true })
            })
    }

    useEffect(() => {
        fetchProductData()
    }, [])

    return (
        <div className="product-container">
            <div className="image-container">
                <img src={products.imageData} loading="lazy" alt="" className="product-image" />
            </div>
            <div className="product-information">
                <h2 className="heading-2 product-name">{products.name}</h2>
                <h4 className="heading-2 product-price">${products.price}</h4>
                <p className="product-description">{products.description}</p>
                <Button onClick={addToCart} variant="contained">Add to Cart</Button>
            </div>
        </div>

    );
}

export default ProductPage;
