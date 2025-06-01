<h1 align="center">Jellyfin Plugin MyTube</h1>
<p align="center"><b><a href="README.md">English</a> | 中文</b></p>

<p align="center">
<img alt="Plugin Banner" src="https://github.com/Topbcy/jellyfin-plugin-mytube/blob/main/banner.png?raw=true"/>

<p align="center">
<a href="https://github.com/Topbcy/jellyfin-plugin-mytube">
<img alt="Downloads" src="https://img.shields.io/github/downloads/Topbcy/jellyfin-plugin-mytube/total">
</a>
<a href="https://github.com/Topbcy/jellyfin-plugin-mytube/releases">
<img alt="Releases" src="https://img.shields.io/github/v/release/Topbcy/jellyfin-plugin-mytube?include_prereleases&logo=smartthings">
</a> 
</p>

## 關於
基於 [Jellyfin-Plugin-Metatube](https://github.com/metatube-community/jellyfin-plugin-metatube)
<br>原作者 [Metatube-community](https://github.com/metatube-community)
<br>同步更新於 Metatube

## 功能
新增第二個 Metatube 插件，允許使用不同配置刮削。<br>
例如無碼一組、有碼一組，可增加刮削效率。<br>

## 安裝
- Jellyfin
<br> 1. 進入 Jellyfin 控制台 > 擴充功能/目錄 > 設定/儲存庫 , 新增:
<br> 2. 資源庫名稱: MyTube
<br> 3. 資源庫網址: https://raw.githubusercontent.com/Topbcy/jellyfin-plugin-mytube/refs/heads/main/manifest.json
<br> 4. 找到 "MyTube" 擴充功能/目錄，點擊 "安裝"
<br> 5. 重啟 Jellyfin</br></br>
- Emby
<br> 1. 從 "Releases" 下載最新 MyTube
<br> 2. 解壓縮 MyTube.dll 檔案
<br> 3. 將 MyTube.dll 檔案複製到 Emby 的插件目錄中
<br> 4. 重啟 Emby.
<br>_注意：未來的 Emby 插件更新將通過排程任務在背景自動處理。_


## 平台
[![Jellyfin](https://img.shields.io/static/v1?color=%2300A4DC&style=for-the-badge&label=Jellyfin&logo=jellyfin&message=10.10.x)](https://jellyfin.org/)
[![Emby](https://img.shields.io/static/v1?color=%2352B54B&style=for-the-badge&label=Emby&logo=emby&message=4.8.x)](https://emby.media/)
<br>_注意：此專案僅支援穩定版本。_


## Acknowledgments
Special thanks to [xjasonlyu](https://github.com/xjasonlyu) for the [original jellyfin-plugin-metatube project](https://github.com/metatube-community/jellyfin-plugin-metatube), which serves as the foundation for this project.
