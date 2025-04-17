try:
    n = int(input("Introduce un número entero: "))
    #condicional if para validar que el número sea entero
    if n > 0:  
        factorial = 1
        for i in range(n):
            factorial *= i + 1
        print("El factorial de", n, "es", factorial)
    else:
        print("El número debe ser entero positivo.")
except ValueError:
    print("Debes introducir un número entero.")