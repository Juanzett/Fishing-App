# Gu�a de contribuci�n

�Gracias por querer colaborar!

## Requisitos locales
- Visual Studio 2022 17.11+ con workload .NET MAUI.
- .NET 9 SDK.
- Android SDK/Emulador (para Android).

## C�mo empezar
1. Haz un fork del repositorio.
2. Crea una rama desde `main`:
   - `feat/<descripcion-corta>` para funcionalidades.
   - `fix/<descripcion-corta>` para bugs.
3. Configura el entorno:
   - Abre `src/FishingApp/FishingApp.sln` en VS.
   - Restaura paquetes con __Restore__ o `dotnet restore`.
   - Verifica el build local (Windows y/o Android).
4. Asegura que el c�digo compila y sigue el estilo C# (an�lisis/nullable activos).

## Estilo y pr�cticas
- C# 13, nullable enable, evitar warnings.
- Peque�os PRs con prop�sito claro.
- Commits descriptivos (imperativo): �Add��, �Fix��, �Refactor��.
- Incluye notas de pruebas manuales (qu� plataforma, pasos y resultado).

## Tests
- Coloca proyectos de prueba en `/tests`.
- Nombra los proyectos `*.Tests`.
- Por ahora: tests unitarios b�sicos (xUnit/NUnit) y pruebas manuales en plataformas.

## Revisiones
- CI debe pasar.
- Responde comentarios de revisi�n.
- El mantenedor fusionar� cuando est� listo.

## Reporte de bugs
- Abre un issue con:
  - Pasos para reproducir
  - Resultado esperado vs actual
  - Plataforma/Framework (Windows/Android, versi�n)
  - Logs/screenshot si aplica

## Sugerencias
- Usa Discussions/Issues para proponer features.
- Adjunta mockups simples cuando hables de UI/UX.