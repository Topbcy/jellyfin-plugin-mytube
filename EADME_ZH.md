<h1 align="center">Jellyfin Plugin MyTube</h1>
<p align="center"><b>English | <a href="README_ZH.md">中文</a></b></p>
<p align="center">
<a href="https://github.com/Topbcy/jellyfin-plugin-mytube">
<img alt="Downloads" src="https://img.shields.io/github/downloads/Topbcy/jellyfin-plugin-mytube/total">
</a>
<a href="https://github.com/Topbcy/jellyfin-plugin-mytube/releases">
<img alt="Releases" src="https://img.shields.io/github/v/release/Topbcy/jellyfin-plugin-mytube?include_prereleases&logo=smartthings">
</a> 
</p>

## About
Built on top of [Jellyfin-Plugin-Metatube](https://github.com/metatube-community/jellyfin-plugin-metatube)
<br>Original Author [Metatube-community](https://github.com/metatube-community)

## Features
To add a second plugin, enabling two plugins with different configuration settings.<br>

## Installation
- Jellyfin
<br> 1. Go to Jellyfin Control Panel > Plugin Catalog/Repositories > Settings, and add:
<br> 2. Repository Name: MyTube
<br> 3. Repository URL: https://raw.githubusercontent.com/Topbcy/jellyfin-plugin-mytube/refs/heads/main/manifest.json
<br> 4. Find "MyTube" under the plugin directory and click Install.
<br> 5. Restart the Jellyfin.</br></br>
- Emby
<br> 1. Download the latest MyTube plugin from "Releases"
<br> 2. Extract the MyTube.dll file.
<br> 3. Copy the dll file into the Emby plugins directory.
<br> 4. Restart the Emby.
<br> Note: Future plugin updates for Emby will be automatically handled in the background via scheduled tasks.


## Platforms
[![Jellyfin](https://img.shields.io/static/v1?color=%2300A4DC&style=for-the-badge&label=Jellyfin&logo=jellyfin&message=10.10.x)](https://jellyfin.org/)
[![Emby](https://img.shields.io/static/v1?color=%2352B54B&style=for-the-badge&label=Emby&logo=emby&message=4.8.x)](https://emby.media/)
<br>_NOTE: This project will only support stable versions._


## Acknowledgments
Special thanks to [xjasonlyu](https://github.com/xjasonlyu) for the [original jellyfin-plugin-metatube project](https://github.com/metatube-community/jellyfin-plugin-metatube), which serves as the foundation for this project.
