$(document).ready(function () {
    $(document).on("click", "#productdetailId", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        //console.log(url);

        fetch(url).then(res => { return res.text() }).then(data =>
        {
            //console.log(data)

            $("#quickModal .product-details-modal").html(data);
            $("#quickModal").modal(true);

        })
    })

    $(document).on("click", ".addtobasket", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");
        console.log(url)
        //let quantity = $(".quantity").val();
        //console.log(quantity)

        fetch(url).then(res =>
        {
            //console.log(res)

            //if (res.ok)
            //{
            //    alert("Sebete Elave Olundu")
            //}

            return res.text();
        }).then(data =>
        {
            console.log(data)
            $(".cart-block").html(data);
        })

    })

    $(document).on("keyup", ".productcount", function () {
        let count = $(this).val();
        let productId = $(this).attr("data-productId");
        let url = `/Product/AddToBasket/`;


        fetch("/Product/ChangeBasketProductCount/" + productId + '?count=' + count).then(res => {
            return res.text();
        }).then(data => {
            $(".productTable").html(data);
        })


        fetch("/Product/Salam/" + productId + '?count=' + count).then(res => {
            return res.text();
        }).then(data => {
            console.log(data)
            $(".cart-block").html(data);
            $(".cart-summary .text-primary").html($(".cart-block .cart-total .price").text())
        })
    })

    
})