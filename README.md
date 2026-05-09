# GAMEVAULT
GameVault es una aplicación web realizada con la finalidad de gestionar y explorar una colección de videojuegos, la cuál te permite agregar títulos con su información completa y visualizarlos en un vatálogo con filtros por género.

---
 
## Capturas de pantalla
 
### Página de inicio
![Home](Screenshots/home.png)
 
### Catálogo completo
![Catálogo](Screenshots/catalogo.png)
 
### Detalle de juego
![Detalle](Screenshots/detalle.png)
 
### Formulario de agregar
![Agregar](Screenshots/agregar.png)
 
### Política de privacidad
![Privacidad](Screenshots/privacidad.png)
 
---
 
## Tecnologías utilizadas
 
| Tecnología | Descripción |
|---|---|
| **ASP.NET Core MVC** | Framework principal para la arquitectura del proyecto |
| **C#** | Lenguaje de programación del backend |
| **Razor (.cshtml)** | Motor de plantillas para las vistas |
| **HTML5 / CSS3** | Estructura y estilos de la interfaz |
| **Bootstrap** | Librería CSS para componentes base |
| **JavaScript** | Interactividad en el cliente |
| **Open Sans** | Tipografía principal vía Google Fonts |
| **Visual Studio 2022** | IDE de desarrollo |
 
---
 
## Estructura del proyecto
 
```
GameVault/
├── Controllers/
│   ├── HomeController.cs
│   └── CatalogoController.cs
├── Models/
│   └── Item.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Catalogo/
│   │   ├── Index.cshtml
│   │   ├── Agregar.cshtml
│   │   └── Detalle.cshtml
│   └── Shared/
│       └── _Layout.cshtml
└── wwwroot/
    └── Images/
        ├── GTA_V.jpg
        ├── Minecraft.jpg
        └── ...
```
 
---
 
## Funcionalidades
 
- Listado de videojuegos en tarjetas con imagen
- Filtro por género
- Vista de detalle por juego
- Formulario para agregar nuevos títulos
- Diseño gaming oscuro con paleta teal/cyan
- Ticker animado y navbar sticky
---
 
## Cómo ejecutar el proyecto
 
1. Clona o descarga el repositorio
2. Abre el archivo `.sln` en **Visual Studio 2022**
3. Presiona `Ctrl + F5` para compilar y ejecutar
4. El navegador abrirá automáticamente en `https://localhost:XXXX`
---
 
## Declaración de uso de IA
 
Este proyecto utilizó **Claude (Anthropic)** como herramienta de apoyo durante el desarrollo. La inteligencia artificial fue empleada para:
 
- Diseño y personalización del estilo visual de las vistas `.cshtml`
- Corrección de errores de compilación en Razor (escape de `@@keyframes`, `@@media`)
- Implementación del diccionario de imágenes por título de juego
- Generación de este archivo `README.md`
El uso de IA fue complementario al aprendizaje propio; la lógica del controlador, el modelo de datos y la estructura MVC fueron desarrollados de forma independiente como parte de la asignatura.
 
---
 
## Datos académicos
 
| Campo | Detalle |
|---|---|
| **Institución** | Tecnológico de Software |
| **Asignatura** | Arquitectura de Software |
| **Profesor** | Jorge Javier Pedrozo Romero |
| **Estudiante** | Giovana Ruby Díaz Anduze |
| **Grupo** | 3A |
| **Año** | 2026 |
