

function addCart(imgurl , name , price , product_id ){
    const main = document.getElementById("productscarts");
    const num = document.getElementById("carts-header_count")
    const pricetitle = document.getElementById("product-body_info-total")
    num.innerText = parseInt(num.innerText) + 1;
    pricetitle.innerText = parseFloat(pricetitle.innerText) + parseFloat(price);
    const cartcount = document.getElementById("carts_count") ; 
    cartcount.innerText = parseInt(cartcount.innerText) + 1;
    if(main) { 
        
        var idcheck = document.getElementById(product_id); 
        if(idcheck) { 

            var quantity = idcheck.querySelector(".product-body_info-qty");
            quantity.innerText = parseInt(quantity.innerText) + 1;
        }else { 

            
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
                    <i onclick="removeElement('${product_id}' , '${price}')"  class="product-body_info-remove far fa-times-circle"></i>
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
    cartcount.innerText = parseInt(cartcount.innerText) - 1;
     var elem = document.getElementById(id);
     var quantity = elem.querySelector(".product-body_info-qty");
     if(parseInt(quantity.innerText) == 1) { 
        elem.remove();
     }else { 
        quantity.innerText = parseInt(quantity.innerText) - 1;
     }

    pricetitle.innerText = parseFloat(pricetitle.innerText) - parseFloat(price);

  
}