function mudarTela(numeroTela) {
  var telas = document.getElementsByClassName('tela');
  for (var i = 0; i < telas.length; i++) {
    telas[i].style.display = 'none';

    var upgrades = telas[i].getElementsByClassName('upgrade');
    for (var j = 0; j < upgrades.length; j++) {
      upgrades[j].style.display = 'none';
    }
  }

  var telaSelecionada = document.getElementsByClassName('tela')[numeroTela - 1];
  telaSelecionada.style.display = 'block';

  var upgradesSelecionados = telaSelecionada.getElementsByClassName('upgrade');
  for (var k = 0; k < upgradesSelecionados.length; k++) {
    upgradesSelecionados[k].style.display = 'flex';
  }

  // Remove a classe "selected" de todos os ícones
  var icones = document.getElementsByClassName('icone2');
  for (var l = 0; l < icones.length; l++) {
    icones[l].classList.remove('selected');
  }

  // Adiciona a classe "selected" ao botão selecionado
  var botaoSelecionado = document.getElementsByClassName('icone2')[numeroTela - 1];
  botaoSelecionado.classList.add('selected');

  // Salva o número da tela nos cookies
  localStorage.setItem('ultimaTela', numeroTela);
}

// Carrega a última tela aberta ao carregar a página
window.onload = function () {
  var ultimaTela = localStorage.getItem('ultimaTela');
  if (ultimaTela) {
    mudarTela(parseInt(ultimaTela));
  } else {
    // Define uma tela padrão caso não haja tela salva nos cookies
    mudarTela(1);
  }
};

  
function toggleMenu() {
  var menu = document.querySelector('.container2 .menu');
  menu.classList.toggle('menu-displayed');
}

  
function zoomImage(element) {
  element.classList.add('zoom-animation');

  setTimeout(function() {
      element.classList.remove('zoom-animation');
  }, 200);
}


document.querySelector('.div2').onclick = function() {
  var slimeImages = document.querySelectorAll('.slime img');
  
  slimeImages.forEach(function(image) {
    zoomImage(image);
  });
};

document.querySelector('.divbotaoClick').onclick = function() {
  var slimeImages = document.querySelectorAll('.slime img');
  
  slimeImages.forEach(function(image) {
    zoomImage(image);
  });
};



function bloquearSelecaoTexto() {
  // Impede a ação padrão de seleção de texto no evento 'mousedown'
  document.addEventListener('mousedown', function(event) {
    event.preventDefault();
  });
}
  
bloquearSelecaoTexto()
  

// ...

window.addEventListener('load', function() {
  var div2 = document.querySelector('.divbotaoClick');

  var divWidth = (div2.offsetWidth/3); // Largura da div
  var divHeight = div2.offsetHeight/3; // Altura da div

  var randomX = Math.floor(Math.random() * divWidth); // Posição X aleatória dentro da div
  var randomY = Math.floor(Math.random() * divHeight); // Posição Y aleatória dentro da div

  var moeda = document.createElement('div');
  moeda.classList.add('moeda');
  moeda.style.left = randomX+800 + 'px';
  moeda.style.top = randomY+350 + 'px';

  div2.appendChild(moeda);

  setTimeout(function() {
    div2.removeChild(moeda);
  }, 1000);

  // Aplica o efeito de zoom aos elementos de imagem dos slimes
  var slimeImages = document.querySelectorAll('.slime img');
  slimeImages.forEach(function(image) {
    zoomImage(image);
  });
});




$(document).ready(function () {
    // Manipulador de evento para o clique no botão
  $("#myButton").click(function () {
    // Chamada AJAX para o manipulador de eventos no servidor
    $.ajax({
        type: "POST",
        url: "/Main",
        data: { handler: "IncrementUpgradeValue" },
        success: function (response) {
            // Atualiza o valor exibido na página
            $("#upgradeValue").text(response.upgradeValue);
        },
        error: function () {
            alert("Erro ao incrementar o valor!");
        }
    });
  });
});