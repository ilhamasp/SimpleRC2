FROM microsoft/dotnet:latest

ENV http_proxy "http://192.168.56.102:8889"
ENV https_proxy "http://192.168.56.102:8889"

ADD jenkinsrc2.sh /var/apps/jenkinsrc2.sh
ADD supervisord.conf /etc/supervisor/conf.d/supervisord.conf
EXPOSE 5000
CMD ["/usr/bin/supervisord"]

COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]

ENTRYPOINT ["dotnet", "run"]
