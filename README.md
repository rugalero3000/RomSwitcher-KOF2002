# Introducción
Bienvenidos a esta página que les he preparado con mucho cariño para jugar al KOF Verde, debido a que me han estado preguntando mucho como jugarla les orientaré como instalar KOF Verde.

Previo a ello asumiré que ya tienen instalado lo siguiente:

- Fightcade (en caso de no tenerlo, tienen el link tutorial de instalación [aquí en el canal de Geezy KOF](https://www.tiktok.com/@geezy_kof/video/7241977355890216197?lang=es))
- KOF 2002 normal
- KOF 2002 plus

Luego descargarse las ROMS de la **KOF Verde**

## Descargas de la ROM KOF Verde
- [kof2002_verde.zip](https://github.com/rugalero3000/RomSwitcher-KOF2002/raw/refs/heads/main/kof2002_verde/kof2002_verde.zip)
- [kf2k2pls_verde.zip](https://github.com/rugalero3000/RomSwitcher-KOF2002/raw/refs/heads/main/kof2002_verde/kf2k2pls_verde.zip)

La instalación puede realizarse mediante dos metodos:
- [Metodo 1 (Usando ROM Switcher)](#rom-switcher-kof-2002-para-fightcade)
- [Metodo 2 (Manual)](#método-2-manual)

## ROM Switcher KOF 2002 para Fightcade
ROM Switcher KOF 2002 es un programa que nos permite cambiar en un solo clic entre las versiones normal y verde de KOF 2002 en el emulador de Fightcade.



### Instalación 🔧


Descargar el Switcher de ROMs de [R3K.KOF2002.RomSwitcher.exe](https://github.com/rugalero3000/RomSwitcher-KOF2002/releases/download/v1.0.0/R3K.KOF2002.RomSwitcher.exe)


Tambien es requisito tener las ROMs de la kof normal y la kof plus original
- kof2002.zip
- kf2k2pls.zip

Asumiré que ya han instalado esas ROMs, caso contrario descargarse el rompack que contiene las ROMs originales de la normal y plus, hay muchos tutoriales en Youtube.

Luego donde se encuentra instalado Fightcade colocar las ROMs de la kof verde

```bash
Fightcade

├───ROMs
│   │───kof2002_verde.zip
│   └───kf2k2pls_verde.zip
```

Luego abrimos el [R3K.KOF2002.RomSwitcher.exe] que descargamos lineas más arriba.

![](https://github.com/user-attachments/assets/8fc3d046-7913-4774-a537-e731126a69e5)
Esto iniciará el programa y comenzará a detectar las ROMs en la carpeta de instalación por defecto (Documentos\Fightcade\emulator\fbneo\ROMs), de no encontrar la carpeta por defecto, entonces tendrás que indicar donde se encuentra la carpeta ROMs.

Esto lo hace con la intención de crear las siguientes carpetas y organizar mejor las ROMs

```bash
Fightcade

├───ROMs
│   │   
│   └───kof2002_original
│   └───kof2002_verde
```

Quedando así organizada las ROMs
```bash
Fightcade

├───ROMs
│   │   
│   └───kof2002_original
│   │      kof2002.zip
│   │       kf2k2pls.zip
│   └───kof2002_verde
│           kof2002.zip
│           kf2k2pls.zip
```

Luego cargará la ventana principal que tendrá un color dependiendo la version que tengamos actualmente (kof original o kof verde)

![](https://github.com/user-attachments/assets/2298500c-793a-4899-930f-c9dc632266f6)

Al presionar el botón de "ACTIVAR KOF VERDE" la apariencia de la ventana cambiará a verde
![](https://github.com/user-attachments/assets/304eff05-4e2f-4a73-a83e-eb2488c575ed)

y al presionar el botón de "ACTIVAR KOF ORIGINAL" la apariencia de la ventana cambiará a morado.

![](https://github.com/user-attachments/assets/2298500c-793a-4899-930f-c9dc632266f6)



Eso es todo!

PD1: Tienen que jugar en la sala del KOF 2002 PLUS

PD1: Para jugar con otra persona la version de KOF Verde, ambos deben de tener instalado y activada la version de kof verde.

PD2: Si van a retar en Fightcade hagan mencion de la kof verde, es decir, "ALGUIEN ME RETA EN KOF VERDE" de esa manera se ponen de acuerdo y encuentran retas, caso contrario van a experimentar desincronizacion al realizar una reta de kof verde vs kof plus original.

PD2: El rom lo pueden activar antes de aceptar una reta, no es necesario cerrar Fightcade.

## Método 2 (Manual)
Este metodo es bastante práctico, primero nos ubicamos en la carpeta de los ROMs
```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
```

y creamos un par de carpetas que nos serviran para organizar mejor los roms originales y los roms del kof verde, pueden poner el nombre que gusten, sugiero colocar los siguientes nombres:
- kof2002_original
- kof2002_verde

Nos quedaría organizado así las carpetas
```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            └───kof2002_verde
```

Tambien podemos apreciar las ROMs originales  del kof normal y plus (kof2002.zip y kf2k2pls.zip respectivamente)
```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            ├───kof2002_verde
            ├───kof2002.zip
            └───kf2k2pls.zip

```

Esos dos ROMS los moveremos hacia la carpeta kof2002_original, y nos estaría quedando así


```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            │   ├───kof2002.zip
            │   └───kf2k2pls.zip
            └───kof2002_verde

```

Luego los zipeados que vimos en la [sección de descarga de ROMs KOF verde](#descargas-de-la-rom-kof-verde), kof2002_verde.zip y kf2k2pls_verde.zip los colocamos dentro de la carpeta kof2002_verde, quedandonos así la jerarquía de carpetas

```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            │   ├───kof2002.zip
            │   └───kf2k2pls.zip
            └───kof2002_verde
                ├───kof2002_verde.zip
                └───kf2k2pls_verde.zip

```

Luego renombramos kof2002_verde.zip a kof2002.zip, y kf2k2pls_verde.zip a kf2k2pls.zip, quedandonos así la jerarquia de carpetas
```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            │   ├───kof2002.zip (80,551 KB)
            │   └───kf2k2pls.zip (374 KB)
            └───kof2002_verde
                ├───kof2002.zip (80,586 KB)
                └───kf2k2pls.zip (376 KB)

```

La idea es copiar las ROMS de la version que se desea jugar, es decir, si se quiere jugar la kof verde se estaría copiando los ROMS que están dentro de la carpeta kof2002_verde hacia la carpeta ROMs (si sale algun aviso le dan a reemplazar todo)

```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            │   ├───kof2002.zip (80,551 KB)
            │   └───kf2k2pls.zip (374 KB)
            ├───kof2002_verde
            │   ├───kof2002_verde.zip (80,586 KB)
            │   └───kf2k2pls_verde.zip (376 KB)
            ├───kof2002.zip (80,586 KB) <-- observar el peso
            └───kf2k2pls.zip (376 KB)   <-- observar el peso

```
Nota: Pueden notar que las roms de la kof verde tienen un 6 al final del peso (80,58**6** KB y 37**6** KB)

Ahora si se desea regresar a las ROMs originales entonces copiamos las roms que están dentro de la carpeta kof2002_original hacia la carpeta ROMs
```bash
Fightcade
└───emulator
    └───fbneo
        └───ROMs
            ├───kof2002_original
            │   ├───kof2002.zip (80,551 KB)
            │   └───kf2k2pls.zip (374 KB)
            ├───kof2002_verde
            │   ├───kof2002_verde.zip (80,586 KB)
            │   └───kf2k2pls_verde.zip (376 KB)
            ├───kof2002.zip (80,551 KB) <-- observar el peso
            └───kf2k2pls.zip (374 KB)   <-- observar el peso

```

Esa es la idea copiar las roms del kof que se desea jugar y luego reemplazar en la carpeta ROMs.

## Construido con 🛠️


* [C#](C#) - Lenguaje de programación
* [Net Framework 4.8](Net Framework 4.8) - Framework de desarrollo

## Autores ✒️


* **Rugalero3000** - *Gamer* - [rugalero3000](https://github.com/rugalero3000)





---
⌨️ con ❤️ por [rugalero3000](https://github.com/rugalero3000) 😊