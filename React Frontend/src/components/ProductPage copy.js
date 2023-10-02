import { Component } from "react";
import "../css/product.css"

class ProductPage extends Component {
    render() {
        return (
            <div className="product-container">
                <div className="image-container">
                    <img src="https://uploads-ssl.webflow.com/651a123911b4ed7aad4be880/651a17390a0477eb5c7a0a01_simple-beige-mens-shirt(1).jpg" loading="lazy" alt="" className="product-image" />
                </div>
                <div className="product-information">
                    <h2 className="heading-2 product-name">Item&nbsp;Name</h2>
                    <h4 className="heading-2 product-price">$75.00</h4>
                    <p className="product-description">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere.</p>
                </div>
            </div>

        );
    }
}

export default ProductPage;
