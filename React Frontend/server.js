const express = require('express');
const cors = require('cors');
const app = express();

app.use(cors());

app.use(express.json());
app.use(express.urlencoded( {extended: true }));

app.use('/login', (req, res) => {
  const username = req.body.username;
  const password = req.body.password;
  const response = "RealKeyHuh";
  res.send({
    token: response,
    user: username,
    pass: password
  })
});

app.use('/products', (req, res) => {

  const products = [
    {
      "productImage" : "https://i.imgur.com/GzULnIp.jpg",
      "productName" : "White-tshirt Male"
    },
    {
      "productImage" : "https://i.imgur.com/LUvCUHb.jpg",
      "productName" : "White-tshirt Female"
    },
    {
      "productImage" : "https://i.imgur.com/hqbaPcW.jpg",
      "productName" : "Black-tshirt Female"
    }
  ]
  // const productImages = [
  //   "../../public/images/white-tshirt-male.jpg",
  //   "../../public/images/white-tshirt-male.jpg",
  //   "../../public/images/white-tshirt-male.jpg"
  // ]

  // const productNames = [
  //   "White-tshirt Male",
  //   "White-tshirt Female",
  //   "Black-tshirt Female"
  // ]
  res.send({
    products
  })
});

app.use('/product1', (req, res) => {
  res.send({
    productImage: "https://uploads-ssl.webflow.com/651a123911b4ed7aad4be880/651a17390a0477eb5c7a0a01_simple-beige-mens-shirt(1).jpg",
    productPrice: "$75",
    productDescription: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere."
  })
});

app.listen(8080, () => console.log('API is running on http://localhost:8080/login'));