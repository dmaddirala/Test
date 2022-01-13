# Setup DealerWebsites on your machine
## Initial Setup

### Clone DealerWebsites
Run the following command to clone the repository
```bash
git clone https://github.com/carwale/DealerWebsites.git
```
This will take some time. Let it run in the background

### Install MSBuild
MSBuild v15.9 is required to build DealerWebsites. Please perform the following steps to installl it.

- Download vs_buildtools__1931417028.1540448499.exe from [here](https://drive.google.com/file/d/1jIKC_JCgiWbyg-3pbGMpmvGOAMt_rF9U/view?usp=sharing)
- This will start a window that will have default options of installing msbuild installation selected. Select Web Development build tools and start installation
- This will install build tools at `C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin`
- Add it to `PATH` environment variable
- Make sure there are no other build paths in the PATH variable


### Install Nuget
- Download nuget.ext from https://www.nuget.org/downloads and move it to `C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin` folder

## Build DealerWebsites
- Open the project in vscode
- Run command `nuget restore` in terminal
- Now build(`Ctrl` + `Shift` + `B`) the DealerWebsites project
  
### Configure IIS
- Create a website in IIS with the name DealerWebsites.
- Choose the port you want. Preferably port 80. (you might have to remove the default web site from IIS)
- Point it to &lt;your github root&gt;/DealerWebsites folder

### Changes in web.config
- Go to web.config in DealerWebsites folder
- Replace 
    - `apiHostUrl`,`TCApiHost` url with "www.autobiz.in/"
    - `AutobizHostUrl` value with "https://www.autobiz.in/"
- Comment Ctstock API,ct lead API and ct Sellcar API and replace with below code for car stock
    `- &lt;add key="CTStockAPI" value="https://api.cartradeexchange.com/own_website/"/&gt;
    - &lt;add key="CTLeadAPI" value="https://www.cartradeexchange.com/dms_apis/"/&gt;
    - &lt;add key="CTSellCarAPI" value="https://www.cartradeexchange.com/cw_apis/"/&gt;`
- Change rule name to current developing dealer name.


Now go to browser and open DealerWebsites. :) 
