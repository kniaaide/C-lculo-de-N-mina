# Cálculo de Nómina

Aplicación de escritorio desarrollada en C# y Windows Forms para calcular y mostrar la nómina de empleados mediante programación orientada a objetos.

## Descripción

El sistema permite registrar empleados de dos tipos: asalariados y empleados por horas. Cada empleado recibe un identificador automático y se genera un informe con el sueldo correspondiente.

## Funcionalidades

- Registro de empleados asalariados mediante sueldo mensual.
- Registro de empleados por horas mediante horas trabajadas y pago por hora.
- Cálculo polimórfico del sueldo.
- Generación de reportes en pantalla.
- Validación de datos introducidos por el usuario.
- Limpieza de la lista y de los campos del formulario.

## Diseño del proyecto

- `Empleado`: clase abstracta base.
- `EmpleadoAsalariado`: calcula el sueldo mensual fijo.
- `EmpleadoPorHoras`: calcula el sueldo multiplicando horas por pago por hora.
- `Form1`: interfaz gráfica y gestión de eventos.

## Tecnologías

- C#
- Windows Forms
- .NET
- Programación orientada a objetos, herencia y polimorfismo

## Ejecución

1. Abre la solución en Visual Studio.
2. Compila el proyecto.
3. Ejecuta la aplicación.
4. Selecciona el tipo de empleado, captura los datos y presiona **Agregar**.

## Autora

Kenia Aide Martínez Vallesteros
