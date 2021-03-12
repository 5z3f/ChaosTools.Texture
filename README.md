# ChaosTools.Texture <img align="left" src="https://user-images.githubusercontent.com/39301116/111002846-69464000-8386-11eb-8a3e-6e16f285cddd.png" width="48px">
Last Chaos Texture Tool
<br/>
**ChaosLib.D3D** library is required for this project, you can find it [here](https://github.com/5z3f/ChaosLib/tree/main/ChaosLib.D3D)

![ChaosTools Texture_ZphRIBeVKZ](https://user-images.githubusercontent.com/39301116/111004954-38680a00-838a-11eb-8a12-14ffca08ce29.png)

## Ready features:
- animated texture, various import/export formats
- hue change per frame or all frames, zoom
- change duration between frames
- texture flag editor
- color2transparent function (pick color by right clicking on texture)
- import uv map from mesh file (last chaos & serious engine 1.10 supported)
- drag and drop (multifile drop is not supported for tex and gif files)
- create animated texture from gif file
- export separated frames
- you can pin it to .tex extension

## Supported formats:
 * Import
    - TEX (uncompressed, dxt1, dxt3, dxt5)
    - PNG, JPEG, BMP
    - GIF
    - TARGA
    - DDS

 * Export
    - TEX (only as uncompressed for now)
    - PNG, JPEG, BMP

* If you're creating animated texture please make sure all frames has the same width, height and pixelformat