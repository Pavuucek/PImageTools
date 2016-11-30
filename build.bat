@ECHO OFF
nuget restore
rem call version.bat
%windir%\Microsoft.Net\Framework\v4.0.30319\msbuild PImageTools.sln /m /property:Configuration=Debug /property:Platform="Any CPU"
%windir%\Microsoft.Net\Framework\v4.0.30319\msbuild PImageTools.sln /m /property:Configuration=Release /property:Platform="Any CPU"
call gitversioner.bat ba
if ERRORLEVEL 1 pause

call gitversioner.bat w zip.bat
call zip.bat
call gitversioner.bat r zip.bat