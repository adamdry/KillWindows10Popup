# KillWindows10Popup

## Overview
Dead simple C# app to kill the annoying Windows 10 popup and system tray icon.

There are other ways to get rid of it such as uninstalling updates etc... however this method simply kills the popup - if you want to upgrade later just stop running KillWindows10Popup.exe and you're good.

## How To Use
Download KillWindows10Popup.exe from the exe folder. Run it, click the engage button.

The app checks for the processes that the Windows 10 popup runs under (GWX and GWXUX) every 10 seconds and kills them. The app is non-instrusive and uses very little memory and CPU.

The app doesn't have a graceful shutdown so once running use task manager to end the process if you want to stop it.

[Create a scheduled task] (http://www.howtogeek.com/138159/how-to-enable-programs-and-custom-scripts-to-run-at-boot/) to run the app on boot up.