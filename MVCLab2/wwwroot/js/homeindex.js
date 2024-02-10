
document.querySelector('#productForm').onsubmit = function () {
    var productName = document.getElementById("ProductName").value;
    var price = document.getElementById("Price").value;
    var description = document.getElementById("Description").value;
    var quantity = document.getElementById("Quantity").value;
    var isAllowedToSubmit = true;  //a switch to confirm this form can be submmited

    //verify every input
    var nameP = document.querySelector("#nameP");
    
    if (productName.trim().length == 0) {
        nameP.innerHTML = "* Product name cannot be empty.";
        isAllowedToSubmit = false; 
    } else {
        nameP.innerHTML = "*";
    }
    //nameP.innerHTML = productName.trim().length;

  

    var desP = document.querySelector("#desP");
    if (description.trim() === "") {
        desP.innerHTML = "* Product description cannot be empty.";
        isAllowedToSubmit = false;
    } else {
        desP.innerHTML = "*";
    }

    // Check if Price and Quantity are not numbers
    var priceP = document.querySelector("#priceP");
    if (isNaN(parseFloat(price))) {
        priceP.innerHTML = "* Price must be a valid number.";
        isAllowedToSubmit = false;
    } else {
        priceP.innerHTML = "*";
    }


    var quantityP = document.querySelector("#quantityP");
    if (isNaN(parseFloat(quantity))) {
        quantityP.innerHTML = "* Quantity must be a valid number.";
        isAllowedToSubmit = false;
    } else {
        quantityP.innerHTML = "*";
    }

    //return false;

    return isAllowedToSubmit;  // if isAllowedToSubmit is false, will cancel the submmission.
}
