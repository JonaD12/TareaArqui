try:
    print("Bienvenido al sistema de calculo de fuerza para iniciar presione Si, o No para salir")
    x = input()
    while x == "Si":
        print("Por Favor ingresa la fuerza")
        fuerza = float(input())
        peso = round(fuerza/9.8, 2)
        print(f"el peso de la maquina es: {peso} Kg")
        print("Desea Continuar otra operacion (Si para Continuar o No para salir?")
        x = input()
    print("Usted a utilizado el sistema de calculo de fuerza esperamos le halla sido de utilidad")
    cerrar = input()
except ValueError:
    print("Porfavor ingrese solo numeros")
    SALIDA = input()