@ECHO OFF

rem call version.bat
%windir%\Microsoft.Net\Framework\v4.0.30319\msbuild PImageTools.sln /m /property:Configuration=Debug /property:Platform="Any CPU"
%windir%\Microsoft.Net\Framework\v4.0.30319\msbuild PImageTools.sln /m /property:Configuration=Release /property:Platform="Any CPU"
gitversioner.exe ba
if ERRORLEVEL 1 pause

gitversioner.exe w zip.bat
call zip.bat
gitversioner r zip.bat