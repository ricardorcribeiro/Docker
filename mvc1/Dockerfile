#imagem da aplicação
FROM mcr.microsoft.com/dotnet/core/aspnet
LABEL version="1.0.2" description="aplicação aspnet core mvc"
#copira o pacote publicado do origem do host pro destino que seria o container dist --> app
COPY dist /app
#indica aonde os comandos vao ser execultados no container 
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"] 