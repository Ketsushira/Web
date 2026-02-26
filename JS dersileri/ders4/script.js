function gonder() {
  const input = document.getElementById('mesaj');
  const box = document.querySelector('.messagebox');
  if (!input || !box) return;
  const text = input.value.trim();
  if (!text) return;

  const d = new Date();
  const saat = String(d.getHours()).padStart(2, '0');
  const dakika = String(d.getMinutes()).padStart(2, '0');

  const wrapper = document.createElement('div');
  wrapper.className = 'gidenMesaj';

  const img = document.createElement('img');
  img.src = 'profil.png';
  img.alt = '';
  img.onerror = function () { this.style.display = 'none'; };
  wrapper.appendChild(img);

  const content = document.createElement('div');
  content.className = 'mesajIcerik';
  content.textContent = text;
  wrapper.appendChild(content);

  const ts = document.createElement('span');
  ts.className = 'tarih';
  ts.textContent = `${saat}:${dakika}`;
  wrapper.appendChild(ts);

  box.appendChild(wrapper);
  input.value = '';
  box.scrollTop = box.scrollHeight;
}