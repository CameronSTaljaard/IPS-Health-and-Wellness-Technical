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

const products = [
  {
    "productImage" : "https://i.imgur.com/GzULnIp.jpg",
    "productName" : "White-tshirt Male",
    "productID": "/product/0"
  },
  {
    "productImage" : "https://i.imgur.com/LUvCUHb.jpg",
    "productName" : "White-tshirt Female",
    "productID": "/product/1"
  },
  {
    "productImage" : "https://i.imgur.com/hqbaPcW.jpg",
    "productName" : "Black-tshirt Female",
    "productID": "/product/2"
  }
]

const productDetails = [
  {
    productName: "White male T-shirt",
    productImage: "https://i.imgur.com/GzULnIp.jpg",
    productPrice: 25,
    productBrief: "Lorem ipsum",
    productDescription: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere."
  },
  {
    productName: "White female T-shirt",
    productImage: "https://i.imgur.com/LUvCUHb.jpg",
    productPrice: 22.5,
    productBrief: "Lorem ipsum",
    productDescription: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere."
  },
  {
    productName: "Black female T-shirt",
    productImage: "https://i.imgur.com/hqbaPcW.jpg",
    productPrice: 20,
    productBrief: "Lorem ipsum",
    productDescription: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere."
  }
]

const cartProducts = [
  {
    productName: "White male T-shirt",
    productImage: "https://i.imgur.com/GzULnIp.jpg",
    productPrice: 25,
    productBrief: "Lorem ipsum",
    productQuantity: 3,
    id: 0
  },
  {
    productName: "White female T-shirt",
    productImage: "https://i.imgur.com/LUvCUHb.jpg",
    productPrice: 22.5,
    productBrief: "Lorem ipsum",
    productQuantity: 2,
    id: 1
  },
  {
    productName: "Black female T-shirt",
    productImage: "https://i.imgur.com/hqbaPcW.jpg",
    productPrice: 20,
    productBrief: "Lorem ipsum",
    productQuantity: 1,
    id: 2
  }
]

app.use('/products', (req, res) => {
  res.send({
    products
  })
});

app.use('/cart', (req, res) => {
  res.send({
    cartProducts
  })
});

app.use('/product', (req, res) => {
  const slug = req.url.split('/').slice(1);
  res.send(productDetails[slug]);
  // res.send({
  //   productImage: "https://uploads-ssl.webflow.com/651a123911b4ed7aad4be880/651a17390a0477eb5c7a0a01_simple-beige-mens-shirt(1).jpg",
  //   productPrice: "$75",
  //   productDescription: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse varius enim in eros elementum tristique. Duis cursus, mi quis viverra ornare, eros dolor interdum nulla, ut commodo diam libero vitae erat. Aenean faucibus nibh et justo cursus id rutrum lorem imperdiet. Nunc ut sem vitae risus tristique posuere."
  // })
});

app.listen(8080, () => console.log('API is running on http://localhost:8080/login'));