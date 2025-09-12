# 🥋 Guía de Instalación - KOF Verde en Fightcade

Bienvenidos a esta guía que preparé con mucho cariño 💚 para que puedan jugar **KOF Verde**.  
Muchos me han estado preguntando cómo instalarlo, así que aquí tienen el tutorial paso a paso.

---

## 📑 Índice
1. [Requisitos previos](#-requisitos-previos)
2. [Descarga de ROMs KOF Verde](#-descargas-de-la-rom-kof-verde)
3. [Método 1 - ROM Switcher](#-método-1-usando-rom-switcher)
4. [Método 2 - Manual](#-método-2-manual)
5. [Notas importantes](#-notas-importantes)
6. [Construido con 🛠️](#-construido-con-️)
7. [Autores ✒️](#-autores-️)

---

## ✅ Requisitos previos
Debes tener instalado lo siguiente:

- Fightcade 👉 [Tutorial de instalación aquí (Geezy KOF)](https://www.tiktok.com/@geezy_kof/video/7241977355890216197?lang=es)
- KOF 2002 (normal)
- KOF 2002 Plus

---

## 💾 Descargas de la ROM KOF Verde
Descarga los archivos necesarios:

- [kof2002_verde.zip](https://github.com/rugalero3000/RomSwitcher-KOF2002/raw/refs/heads/main/kof2002_verde/kof2002_verde.zip)  
- [kf2k2pls_verde.zip](https://github.com/rugalero3000/RomSwitcher-KOF2002/raw/refs/heads/main/kof2002_verde/kf2k2pls_verde.zip)

---

## ⚡ Métodos de instalación
Puedes instalar KOF Verde de dos formas:  
- [Método 1 (Usando ROM Switcher)](#-método-1-usando-rom-switcher)  
- [Método 2 (Manual)](#-método-2-manual)  

---

## 🎛️ Método 1 (Usando ROM Switcher)

ROM Switcher KOF 2002 es un programa que nos permite cambiar en un solo clic entre las versiones **normal** y **verde** de KOF 2002 en Fightcade.


### 🔧 Instalación
1. Descarga el switcher:  
   👉 [RomSwitcher.exe](https://github.com/rugalero3000/RomSwitcher-KOF2002/releases/download/v1.0.0/RomSwitcher.exe)
2. Asegúrate de tener las ROMs originales:
   - `kof2002.zip`
   - `kf2k2pls.zip`

3. Coloca las ROMs verdes dentro de la carpeta `ROMs` de Fightcade:
    ```bash
   Fightcade
   └───ROMs
       ├───kof2002_verde.zip
       └───kf2k2pls_verde.zip
    ```
4. Ejecuta el **Rom Switcher** y sigue las instrucciones.
![](https://github.com/user-attachments/assets/8fc3d046-7913-4774-a537-e731126a69e5)

    Esto iniciará el programa y comenzará a detectar las ROMs en la carpeta de instalación por defecto (Documentos\Fightcade\emulator\fbneo\ROMs), de no encontrar la carpeta por defecto, entonces tendrás que indicar donde se encuentra la carpeta ROMs.

El programa organizará tus carpetas de la siguiente manera:
```bash
Fightcade
└───ROMs
    ├───kof2002_original
    └───kof2002_verde
```
Dependiendo de la versión activa, la ventana del switcher cambiará de color:

- Verde = **KOF Verde**
- Morado = **KOF Original**

Al presionar el botón de **"ACTIVAR KOF ORIGINAL"** la apariencia de la ventana cambiará a morado
![](https://github.com/user-attachments/assets/2298500c-793a-4899-930f-c9dc632266f6)

Al presionar el botón de **"ACTIVAR KOF VERDE"** la apariencia de la ventana cambiará a verde
![](https://github.com/user-attachments/assets/304eff05-4e2f-4a73-a83e-eb2488c575ed)


---

## 📂 Método 2 (Manual)

Si prefieres hacerlo a mano:

1. Crea carpetas para organizar tus ROMs:
   ```bash
   Fightcade
   └───emulator
       └───fbneo
           └───ROMs
               ├───kof2002_original
               └───kof2002_verde
   ```

2. Mueve las ROMs originales (`kof2002.zip`, `kf2k2pls.zip`) a la carpeta `kof2002_original`.

3. Coloca las ROMs verdes descargadas en `kof2002_verde`.

4. Renómbralas:
   - `kof2002_verde.zip` → `kof2002.zip`
   - `kf2k2pls_verde.zip` → `kf2k2pls.zip`

    El resultado sería el siguiente:
    ```bash
    Fightcade
    └───emulator
        └───fbneo
            └───ROMs
                ├───kof2002_original
                │   ├───kof2002.zip (80,551 KB)
                │   └───kf2k2pls.zip (374 KB)
                ├───kof2002_verde
                │   ├───kof2002.zip (80,586 KB)
                │   └───kf2k2pls.zip (376 KB)
                ├───kof2002.zip (80,551 KB) <-- observar el peso
                └───kf2k2pls.zip (374 KB)   <-- observar el peso

    ```

5. Copia la versión que quieras jugar a la carpeta principal de `ROMs` reemplazando los archivos.

> 💡 Tip: Fíjate en el tamaño de los archivos, los de la KOF Verde terminan en **6**:
> - `80,586 KB` → KOF Verde  
> - `80,551 KB` → KOF Original  

---

## 📌 Notas importantes

- 🔑 Debes jugar en la **sala de KOF 2002 PLUS**.  
- 👥 Para jugar online con alguien, **ambos deben tener activada la misma versión** (verde u original).  
- 🕹️ Antes de aceptar una reta, asegúrate de activar la versión correcta en el switcher.  
- ⚠️ Si intentas jugar KOF Verde contra KOF Original tendrás **desincronización**.  

---

## Construido con 🛠️


* [C#](C#) - Lenguaje de programación
* [Net Framework 4.8](Net Framework 4.8) - Framework de desarrollo

## Autores ✒️


* **Rugalero3000** - *Gamer* - [rugalero3000](https://github.com/rugalero3000)





---
⌨️ con ❤️ por [rugalero3000](https://github.com/rugalero3000) 😊
