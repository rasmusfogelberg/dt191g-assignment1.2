// Simple JavaScript function to toggle background color of the body tag
const toggleButton = document.getElementById("toggleBgColor");

toggleButton.addEventListener("click", () => {
  document.body.classList.toggle("neonBlue");
});

