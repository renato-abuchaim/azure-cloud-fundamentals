# Lê a necessidade do time via entrada padrão
necessidade = input().strip().lower()

# Mapeamento das necessidades para serviços Azure
if necessidade == "armazenar arquivos":
    print("Azure Blob Storage")

elif necessidade == "armazenar dados relacionais":
    print("Azure SQL Database")

elif necessidade == "executar codigo sob demanda":
    print("Azure Functions")

elif necessidade == "hospedar sistemas operacionais":
    print("Azure Virtual Machines")

else:
    print("Servico desconhecido")