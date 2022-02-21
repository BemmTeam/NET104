

function addCart(imgurl , name , price , product_id ){
    const main = document.getElementById("productscarts");
    const pricetitle = document.getElementById("product-body_info-total")
    pricetitle.innerText = parseFloat(pricetitle.innerText) + parseFloat(price);
    const cartcount = document.getElementById("carts_count") ; 
    cartcount.innerText = parseInt(cartcount.innerText) + 1;
    if(main) { 

        var count = document.getElementById("count-" + product_id);
        if(parseInt(count.innerText) > 0) { 
            count.classList.add("text-success");
            count.innerText = parseInt(count.innerText) - 1;
            if(parseInt(count.innerText) == 0 ) { 
                count.classList.add("text-danger")
                document.getElementById("btn-" + product_id).style.visibility = "hidden";

                count.innerText = "Hết hàng"
            }
        }
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
     var elem = document.getElementById(id);
     var quantitya = elem.querySelector(".product-body_info-qty");
    cartcount.innerText = parseInt(cartcount.innerText) - parseInt(quantitya.innerText);
    console.log(quantitya);


    elem.remove();
    var count = document.getElementById("count-" + id);
        
    var countne = parseInt(count.innerText);
    if(isNaN(countne)) countne = 0;
    count.innerText =  countne + parseInt(quantitya.innerText);
    count.classList.replace("text-danger","text-success");
    count.classList.replace("text-success","text-success");

    document.getElementById("btn-" + id).style.visibility = "visible";



    pricetitle.innerText = parseFloat(pricetitle.innerText) - parseFloat(price);

  
}