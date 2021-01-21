# copy DLL to OLW plugins - %homepath%\AppData\Local\OpenLiveWriter\app-0.6.2\Plugins

Copy-Item .\WLWPasteAs\bin\Debug\*.dll (Join-Path $home \AppData\Local\OpenLiveWriter\app-0.6.2\Plugins)
