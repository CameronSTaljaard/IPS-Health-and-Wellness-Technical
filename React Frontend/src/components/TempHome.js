import "../css/temphome.css";
import 'bootstrap/dist/css/bootstrap.min.css';
import React, { useEffect, useState } from "react";
const TempHome = () => {

    const [products, setProducts] = useState([])

    const fetchProductData = () => {
        fetch("http://localhost:8080/products")
            .then(response => {
                return response.json()
            })
            .then(data => {
                console.log(data);
                setProducts(data.products)
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
                        <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="product" className="d-block mb-4 h-100">
                            <img src={product.productImage} loading="lazy" alt="" width="300px" height="220px" />
                            <span>{product.productName}</span>
                        </a>
                    </div>
                    ))}

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/YOphb-Xr2sk/400x300" alt="Mountain Bike" width="300px" />
                        </a>
                    </div>

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/WyoD7dui5WI/400x300" alt="Commuter Bike" />
                        </a>
                    </div>
                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/FafiIrfd-Vw/400x300" alt="Gravel Bike" />
                        </a>
                    </div>

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/qZ1KmFjfQq8/400x300" alt="Electric Bike" />
                        </a>
                    </div>

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/vBC6hHHW6r8/400x300" alt="Fat Bike" />
                        </a>
                    </div>

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/jpgJSBQtw5U/400x300" alt="Fixed Gear Bike" />
                        </a>
                    </div>

                    <div className="col-lg-3 col-md-4 col-6 card-bike-category">
                        <a href="#" className="d-block mb-4 h-100">
                            <img className="img-fluid" src="https://source.unsplash.com/Z6Fi-a4zizc/400x300" alt="BMX bike" />
                        </a>
                    </div>

                </div>
            </div>
        </div>
    )
};

export default TempHome;