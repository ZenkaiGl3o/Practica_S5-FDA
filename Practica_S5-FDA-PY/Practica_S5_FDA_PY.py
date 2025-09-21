def ejer1():
    producto = 27

    print("Ingrese la cantidad de productos a llevar")
    print("(Precio por unidad: 27)")
    cantidad_producto = int(input("----------> "))

    print("Ingrese su codigo de descuento")
    print("1 (Estudiante)")
    print("2 (Empleado)")
    print("3 (Cliente Frecuente)")
    codigo_cliente = int(input("----> "))

    if codigo_cliente == 1:
       tipo_cliente = "Estudiante"
    elif codigo_cliente == 2:
       tipo_cliente = "Empleado"
    elif codigo_cliente == 3:
       tipo_cliente = "Cliente Frecuente"
    else:
       tipo_cliente = "Sin descuento"

    precio_sin_descuento = cantidad_producto * producto

    if precio_sin_descuento >= 500:
      descuento1 = precio_sin_descuento * 0.05
    else:
      descuento1 = 0

    if codigo_cliente == 1:
      descuento2 = descuento1 + (precio_sin_descuento * 0.10)
    elif codigo_cliente == 2:
      descuento2 = descuento1 + (precio_sin_descuento * 0.15)
    elif codigo_cliente == 3:
      descuento2 = descuento1 + (precio_sin_descuento * 0.20)
    else:
      descuento2 = 0

    precio_final = round(precio_sin_descuento - descuento2, 2)

    print(f"El total a pagar es: {precio_final}")

import math
def ejer2():
    nota = int(input("Ingrese una nota (0-20): "))

    if nota < 0 or nota > 20:
      print("Error: la nota debe estar entre 0 y 20.")
    else:
      if 0 <= nota <= 10:
        clasificacion = "Desaprobado"
      elif 11 <= nota <= 13:
        clasificacion = "Regular"
      elif 14 <= nota <= 17:
        clasificacion = "Bueno"
      else:  
        clasificacion = "Excelente"

    print("Clasificacion:", clasificacion)

    if nota >= 14 and nota % 2 == 0:
        print("Buen desempeno con nota par")
    if nota % 2 != 0 or nota < 11:
        print("Necesita reforzar")

    raiz = round(math.sqrt(nota), 1)
    cubo = nota ** 3

    print("Raiz cuadrada de la nota:", raiz)
    print("Potencia al cubo de la nota:", cubo)



ejer2()

