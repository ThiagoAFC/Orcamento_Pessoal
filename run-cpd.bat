@echo off
set CPD_PATH=C:\Orcamento_Pessoal\pmd-bin-7.8.0\bin\pmd.bat
%CPD_PATH% cpd --minimum-tokens 40 --dir . --language cs --format text
pause