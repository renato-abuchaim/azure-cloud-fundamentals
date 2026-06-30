# 🚀 Azure App Service e Deploy de Aplicações

## 📖 Introdução

Publicar uma aplicação é uma das etapas mais importantes do ciclo de desenvolvimento de software. Após implementar e testar uma solução localmente, é necessário disponibilizá-la em um ambiente acessível aos usuários.

Na Microsoft Azure, um dos principais serviços utilizados para esse processo é o **Azure App Service**, responsável por hospedar APIs, aplicações Web e diversos outros tipos de aplicações.

---

# 🎯 Objetivos

Ao final deste conteúdo você será capaz de compreender:

- O que é Deploy;
- O que é Azure App Service;
- Como publicar APIs;
- Como publicar aplicações Web;
- Como integrar uma aplicação ao Azure SQL Database;
- Como configurar Strings de Conexão;
- Como realizar o Publish utilizando o Visual Studio;
- Como utilizar o Portal Azure;
- Conceitos iniciais de CI/CD.

---

# 🚀 O que é Deploy?

Deploy é o processo de disponibilizar uma aplicação para utilização em um ambiente acessível aos usuários.

Durante o desenvolvimento, a aplicação normalmente é executada localmente. Após sua conclusão, ela é publicada em um servidor ou serviço em nuvem.

Na Microsoft Azure esse processo geralmente é realizado utilizando o Azure App Service.

<p align="center">
    <img src="../../images/module-2/deploy-overview.png" alt="Deploy Overview" width="650">
</p>

---

# ☁️ Azure App Service

O Azure App Service é um serviço PaaS (Platform as a Service) que permite hospedar aplicações sem a necessidade de administrar servidores.

Entre seus principais recursos estão:

- Hospedagem de APIs REST;
- Hospedagem de aplicações Web;
- Escalabilidade automática;
- Balanceamento de carga;
- Monitoramento integrado;
- Integração com GitHub;
- Deploy contínuo.

---

# 🌐 Publicação de APIs

Uma API ASP.NET pode ser publicada diretamente no Azure utilizando o Visual Studio.

Durante a publicação são criados automaticamente recursos como:

- Resource Group;
- App Service;
- Plano de Hospedagem;
- Endpoint público.

Após o deploy, a API fica disponível através de uma URL pública.

Exemplo:

```text
https://minha-api.azurewebsites.net
```

---

# 💻 Publicação de Aplicações Web

Além de APIs, o Azure App Service também suporta aplicações Web desenvolvidas em diversas linguagens.

O processo de publicação é praticamente o mesmo utilizado para APIs REST.

---

# 🗄️ Azure SQL Database

Aplicações hospedadas no Azure normalmente utilizam bancos de dados para persistência das informações.

O Azure SQL Database oferece:

- Alta disponibilidade;
- Backups automáticos;
- Escalabilidade;
- Segurança;
- Administração simplificada.

Durante sua criação normalmente são configurados:

- Nome do servidor;
- Nome do banco;
- Usuário administrador;
- Firewall;
- Permissões de acesso.

---

# 🔗 Strings de Conexão

Após criar o banco de dados é necessário configurar a Connection String utilizada pela aplicação.

Exemplo:

```text
Server=tcp:meuservidor.database.windows.net;
Database=MinhaBase;
User ID=usuario;
Password=********;
```

Essas configurações podem ser alteradas diretamente pelo Portal Azure através das Application Settings.

---

# 🚀 Publicando com o Visual Studio

O processo de publicação normalmente consiste em:

1. Publish
2. Azure
3. Azure App Service
4. Criar ou selecionar Resource Group
5. Criar App Service
6. Configurar Azure SQL
7. Publish

Após alguns minutos a aplicação estará disponível na nuvem.

---

# 🌎 Portal Microsoft Azure

Após a publicação, toda administração pode ser realizada através do Portal Azure.

É possível:

- Visualizar logs;
- Configurar variáveis de ambiente;
- Alterar Connection Strings;
- Reiniciar a aplicação;
- Escalar recursos;
- Monitorar consumo.

---

# ⚙️ Configuração de Ambiente

Cada ambiente pode possuir configurações próprias.

Exemplos:

- Desenvolvimento
- Homologação
- Produção

Na Azure essas configurações ficam armazenadas nas **Application Settings**, evitando alterações diretamente no código.

---

# 🔄 Introdução ao CI/CD

Uma das maiores vantagens da computação em nuvem é a possibilidade de automatizar o deploy.

O fluxo normalmente ocorre da seguinte forma:

```text
Código
    ↓
GitHub
    ↓
GitHub Actions
    ↓
Azure App Service
```

Esse processo reduz erros manuais e agiliza novas publicações.

---

# 🏗️ Arquitetura Demonstrada

Durante o laboratório foi utilizada uma arquitetura semelhante à apresentada abaixo.

<p align="center">
    <img src="../../images/module-2/deployment-architecture.png" alt="Deployment Architecture" width="900">
</p>

A arquitetura demonstra:

- Usuários acessando a aplicação via navegador;
- Aplicação Web hospedada no Azure App Service;
- API REST responsável pelas regras de negócio;
- Azure SQL Database realizando a persistência dos dados.

---

# 📚 Resumo

Neste documento foram apresentados os principais conceitos relacionados ao deploy de aplicações utilizando Microsoft Azure.

Entre os assuntos estudados estão:

- Deploy;
- Azure App Service;
- Publicação de APIs;
- Publicação de aplicações Web;
- Azure SQL Database;
- Strings de Conexão;
- Configuração de Ambiente;
- Portal Azure;
- Introdução ao CI/CD.