// Elemanları seç
const inputAlani = document.getElementById("isimInput");
const buton = document.getElementById("yazdirButonu");
const userName = document.getElementById("userName");
const ciktiAlani = document.querySelector(".fadeInUpcikti"); // Çıktı divini seçtik

// Butona tıklama olayı
buton.addEventListener("click", () => {
  const girilenIsim = inputAlani.value;

  if (girilenIsim.trim() !== "") {
    userName.innerText = girilenIsim;
    // Çıktı alanını görünür yap ve animasyonu tetikle
    ciktiAlani.classList.add("show-result");
    inputAlani.value = ""; 
  } else {
    alert("Lütfen bir isim giriniz!");
  }
});