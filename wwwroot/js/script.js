// search-box open close js code
let navbar = document.querySelector(".navbar");
let searchBox = document.querySelector(".search-box .bx-search");
// let searchBoxCancel = document.querySelector(".search-box .bx-x");

searchBox.addEventListener("click", ()=>{
  navbar.classList.toggle("showInput");
  if(navbar.classList.contains("showInput")){
    searchBox.classList.replace("bx-search" ,"bx-x");
  }else {
    searchBox.classList.replace("bx-x" ,"bx-search");
  }
});

// sidebar open close js code
let navLinks = document.querySelector(".nav-links");
let menuOpenBtn = document.querySelector(".navbar .bx-menu");
let menuCloseBtn = document.querySelector(".nav-links .bx-x");
menuOpenBtn.onclick = function() {
navLinks.style.left = "0";
}
menuCloseBtn.onclick = function() {
navLinks.style.left = "-100%";
}


// sidebar submenu open close js code
let htmlcssArrow = document.querySelector(".htmlcss-arrow");
htmlcssArrow.onclick = function() {
 navLinks.classList.toggle("show1");
}
let moreArrow = document.querySelector(".more-arrow");
moreArrow.onclick = function() {
 navLinks.classList.toggle("show2");
}
let jsArrow = document.querySelector(".js-arrow");
jsArrow.onclick = function() {
 navLinks.classList.toggle("show3");
}
//Comment
function showComment() {
  var commentArea = document.getElementById("comment-area");
  commentArea.classList.remove("hide");
}

function hideComment() {
  var commentArea = document.getElementById("comment-area");
  commentArea.classList.add("hide");
}

function submitComment() {
  var commentInput = document.getElementById("comment-input");
  var commentText = commentInput.value;
  // Do something with the comment text, such as send it to a server
  // or add it to the page dynamically
  console.log("Comment submitted:", commentText);
  // Clear the comment input
  commentInput.value = "";
}
//Reply
// Show reply area
function showReply() {
  var replyArea = document.getElementById("reply-area");
  replyArea.classList.remove("hide");
}

// Hide reply area
function hideReply() {
  var replyArea = document.getElementById("reply-area");
  replyArea.classList.add("hide");
}

// Submit reply
function submitReply() {
  var replyInput = document.getElementById("reply-input");
  var replyText = replyInput.value.trim();

  // TODO: Process reply text
  // ...

  // Hide reply area
  hideReply();

  // Clear reply input
    replyInput.value = "";


});

//let cancelBtn = document.getElementById("submit");
//cancelBtn.addEventListener("click", function () {
    //window.location.href = "/Homepage/Profile_Page.cshtml";}



    function comment() {
        // 处理按钮点击事件的逻辑
        window.location.href = document.getElementById("comment-link").href;
  }


