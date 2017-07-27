%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe JobSchedule.exe
Net Start \JobSchedule
sc config \JobSchedule start=auto
pause