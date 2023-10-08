import "../css/temphome.css";
import 'bootstrap/dist/css/bootstrap.min.css';
import React, { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { GetToken } from "./UseToken";


const ProductList = () => {
    const categoryID = useParams();
    const [products, setProducts] = useState([])
    var token = GetToken();
    const navigate = useNavigate();

    const FetchCategoryData = () => {
        fetch("http://localhost:8080/category/" + categoryID.productID, {
            method: "post",
            headers: new Headers({
                'token': token
            })
        })
        .then(response => {
            if(response.ok) {
                return response.json()
            } else {
                navigate("/login?error=Login_Expired", {replace: true});
            }     
        })
    }

    const fetchProductData = () => {
        fetch("http://localhost:8080/products")
            .then(response => {
                if(response.ok) {
                    return response.json()
                } else {
                    navigate("/login?error=Login_Expired", {replace: true});
                }     
            })
            .then (response => {
                setProducts(response.products);
            })
    }

    useEffect(() => {
        FetchCategoryData()
        fetchProductData()
    }, [])


    return (
        <div>
            <div className="container">

                <h2 className="font-weight-light text-center text-lg-left mt-4 mb-0">Popular products</h2>

                <hr className="mt-2 mb-5"></hr>
                <div className="row text-center text-lg-left">

                    {products.map(product => (
                        <div className="col-lg-3 col-md-4 col-6">
                            <a href={product.productID} className="d-block mb-4 h-100">
                                <img src={product.productImage} loading="lazy" alt="" width="300px" height="220px" />
                                <span>{product.productName}</span>
                            </a>
                        </div>
                    ))}

                </div>
            </div>
        </div>
    )
};

export default ProductList;