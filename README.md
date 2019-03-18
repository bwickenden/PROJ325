# PROJ325
Final Year project using Nitinol wire with the combination of Vibration motors to provide haptic feedback


The project will be using High temp Nitinol Wire to project a force upon the user. The Haptic device will be in the form of a glove which will have 3D printed components (Created in Auto Desk Fusion 360) attached to it which will be used to support the Nitinol wires. 

Along side the Haptic devices I am also creating a simulation to demo the feedback. In order to do this I'm using Blender to create a 3D model of a Hand. Then using Blender to create an animation of each finger moving using key frames. The 3D model and animations are then imported over to Unity which are then triggered using G H J K L keys. When a key is pressed the respected finger moves, but a singal is also sent to an Arduino which will then signal for the Nitinol wire to contract causing the the finger of the user to bend as the one on the model. 
