# A sample of [ONVIF Device Manager (ODM)](https://sourceforge.net/projects/onvifdm/)
## Built and tested on Visual Studio 2013
I could not build this project on Visual Studio 2017 due to this [issue](https://stackoverflow.com/questions/55102502/migrating-from-visual-c-2012-2013-to-vsc-2015-unresolved-token-symbols) (a number of breaking changes in VS2015). Anyone who can help me solve this is highly appreciated.
## Description
The solution is composed of three solution projects and one Windows Forms application  (It is where you can customize your code).
ONVIF Device Manager uses **Live555** to process RTSP streaming from IP cameras. Since Live555 is written in C++, they wrote a C++ project named **odm.player.lib** to captured desired **Live555** functions. Then, a C++ wrapper named **odm.player.net** (C++/CLI Class Library) is written to utilize **Live555** functions. A project named **odm.player.media** is written to manage video information such as the pixel format of a video. Finally, they created a project named **odm.player.host** to control and manage resource while playing an RTSP streaming.  
**Note**: If you want to reuse ODM source code, you are better download the latest code in [branches](https://sourceforge.net/p/onvifdm/code/HEAD/tree/branches/). Trunk is used for ODM development purpose.
### Dependency libraries
Rx-core (.NET version 4.0): *System.Reactive.Linq, System.Reactive.Interfaces, System.Reactive.Core*  
Decoding: *avcodec-54, avformat-54, avutil-51, msvcp110, msvcr110, swscale-2*
### How to use
You need to copy all of this dependency libraries to a running folder where you execute your application (bin/debug/)
The output of this project is an image with pixel format (bgra32, check line#65, #68 of OdmPlayer.cs). The OdmPlayer.cs is obtained from a WinformSample project at https://sourceforge.net/projects/onvifdm/files/%21sample_winform/.

### License
Check the license of [ONVIF Device Manager](https://sourceforge.net/projects/onvifdm/)  
GNU General Public License version 2.0 (GPLv2)