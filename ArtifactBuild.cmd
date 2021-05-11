  
@echo off
pushd "%~dp0"
powershell Compress-7Zip "PhishingLnk\bin\Release" -ArchiveFileName "PhishingLnk.zip" -Format Zip
:exit
popd
@echo on
