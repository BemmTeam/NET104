

function addCart(imgurl , name , price , product_id ){
    const main = document.getElementById("productscarts");
    const pricetitle = document.getElementById("product-body_info-total")
    pricetitle.innerText = parseFloat(pricetitle.innerText) + parseFloat(price);
    const cartcount = document.getElementById("carts_count") ; 
    cartcount.innerText = parseInt(cartcount.innerText) + 1;
    if(main) { 
        
        var idcheck = document.getElementById(product_id); 
        if(idcheck) { 
            var quantity = idcheck.querySelector(".product-body_info-qty");
            quantity.innerText = parseInt(quantity.innerText) + 1;

        }else { 

                    
                    const num = document.getElementById("carts-header_count")
                    num.innerText = parseInt(num.innerText) + 1;
            
           
                    const product = document.createElement("li"); 
            
                    product.classList.add("product-item"); 
                    product.setAttribute("id" , product_id);
                    product.innerHTML = `
                    <li class="product-item">
                    <div class="product_img" style="
                    background: url('${imgurl}')
                    center center / contain no-repeat;">
                    </div>
                    <div class="product-body_info">
                        <div class="product-body_info-title">
                            ${name}
                        </div>
                        <div class="product-body_info-wrap">
                            <i class="product-body_info-icon fas fa-dollar-sign"></i>
                            <span class="product-body_info-label">${price} x
                            </span>
                            <span class="product-body_info-qty">1</span>
            
                        </div>
                    </div>
                    <a href="/cart/remove?id=${product_id}" onclick="removeElement('${product_id}' , '${price}')"  class="product-body_info-remove far fa-times-circle"></a>
                </li>
                    `
            
                    
                    main.appendChild(product);
        }
    }



}

function removeElement(id , price) {
    const num = document.getElementById("carts-header_count")
    num.innerText = parseInt(num.innerText)  -1 ;
    const pricetitle = document.getElementById("product-body_info-total")
    const cartcount = document.getElementById("carts_count") ; 
    const quantity = document.getElementById("product-body_info-qty");
    console.log(quantity);
     var elem = document.getElementById(id);
     var quantitya = elem.querySelector(".product-body_info-qty");
    cartcount.innerText = parseInt(cartcount.innerText) - parseInt(quantitya.innerText);


    elem.remove();
  

    pricetitle.innerText = parseFloat(pricetitle.innerText) - parseFloat(price);

  
}