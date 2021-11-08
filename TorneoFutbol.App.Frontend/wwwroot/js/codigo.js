var header = document.getElementById("header")

window.addEventListener("scroll", ()=>{
    var scroll = window.scrollY
    if(scroll>10){
        header.style.background = '#121212'
    }
    else{
        header.style.backgroundColor = "transparent"
    }
})



