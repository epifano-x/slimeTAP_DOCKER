setTimeout(function() {
    window.location.href = "/Main/main";
  }, 6000); // 6000 milissegundos = 6 segundos
  

  var texts = ["Chamando monstros...", "Acordando aventureiros...", "Limpando armas..."];
  var currentIndex = 0;
  var typingTimeout;
  
  function typeText() {
    var textElement = document.getElementById("loadingText");
    var currentText = texts[currentIndex];
    var currentTextLength = currentText.length;
    var currentTextIndex = 0;
  
    function typeNextLetter() {
      textElement.innerHTML = currentText.substr(0, currentTextIndex);
      currentTextIndex++;
  
      if (currentTextIndex <= currentTextLength) {
        typingTimeout = setTimeout(typeNextLetter, 100); // Velocidade de digitação (100ms)
      } else {
        clearTimeout(typingTimeout);
        currentIndex = (currentIndex + 1) % texts.length;
        setTimeout(typeText, 1500); // Intervalo entre os textos (1500ms)
      }
    }
  
    typeNextLetter();
  }
  
  // Inicia o efeito de digitação
  typeText();
  
  