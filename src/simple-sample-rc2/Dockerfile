FROM microsoft/dotnet:latest

ENV http_proxy "http://192.168.56.102:8889"
ENV https_proxy "http://192.168.56.102:8889"

COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]

ADD myProgramName.sh /var/apps/myProgramName.sh
ADD supervisord.conf /etc/supervisor/conf.d/supervisord.conf
CMD ["/usr/bin/supervisord"]

EXPOSE 5000
ENTRYPOINT ["dotnet", "run"]
