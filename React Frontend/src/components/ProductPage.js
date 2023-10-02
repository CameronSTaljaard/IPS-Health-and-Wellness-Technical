import "../css/product.css"
import React, { useEffect, useState } from "react";
import { useParams } from 'react-router-dom';


const ProductPage = () => {
    const [products, setProducts] = useState([]);
    const { productID } = useParams();

    const fetchProductData = () => {
        fetch("http://localhost:8080/product/" + productID)
        .then(response => {
            return response.json()
        })
        .then(data => {
                setProducts(data);
                console.log(data);
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
