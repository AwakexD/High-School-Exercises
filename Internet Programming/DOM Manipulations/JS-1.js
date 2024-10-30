let image = document.getElementById("image");
image.width = 250;

image.src="https://iliyankovachev.files.wordpress.com/2019/02/fish2.jpg&#8220";

let bodytag = document.body;
bodytag.style.background = "Beige";

let about = document.getElementById("heading");
about.style.fontSize = 100;

let italics = document.getElementsByTagName("i")[0];
italics.innerText = "Склонността към лентяйството винаги е била най-силната черта на моя характер.";

italics.innerHTML = "Склонността към лентяйството винаги е била <b>най-силната черта</b> на моя характер.";