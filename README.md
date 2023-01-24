# Blender Console Render(BCR)
GUI FOR BLENDER RENDER AT CMD

This is our small project to facilitate Render through CMD.

## How to use

1 field - Choose blender.exe. Version recomended 2.8+.
2 field - Choose Blender project. Without gaps, sings, only latin symbols.
3 field - Choose path to folder where render will save.
4 field - Frame name. #-number. Frame_## = Frame_01, Frame_02...
Number
| PARAMETER              | TYPE| DESCRIPTION
| ---------------------- | ----| ----------------------------------------------------------------------------|
| CPU thread             |  -t | If you want to use gpu check setings in Blender, text here 0, all threads 0 |
| Start frame            |  -s |                                                                             |
| Last frame             |  -e |                                                                             |
| Frame skip             |  -j | Set up number of frames skiped after the rendered one                       |