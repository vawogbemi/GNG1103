# GNG1103 Project

## How to use

    Install git
> https://git-scm.com/downloads 
 
    Open cmd or terminal or git bash and enter
> cd (change directory) to select desired location to install the program. 
> press TAB can help auto complete the path eg. cd Doc-TAB will auto spell to $home/ cd Documents
 
> git clone https://github.com/victorawogbemi/GNG1103.git

    Open Unity Open the folder/demo scene to use.
 
## How to edit

    Editing the video being played:

>   Open Assets/Adrenak/UniVRMedia/Demo/ and open the context.cs file.

>   Edit player.Video.url = "insert your http or file link here";



## More Info

    ../Scripts/CameraControls.cs and ../Scripts/VRMediaPlayer
    are pretty much how to edit the main settings.
    
    this is still prototype so I might change which template if I find a better one.
    
    the program also seems to have an AudioSampleProvider buffer overflow which makes it lag
    
    the camera flexibility can be changed under public static float ClampAngle and the variables minimumY maximumX etc
    
    Also note that this is the easy part and we still have to work on the interface which I think will be harder.

## Acknowledgement

Forked from https://github.com/adrenak/UniVRMedia
