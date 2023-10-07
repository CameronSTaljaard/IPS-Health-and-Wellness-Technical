import React, { useEffect, useState } from 'react';
// import { useNavigate } from 'react-router-dom';
import { GetToken } from './UseToken';

const Cart = () => {
    const [products, setProducts] = useState([])
    const [totalPrice, setTotal] = useState([])
    const [cartItems, setCartCount] = useState([])
    const token = GetToken();

    const fetchCartData = () => {
        fetch("http://localhost:8080/cart/", {
            method: "post",
            headers: {
                'Authorization': token
            }
        })
            .then(response => {
                return response.json()
            })
            .then(data => {
                setProducts(data.cartProducts);
                calculateTotal(data.cartProducts);
                calculateTotalProducts(data.cartProducts);
            })
    }

    const calculateTotal = (data) => {
        var total = 0;
        data.forEach(product => {
            total += product.productQuantity * product.productPrice;
        });
        setTotal(total);
    }

    const calculateTotalProducts = (data) => {
        setCartCount(data.length);
    } 

    useEffect(() => {
        fetchCartData()
    }, [])

    return (
        <section className="h-100 h-custom" style={{ backgroundColor: "#eee" }}>
            <div className="container py-5 h-100">
                <div className="row d-flex justify-content-center align-items-center h-100">
                    <div className="col">
                        <div className="card">
                            <div className="card-body p-4">

                                <div className="row">

                                    <div className="col-lg-7">
                                        <h5 className="mb-3"><a href="#!" className="text-body"><i
                                            className="fas fa-long-arrow-alt-left me-2"></i>Continue shopping</a></h5>
                                        <hr />

                                        <div className="d-flex justify-content-between align-items-center mb-4">
                                            <div>
                                                <p className="mb-1">Shopping cart</p>
                                                <p className="mb-0">You have {cartItems} items in your cart</p>
                                            </div>
                                        </div>

                                        {products.map(cartProduct => (
                                            <div className="card mb-3" key={cartProduct.id}>
                                                <div className="card-body">
                                                    <div className="d-flex justify-content-between">
                                                        <div className="d-flex flex-row align-items-center">
                                                            <div>
                                                                <img
                                                                    src={cartProduct.productImage}
                                                                    className="img-fluid rounded-3" alt="Shopping item" style={{ width: "65px" }} />
                                                            </div>
                                                            <div className="ms-3">
                                                                {/* Product Name */}
                                                                <h5>{cartProduct.productName}</h5>
                                                                {/* Short product Description */}
                                                                <p className="small mb-0">{cartProduct.productBrief}</p>
                                                            </div>
                                                        </div>
                                                        <div className="d-flex flex-row align-items-center">
                                                            <div style={{ width: "50px" }}>
                                                                {/* Product Quantity */}
                                                                <h5 className="fw-normal mb-0">{cartProduct.productQuantity}</h5>
                                                            </div>
                                                            <div style={{ width: "80px" }}>
                                                                {/* Product Price */}
                                                                <h5 className="mb-0">${cartProduct.productPrice}</h5>
                                                            </div>
                                                            <a href="#!" style={{ color: "#cecece" }}><i className="fas fa-trash-alt"></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        ))}
                                        -

                                    </div>
                                    <div className="col-lg-5">

                                        <div className="card text-white rounded-3" style={{backgroundColor: "rgb(130, 83, 177)"}}>
                                            <div className="card-body">
                                                <div className="d-flex justify-content-between align-items-center mb-4">
                                                    <h5 className="mb-0">Card details</h5>
                                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/Avatars/avatar-6.webp"
                                                        className="img-fluid rounded-3" style={{ width: "45px" }} alt="Avatar" />
                                                </div>

                                                <p className="small mb-2">Card type</p>
                                                <a href="#!" type="submit" className="text-white"><i
                                                    className="fab fa-cc-mastercard fa-2x me-2"></i></a>
                                                <a href="#!" type="submit" className="text-white"><i
                                                    className="fab fa-cc-visa fa-2x me-2"></i></a>
                                                <a href="#!" type="submit" className="text-white"><i
                                                    className="fab fa-cc-amex fa-2x me-2"></i></a>
                                                <a href="#!" type="submit" className="text-white"><i className="fab fa-cc-paypal fa-2x"></i></a>

                                                <form className="mt-4">
                                                    <div className="form-outline form-white mb-4">
                                                        <input type="text" id="typeName" className="form-control form-control-lg" siez="17"
                                                            placeholder="Cardholder's Name" />
                                                        <label className="form-label" htmlFor="typeName">Cardholder's Name</label>
                                                    </div>

                                                    <div className="form-outline form-white mb-4">
                                                        <input type="text" id="typeText" className="form-control form-control-lg" siez="17"
                                                            placeholder="1234 5678 9012 3457" minLength="19" maxLength="19" />
                                                        <label className="form-label" htmlFor="typeText">Card Number</label>
                                                    </div>

                                                    <div className="row mb-4">
                                                        <div className="col-md-6">
                                                            <div className="form-outline form-white">
                                                                <input type="text" id="typeExp" className="form-control form-control-lg"
                                                                    placeholder="MM/YYYY" size="7" minLength="7" maxLength="7" />
                                                                <label className="form-label" htmlFor="typeExp">Expiration</label>
                                                            </div>
                                                        </div>
                                                        <div className="col-md-6">
                                                            <div className="form-outline form-white">
                                                                <input type="password" id="typeText" className="form-control form-control-lg"
                                                                    placeholder="" size="1" minLength="3" maxLength="3" />
                                                                <label className="form-label" htmlFor="typeText">Cvv</label>
                                                            </div>
                                                        </div>
                                                    </div>

                                                </form>

                                                <hr className="my-4" />

                                                <div className="d-flex justify-content-between mb-4">
                                                    <p className="mb-2">Total(Incl. taxes)</p>
                                                    <p className="mb-2">${totalPrice}</p>
                                                </div>

                                                <button type="button" className="btn btn-block btn-lg" style={{backgroundColor: "rgb(215, 183, 247)"}}>
                                                    <div className="d-flex justify-content-between">
                                                        <span>Checkout <i className="fas fa-long-arrow-alt-right ms-2"></i></span>
                                                    </div>
                                                </button>

                                            </div>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default Cart;

