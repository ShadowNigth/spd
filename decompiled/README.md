# Descompilación completa — strike_port_destruction_spd.apk

Salida generada a partir de `../strike_port_destruction_spd.apk` (SHA-256 `d6f2c4c7a0d943474ad8be25637ec70198caf69907e27a97be23f0bb8568d464`).

## Identidad del APK

| Dato | Valor |
|---|---|
| Paquete | `com.DZTeam.StrikePortDestructionLegacy` |
| Versión | `0.007ob2` (versionCode 6) |
| minSdk / targetSdk | 16 / 29 |
| Motor | Unity **2017.4.36f1**, backend **Mono** (81 ensamblados .NET) |
| ABIs | `armeabi-v7a`, `x86` |
| Firma | v1 (JAR, `META-INF/DEADZONE.*`) + bloque APK Signature Block v2 |
| Permisos | `INTERNET`, `WRITE_EXTERNAL_STORAGE` |
| build-id Unity | `8c2fe7d9-5030-4a7e-9e54-b97d5eea119e` |

El `classes.dex` es mínimo (109 clases / 547 métodos): reproductor Unity, Anti-Cheat Toolkit y FMOD.
La lógica del juego está en código administrado (.NET) y en assets de Unity, no en Java.

## Estructura de la salida

### 1. `apk_raw/` — APK extraído tal cual (163 MB)
Contenido literal del ZIP: `AndroidManifest.xml` binario, `classes.dex`, `res/`, `resources.arsc`,
`lib/` (`.so`) y `assets/`.

### 2. `apktool/` — decodificación con apktool (163 MB)
- `AndroidManifest.xml` legible, `res/` con recursos y valores decodificados (`resources.arsc` expandido), `apktool.yml`.
- `smali/` — **109 archivos smali** (desensamblado completo del DEX).
- `original/` — copia del manifest/dex originales; permite reconstruir con `apktool b`.

### 3. `jadx/` — código Java (328 KB)
`jadx/sources/` con **39 archivos .java** en `com.DZTeam.StrikePortDestructionLegacy`,
`com.unity3d.player`, `net.codestage.actk`, `org.fmod`, `bitter.jnibridge`.

### 4. `unity/Data/` — carpeta estándar de Unity reconstruida (65 MB)
El APK traía `assets/bin/Data` con nombres de archivo sustituidos por hashes MD5 y los
`sharedassets*.assets` troceados en `.split0..N`. Aquí están **reensamblados y con nombre canónico**
(`level0..4`, `sharedassets0..3.assets`, `globalgamemanagers`, `Managed/`, …), que es lo que esperan
las herramientas de Unity.

### 5. `AssetRipperExport/` — proyecto Unity del juego base (80 MB)
Exportación con AssetRipper 2.0 (`ExportedProject/`, editor 2017.4.36f1). Nº de activos (sin `.meta`):

| Carpeta | Activos | Contenido |
|---|---|---|
| `Texture2D/` | 160 | PNG |
| `Sprite/` | 71 | sprites |
| `Mesh/` | 36 | mallas |
| `Material/` | 63 | materiales |
| `AnimationClip/` | 156 | animaciones |
| `AudioClip/` | 6 | audio |
| `Shader/` | 31 | shaders |
| `GameObject/` | 59 | prefabs |
| `Font/`, `Cubemap/`, `RenderTexture/` | 5 / 13 / 1 | fuentes y cubemaps |
| `MonoBehaviour/`, `Resources/`, `GameRes/` | 42 / 108 / 14 | datos serializados y niveles |
| `Scripts/` | 481 .cs | **C# descompilado** de `Assembly-CSharp` y `Assembly-UnityScript` |
| `Plugins/` | 308 .cs | `Assembly-CSharp-firstpass` y `Assembly-UnityScript-firstpass` en C# |

Escenas: `0.unity`, `1.unity`, `Updater.unity` y los niveles `GameRes/Levels/awp_lego_2.unity`,
`GameRes/Levels/$2000$.unity`.

### 6. `GameCacheExport/` — contenido descargable (750 MB)
`assets/GameCache.7z` (50 MB) contiene **140 AssetBundles** (`UnityFS`, Unity 2017.4.36f1) con modelos,
texturas y sonidos del juego. Extraídos en `gamecache/` y convertidos con AssetRipper:

| Carpeta | Activos |
|---|---|
| `Texture2D/` | 320 (PNG, hasta 1024×1024) |
| `AudioClip/` | 472 (.ogg) |
| `AnimationClip/` | 224 |
| `Shader/` | 226 |
| `Material/` | 186 |
| `Mesh/` | 143 |
| `gameres/` | 204 |
| `MonoBehaviour/` | 120 |

Armas (`rif_ak47`, `snip_awp`, `pist_deagle`…), personajes (`player_idf`, `player_leet`…),
partículas y granadas.

### 7. `csharp/` — C# completo con ILSpy (9,5 MB, 1.425 archivos)
Un proyecto por ensamblado, incluidos los que AssetRipper solo copiaba como DLL:

```
Assembly-CSharp (455 tipos)   Assembly-CSharp-firstpass (229)   Assembly-UnityScript (14)
Assembly-UnityScript-firstpass (64)   ACTk.Runtime (46)   Photon3Unity3D (36)
Sirenix.Serialization (183)   Sirenix.Utilities (48)   Sirenix.OdinInspector.* (123)
Ionic.Zip (91)   protobuf-net (88)   JM.LinqFaster (8)   UpdaterDownloader (1)
```
Namespaces del juego conservados: `SPD.Audio`, `SPD.Triggers`, `SPD.EditorAttributes`,
`SPD.UpdaterDownloader`; el resto de clases propias está en el namespace raíz con nombres ofuscados.

### 8. `gamecache/` — AssetBundles originales sin tocar (116 MB, 140 archivos)
### 9. `apk_raw/assets/bin/Data/Managed/` — las 81 DLL originales de .NET

### 10. Inventarios
- `inventario_assets.csv` — 3.472 activos: origen (`base`/`gamecache`), tipo, nombre, ruta y tamaño.
- `csharp_indice.csv` — 1.393 tipos C#: ensamblado, namespace, clase/struct/enum y archivo.

## Notas y límites

- **Ofuscación de nombres**: los tipos/métodos de `Assembly-CSharp` tienen identificadores aleatorios
  (`EIODNIHEEML`, `NGANNJFFIMG`…), pero la lógica, las firmas y los namespaces son legibles.
- `libunity.so`, `libmonobdwgc-2.0.so`, `libmain.so` son binarios estándar del motor Unity 2017.4:
  no se desensamblaron porque no contienen lógica del juego. `liblzma.so` lo usa `GameCache.7z`.
- No se renombraron clases ni se generó un proyecto compilable: la salida es de lectura/ingeniería inversa.
- La firma no se verificó criptográficamente; los datos de firma son los declarados por el APK.

## Cómo seguir trabajando

```bash
# Abrir en el editor de Unity (requiere Unity 2017.4.x)
decompiled/AssetRipperExport/ExportedProject
decompiled/GameCacheExport/ExportedProject

# Navegar el C#
decompiled/csharp/Assembly-CSharp/Assembly-CSharp.csproj

# Reconstruir el APK desde apktool
apktool b decompiled/apktool -o rebuild.apk
```

Herramientas usadas: apktool 2.10.0, jadx 1.4.7, AssetRipper 2.0.0, ILSpy (ilspycmd 8.2), 7-Zip 26.05.
