@echo off
IF EXIST ".\bin\Debug\*.*" 7z a PImageTools_debug-$MajorVersion$.$MinorVersion$.$Revision$-$Commit$-$ShortHash$.zip .\bin\Debug\*.*
IF EXIST ".\bin\Release\*.*" 7z a PImageTools_release-$MajorVersion$.$MinorVersion$.$Revision$-$Commit$-$ShortHash$.zip .\bin\Release\*.*
goto :eof