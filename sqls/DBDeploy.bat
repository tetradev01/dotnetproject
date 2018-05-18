@echo off

SET DIR=%~d0%~p0%

SET database.name="customers"
SET sql.files.directory="%DIR%\sqls"
SET server.database="USER-PC\SQLEXPRESS"
SET repository.path="https://github.com/chucknorris/roundhouse.git"
SET version.file="_BuildInfo.xml"
SET version.xpath="//buildInfo/version"
SET environment="LOCAL"

"%DIR%rh" --silent /d=%database.name% /f=%sql.files.directory% /s=%server.database%  /env=%environment%