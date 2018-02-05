EmissionBlink.cs by Sylker Teles


Small solution (maybe not the best, but it works) for a blink effect on materials in Unity. Ideal for that blink effect on hitting enemies or player.

Latest tested Unity version: 2017.3.0f3

Material setup:

- You must use a shader with Emission;
- In the Unity's Standard shader you have to enable Emission by checking the corresponding box.
- You may set up a initial color for the emission, usually black (you will be able to set up a color for the blinking effect later).
- IMPORTANT: you have to set the Global Illumination to Realtime. In Unity's Standard shader, this option will appear under the Emission color.

Usage:
- Put the EmissionBlink.cs behaviour on any GameObject with a Renderer of any kind (MeshRenderer, SkinnedMeshRenderer, etc). The script will get all Renderers in children to apply the effect.
- Adjust the parameters Color, Intensity and Speed. Play around with these until you get the desired effect.
- Call EmissionBlink.Blink() from any script. For instance, when the player get hit, call Blink() from player's behaviour to perform the effect;

Enjoy :)