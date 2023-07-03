const togglePassword = document.getElementById("togglePassword");
const passwordInput = document.getElementById("password");

togglePassword.addEventListener("click", function () {
  const type = passwordInput.getAttribute("type") === "password" ? "text" : "password";
  passwordInput.setAttribute("type", type);
  togglePassword.classList.toggle("fa-eye-slash");
  togglePassword.classList.toggle("fa-eye");
});

const rememberPasswordCheckbox = document.getElementById("rememberPassword");


// Verificar se há uma senha salva no navegador
const savedPassword = localStorage.getItem("savedPassword");
if (savedPassword) {
  passwordInput.value = savedPassword;
  rememberPasswordCheckbox.checked = true;
}

// Evento de alteração da caixa de seleção
rememberPasswordCheckbox.addEventListener("change", function () {
  if (rememberPasswordCheckbox.checked) {
    // Salvar a senha no navegador
    localStorage.setItem("savedPassword", passwordInput.value);
  } else {
    // Remover a senha salva do navegador
    localStorage.removeItem("savedPassword");
  }
});
