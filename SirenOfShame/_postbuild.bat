set BIN_DIR=%1
xcopy /Y /D ..\Releases\wyUpdate\*.* %BIN_DIR%
xcopy /Y /D ..\Libs\TeamFoundation\*.* %BIN_DIR%
