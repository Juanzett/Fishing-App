# Guía de contribución

¡Gracias por querer colaborar!

## Requisitos locales
- Visual Studio 2022 17.11+ con workload .NET MAUI.
- .NET 9 SDK.
- Android SDK/Emulador (para Android).

## Cómo empezar
1. Haz un fork del repositorio.
2. Crea una rama desde `main`:
   - `feat/<descripcion-corta>` para funcionalidades.
   - `fix/<descripcion-corta>` para bugs.
3. Configura el entorno:
   - Abre `src/FishingApp/FishingApp.sln` en VS.
   - Restaura paquetes con __Restore__ o `dotnet restore`.
   - Verifica el build local (Windows y/o Android).
4. Asegura que el código compila y sigue el estilo C# (análisis/nullable activos).

## Estilo y prácticas
- C# 13, nullable enable, evitar warnings.
- Pequeños PRs con propósito claro.
- Commits descriptivos (imperativo): “Add…”, “Fix…”, “Refactor…”.
- Incluye notas de pruebas manuales (qué plataforma, pasos y resultado).

## Tests
- Coloca proyectos de prueba en `/tests`.
- Nombra los proyectos `*.Tests`.
- Por ahora: tests unitarios básicos (xUnit/NUnit) y pruebas manuales en plataformas.

## Revisiones
- CI debe pasar.
- Responde comentarios de revisión.
- El mantenedor fusionará cuando esté listo.

## Reporte de bugs
- Abre un issue con:
  - Pasos para reproducir
  - Resultado esperado vs actual
  - Plataforma/Framework (Windows/Android, versión)
  - Logs/screenshot si aplica

## Sugerencias
- Usa Discussions/Issues para proponer features.
- Adjunta mockups simples cuando hables de UI/UX.