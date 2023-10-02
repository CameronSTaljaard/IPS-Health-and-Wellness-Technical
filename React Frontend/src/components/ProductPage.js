import { Component } from "react";
import "../css/product.css"
import React, { useEffect, useState } from "react";


const ProductPage = () => {
    const [products, setProducts] = useState([]);
    
    const fetchProductData = () => {
        fetch("http://localhost:8080/product1")
            .then(response => {
                return response.json()
            })
            .then(data => {
                console.log(data);
                setProducts(data)
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
                <h2 className="heading-2 product-name">Item&nbsp;Name</h2>
                <h4 className="heading-2 product-price">{products.productPrice}</h4>
                <p className="product-description">{products.productDescription}</p>
            </div>
        </div>

    );
}

export default ProductPage;
