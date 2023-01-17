# Docker-Test
Dockerize .Net projects with Docker.


Docker Nedir? Ne işe yarar?
	Uygulamalar Guest OS yerine Docker Engine ile ayağa kalkar. Versiyonlama yapabiliriz.
	Uygulama paylaşımı daha kolay.
	
Dockerfile Nedir?
	Projenin root klasöründe oluşturulur. Talimatlar yazılır. Uygulamamızın çalışması için gerekli komut satırları.
	Bağımlılıklar belirtilir.
	
Docker Image nedir?
	Build ettikten sonra bir talimatlara göre Image oluşur.Dockerfile a göre layer lar oluşturur. Readonly bir dosyadır.
	Program içinde bir fabrika gibi düşünebiliriz. Image ile istediğimiz kadar 
	uygulamanın çalışabilmesi için Container lar oluşturulabilir.

Docker Container Nedir?
	İçersinde uygulamanın çalışacağı ortamı bulunduran mini bir işletim sistemi. 
	Oluşturduğumuz Image lara bir read/write şekilde bir katman daha ekler.

Docker CLI nedir?
	Docker ile haberleşmemizi sağlayan komut satırı. CLI a komut yazıldığında Docker Daemon'a rest api istediği gelir.
	
Docker Registry nedir?
	Image larımızı kaydedebileceğimiz bir depo. 
	
	
--------------------------------------------------

Dockerize Console App
	Basit console uygulamasını dockerize ediyoruz. Projeye sağ tık > Add > Docker Support
	Gelen DockerFile'a Docker Hub'tan 'mcr.microsoft.com/dotnet/runtime:6.0' versiyonla alınıp eklenmeli.
	
	Dockerfile:	
	FROM mcr.microsoft.com/dotnet/runtime:6.0
	WORKDIR /App*
	COPY bin/Release/net6.0/publish App/
	ENTRYPOINT ["dotnet","ConsoleApp.dll"]
	
	Docker Image oluşturma:	
	docker build -t dockerName [dockerfilepath]
	
	Docker Container oluşturma:
	docker create --name dockertestconsolecontainer dockertestconsoleapp
	
	Docker Container çalıştırma:
	docker start dockertestconsolecontainer
	
	Docker Container durdurma:
	docker stop dockertestconsolecontainer
	
	Docker Container çıktıyı görme:
	docker attach dockertestconsolecontainer
	
	Docker Image List:
	docker images
	
	Docker Container List:
	docker ps -a
