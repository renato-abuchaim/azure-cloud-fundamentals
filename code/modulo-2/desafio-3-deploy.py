# Leitura do status do serviço via entrada padrão
status = input().strip()  # Entrada do usuário

# Lógica condicional
if status == "deploy":
    print("Deployment successful")
elif status == "rollback":
    print("Rollback executed")
elif status == "error":
    print("Error detected")
else:
    print("Manual review required")
