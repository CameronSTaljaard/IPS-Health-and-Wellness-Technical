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

    // const FetchCategoryData = () => {
    //     const requestOptions = {
    //         method: 'GET',
    //         mode: "cors",
    //         headers: {
    //             'Authorization': 'Bearer '.concat(token)
    //         },
    //     };
    //     fetch("http://localhost:5000/api/Category/" + categoryID.productID, requestOptions, {})
    //         .then(response => {
    //             if (response.ok) {
    //                 console.log(response);
    //                 console.log("Its ok")
    //                 return response.json()
    //             } else {
    //                 navigate("/login?error=Login_Expired", { replace: true });
    //             }
    //         })
    // }

    const fetchProductData = () => {
        const requestOptions = {
            method: 'GET',
            mode: "cors",
            headers: {
                'Authorization': 'Bearer '.concat(token)
            },
        };
        fetch("https://localhost:5000/api/Category/" + categoryID.productID, requestOptions)
            .then(response => {
                if (response.ok) {
                    return response.json()
                } else {
                    navigate("/login?error=Login_Expired", { replace: true });
                }
            })
            .then(response => {
                setProducts(response);
            })
    }

    useEffect(() => {
        fetchProductData()
    }, [])


    return (
        <div>
            <div className="container">

                <h2 className="font-weight-light text-center text-lg-left mt-4 mb-0">Popular products</h2>

                <hr className="mt-2 mb-5"></hr>
                <div className="row text-center text-lg-left">

                    {products.map(product => (
                        <div className="product-container col-lg-3 col-md-4 col-6">
                            <a onClick={()=>navigate(`/product/${product.id}`, { replace:true })} className="d-block mb-4 h-100">
                                <img src={product.imageData} loading="lazy" alt="" height="280px"/>
                                <div>{product.name}</div>
                                <div>{product.shortDescription}</div>
                            </a>
                        </div>
                    ))}

                </div>
            </div>
        </div>
    )
};

export default ProductList;