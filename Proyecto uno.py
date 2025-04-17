def suma_pares_limite(limite):
    suma = 0
    for i in range(limite + 1):  # Suma hasta el límite inclusive
        if i % 2 == 0:  # Verificar si el número es par
            suma += i
    return suma

# Solicitar al usuario ingresar un número entero positivo
try:
    limite = int(input("Ingrese un número entero positivo: "))
    if limite < 0:
        print("Por favor, ingrese un número entero positivo.")
    else:
        resultado = suma_pares_limite(limite)
        print(f"La suma de los números pares hasta {limite} es: {resultado}")
except ValueError:
    print("Por favor, ingrese un número entero válido.")
