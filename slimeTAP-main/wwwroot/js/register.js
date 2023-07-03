document.querySelector('.register-button').addEventListener('click', function(event) {
    event.preventDefault(); // Evita que o formulário seja submetido
  
    if (validarFormulario()) {
      alert('Formulário válido! Registro realizado.');
      window.location.href = "/Login/login";
      // Adicione aqui o redirecionamento para a próxima página ou ação desejada após o registro
    }
  });
  
  function validarFormulario() {
    var usuario = document.querySelector('.abc2 input[type="text"]').value;
    var email = document.querySelector('.abc2 input[type="email"]').value;
    var senha = document.querySelector('.abc2 input[type="password"]').value;
    var confirmarSenha = document.querySelectorAll('.abc2 input[type="password"]')[1].value;
  
    if (usuario.trim() === '') {
      alert('Por favor, digite um nome de usuário.');
      return false;
    }
  
    if (usuario.length < 4) {
      alert('O usuário deve ter pelo menos 4 caracteres.');
      return false;
    }
  
    if (email.trim() === '') {
      alert('Por favor, digite um email.');
      return false;
    }
  
    if (!validarEmail(email)) {
      alert('Por favor, digite um email válido.');
      return false;
    }
  
    if (senha.trim() === '') {
      alert('Por favor, digite uma senha.');
      return false;
    }
  
    if (senha.length < 8) {
      alert('A senha deve ter pelo menos 8 caracteres.');
      return false;
    }
  
    if (confirmarSenha.trim() === '') {
      alert('Por favor, confirme a senha.');
      return false;
    }
  
    if (senha !== confirmarSenha) {
      alert('As senhas não coincidem.');
      return false;
    }
  
    return true;
  }
  
  function validarEmail(email) {
    var re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(email);
  }
  