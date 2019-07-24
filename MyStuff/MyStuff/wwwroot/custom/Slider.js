//try using slick slider

var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function showSlides(n, items2show) {
  var slides = document.getElementsByClassName("mySlides");
  if (n < 1) { n = slides.length-1}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";
  }
  if (n + items2show >= slides.length) {
      //Then show the items at the  end & at the begining of the collection

  }

    //Need to make this n + variable work with the responsive layout
  for (i = n; i < n + items2show; i++) {
      slides[i].style.display = "block";
  }
}
