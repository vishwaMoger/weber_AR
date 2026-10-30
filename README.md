<p align="center">
  <img width="100%" src="https://capsule-render.vercel.app/api?type=venom&color=0:0F0C29,50:302B63,100:00F5D4&height=280&section=header&text=AR%20ASSEMBLY%20GUIDE&fontSize=62&fontColor=ffffff&fontAlignY=40&stroke=00F5D4&strokeWidth=1&desc=%F0%9F%95%B6%EF%B8%8F%20Point%20%E2%80%A2%20Place%20%E2%80%A2%20Follow%20Every%20Step%20in%203D&descSize=22&descAlignY=62&animation=fadeIn" alt="AR Assembly Guide" />
</p>

<p align="center">
  <img src="https://readme-typing-svg.demolab.com?font=Orbitron&weight=700&size=22&duration=2600&pause=700&color=00F5D4&center=true&vCenter=true&width=760&lines=%3E+SCANNING+SURFACE...;%3E+PLANE+DETECTED+%E2%9C%94;%3E+PLACING+3D+MODEL...;%3E+STEP+1+%2F+51%3A+ATTACH+THE+CASTERS;%3E+PAPER+MANUALS+ARE+OVER." alt="tagline" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Unity-2022.3%20LTS-000000?style=for-the-badge&logo=unity&logoColor=white" />
  <img src="https://img.shields.io/badge/AR%20Foundation-5.1-302B63?style=for-the-badge&logo=unity&logoColor=white" />
  <img src="https://img.shields.io/badge/ARCore-Android-3DDC84?style=for-the-badge&logo=android&logoColor=white" />
  <img src="https://img.shields.io/badge/ARKit-iOS-000000?style=for-the-badge&logo=apple&logoColor=white" />
  <img src="https://img.shields.io/badge/XR%20Interaction-Toolkit%202.5-00F5D4?style=for-the-badge&logoColor=black" />
  <img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
</p>

---

<h2 align="center">📦 ➜ 📱 ➜ 🕶️ THE IDEA</h2>

<p align="center">
Flat paper manuals are hard to follow. This proof-of-concept turns a <b>product assembly manual into an interactive AR experience</b>.<br/>
Point your phone at the floor, <b>place a life-size animated 3D model</b> of the product, and walk through <b>51 assembly steps</b><br/>
with animations, illustrated instructions and <b>voice-over guidance</b>.
</p>

---

<h2 align="center">🔄 HOW IT WORKS</h2>

```mermaid
flowchart LR
    A(["📱 Open App<br/>Menu UI"]):::a --> B["📷 Scan Room<br/>AR plane detection"]:::b
    B --> C["👆 Tap a Surface<br/>AR raycast"]:::c
    C --> D["🧊 3D Model<br/>placed in the world"]:::d
    D --> E["▶️ Step Through<br/>animations + voice"]:::e
    E -- "⏭️ next / ⏮️ prev" --> E
    E --> F(["✅ Assembled!"]):::a
    classDef a fill:#00F5D4,color:#000,stroke:#fff
    classDef b fill:#302B63,color:#fff,stroke:#00F5D4
    classDef c fill:#5E4AE3,color:#fff,stroke:#fff
    classDef d fill:#9B5DE5,color:#fff,stroke:#fff
    classDef e fill:#F15BB5,color:#fff,stroke:#fff
```

---

<h2 align="center">🖼️ STEP-BY-STEP CONTENT</h2>

<p align="center">
  <img src="Assets/AR%20steps/1.png" width="32%" alt="Step 1" />
  <img src="Assets/AR%20steps/10.png" width="32%" alt="Step 10" />
  <img src="Assets/AR%20steps/20.png" width="32%" alt="Step 20" />
</p>
<p align="center">
  <img src="Assets/AR%20steps/30.png" width="32%" alt="Step 30" />
  <img src="Assets/AR%20steps/40.png" width="32%" alt="Step 40" />
  <img src="Assets/AR%20steps/51.png" width="32%" alt="Step 51" />
</p>
<p align="center"><sub>51 illustrated steps, synced to the 3D model's animation in AR</sub></p>

---

<p align="center">
  <img width="100%" src="docs/readme/features.svg" alt="Features: plane detection, tap to place, animated steps, voice-over, navigation, billboard UI, HDRI, assistant, cross-platform" />
</p>

---

<h2 align="center">🧠 UNDER THE HOOD</h2>

| Script | Role |
|:--|:--|
| `PlaceOnPlane.cs` | 🎯 Touch → `ARRaycastManager` raycast → spawn or move the model on a detected plane |
| `AnimationController.cs` | 🎬 Plays the model's assembly animation for the current step |
| `AnimEvents.cs` | ⏱️ Animation events that sync visuals, UI and audio |
| `ImageManager.cs` | 🖼️ Swaps the illustrated instruction for each step |
| `Pagination.cs` / `NumBUtton.cs` | 📑 Step navigation and numbered jump buttons |
| `ToggleButton.cs` | 🔘 Show / hide UI panels |
| `LookAt_camera.cs` | 👀 Billboard behaviour for world-space UI |

**Scenes:** `Menu_UI` → `BlankAR`

---

<h2 align="center">🚀 RUN IT</h2>

```bash
git clone https://github.com/vishwaMoger/weber_AR.git
```

1. Open the folder in **Unity 2022.3 LTS**.
2. Switch the platform to **Android** (ARCore) or **iOS** (ARKit) in *Build Settings*.
3. Add `Menu_UI` and `BlankAR` to the build, then **Build & Run** on an AR-capable device.

---

<p align="center">
  <b>Made with ❤️ and 🕶️ by <a href="https://github.com/vishwaMoger">Vishwa Moger</a></b><br/>
  <sub>Game Developer · 3+ years · Bangalore, India</sub>
</p>

<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=0:00F5D4,50:302B63,100:0F0C29&height=120&section=footer" />
