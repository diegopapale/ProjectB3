# ProjectB3


# Variáveis para os projetos
API_PROJECT = C:\Repos\projectb3\ProjectB3_API/ProjectB3_API.csproj
TEST_PROJECT = C:\Repos\projectb3\ProjectB3.Tests/ProjectB3.Tests.csproj
ANGULAR_PROJECT = C:\Repos\projectb3\ProjectB3_Angular

# Comandos para o .NET
DOTNET = dotnet

# Comandos para o Angular
ANGULAR = npm

# Alvo padrão
all: build

# Regra para construir o projeto API
build-api:
	$(DOTNET) build $(API_PROJECT)

# Regra para executar os testes
test:
	$(DOTNET) test $(TEST_PROJECT)

# Regra para construir o projeto Angular
build-angular:
	cd $(ANGULAR_PROJECT) && $(ANGULAR) run build

# Regra para limpar todos os projetos
clean:
	$(DOTNET) clean $(API_PROJECT)
	$(DOTNET) clean $(TEST_PROJECT)
	cd $(ANGULAR_PROJECT) && $(ANGULAR) run clean

# Regra para construir todos os projetos
build: build-api build-angular

# Regra para construir e testar
build-and-test: build test

.PHONY: all build-api test build-angular clean build build-and-test