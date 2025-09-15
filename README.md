# FishingApp 🎣
<img src="https://img.icons8.com/color/96/fishing.png" alt="logo" width="120"/>

[![Build Status](https://github.com/Juanzett/Fishing-App/actions/.github/workflows/ci.yml/badge.svg)](https://github.com/Juanzett/FishingApp/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg)](CONTRIBUTING.md)

---
Aplicación de pesca enfocada en Argentina que combina registro personal, comunidad y contenido educativo.  
Permite guardar ubicaciones de pesca con GPS, registrar capturas, compartir fotos y consultar información sobre especies y técnicas locales.

---

## 🚀 Propósito
El objetivo es desarrollar una **aplicación móvil y web multiplataforma** usando **.NET MAUI + Blazor** que funcione como una mini red social de pesca.  
La idea surge de la necesidad de tener una herramienta **localizada** (Argentina/LatAm), diferente a apps globales como *Fishing Points*, que priorice:
- Cultura y expresiones argentinas de pesca (ejemplo: “hay pique”).
- Comunidad local con foros y publicaciones.
- Contenido educativo sobre cañas, anzuelos, carnadas y técnicas.
- Información de especies y vedas argentinas.

---

## 🛠 Stack Tecnológico
- **Lenguaje:** C# .NET
- **Framework principal:** .NET MAUI + Blazor Hybrid
- **UI Components:** MudBlazor
- **Base de datos:** (a definir, posiblemente SQLite local + API para datos remotos)
- **Control de versiones:** Git + GitHub
- **CI/CD:** GitHub Actions

---

## 🗺️ Roadmap de desarrollo

### 📍 Estado actual
- ✅ Idea definida y diferenciación respecto a competidores globales.
- ✅ Entorno instalado: .NET MAUI + Blazor en Visual Studio.
- ✅ Repositorio inicial en GitHub con documentación básica.

### 🔜 Próximos pasos
1. **MVP**  
   - Pantalla inicial con login básico.  
   - Registro manual de ubicación + comentarios sobre pique.  
   - Ejemplo de UI con MudBlazor.  

2. **Fase 1 – Core features**  
   - GPS para guardar puntos de pesca.  
   - Subida de fotos vinculadas a ubicaciones.  
   - Sección educativa inicial (tipos de pesca, cañas, anzuelos).  
   - Glosario de frases de pescadores argentinos.  

3. **Fase 2 – Comunidad**  
   - Foros y publicaciones.  
   - Likes/comentarios.  
   - Ranking local de usuarios.  

4. **Fase 3 – Avanzado**  
   - Mapas offline.  
   - Alertas de clima y vedas.  
   - Sincronización entre dispositivos.  
   - Internacionalización (expandir más allá de Argentina).  

### 📅 Futuro
- Integración con GPS en tiempo real.
- Modo offline con sincronización.
- Clima en tiempo real.
- Eventos y rankings de pesca.
- Comunidad con comentarios y reacciones.
---
## 📂 Estructura del Repositorio

FishingApp/
│── README.md # Documentación principal
│── CONTRIBUTING.md # Guía para contribuir
│── .github/workflows/ # Workflows de CI/CD
│ └── ci.yml
│── src/ # Código fuente
│── docs/ # Documentación extendida
│── tests/ # Pruebas

---
## 🤝 Cómo contribuir
Las contribuciones son bienvenidas 🎉.  
Revisá la guía en [CONTRIBUTING.md](CONTRIBUTING.md).

Pasos rápidos:
1. Haz un fork del repo.
2. Crea una branch: `git checkout -b feature/nueva-funcionalidad`.
3. Commit: `git commit -m "Agrego nueva funcionalidad"`.
4. Push: `git push origin feature/nueva-funcionalidad`.
5. Abre un Pull Request.
---

## 📌 Licencia
Este proyecto está bajo la licencia MIT.  
Consulta el archivo [LICENSE](LICENSE) para más información.
By Juanzet
