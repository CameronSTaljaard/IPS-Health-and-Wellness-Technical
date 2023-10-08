import "../css/temphome.css";
import 'bootstrap/dist/css/bootstrap.min.css';
import React, { useEffect, useState } from "react";
import { GetToken } from "./UseToken";
import { useNavigate } from "react-router-dom";

const ProductCategories = () => {

    const [categories, setCategories] = useState([])
    const navigate = useNavigate();
    const token = GetToken();
    const [errorMessage, setErrorMessage] = useState();

    const FetchCategoryData = () => {
        fetch("http://localhost:8080/categories", {
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
            .then (response => {
                setCategories(response.categories);
            })
        }

    useEffect(() => {
        FetchCategoryData()
    }, [])


    return (
        <div>
            <div className="container">

                <h2 className="font-weight-light text-center text-lg-left mt-4 mb-0">Product Categories</h2>
                <a> </a>
                <hr className="mt-2 mb-5"></hr>
                <div className="row text-center text-lg-left">

                    {categories.map(category => (
                        <div className="col-lg-3 col-md-4 col-6" key={category.id}>
                            <a href={"/category/" + category.id} className="d-block mb-4 h-100">
                                <img src={category.categoryImage} loading="lazy" alt="" width="300px" height="220px" />
                                <h5>{category.categoryName}</h5>
                                <div>Get some amazing shirts now! Get some amazing shirts now! Get some amazing shirts now!</div>
                            </a>
                        </div>
                    ))}

                </div>
            </div>
        </div>
    )
};

export default ProductCategories;