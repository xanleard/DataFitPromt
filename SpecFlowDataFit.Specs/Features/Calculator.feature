Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
	In order to avoid silly mistakes
	As a math idiot
	I *want* to be told the **sum** of ***two*** numbers

Link to a feature: [Calculator](SpecFlowDataFit.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	Scenario: Total factura
    Given  un primer valor entero 10
    When  la factura sea mayor cero
    Then el valor es 10

	Scenario: Cantidad de productos
    Given  un primer valor entero -1
    When  Productos mayoa cero
    Then el valor es -1

	Scenario: Clientes activos
    Given  El cliene  esta  "Activo"
    When  el usuario decida realizar operacion.
    Then el valor resultado es  1

		Scenario: Producto activos
    Given  El producto  esta  "Inactivo"
    When  el usuario decida realizar operacion.
    Then el valor resultado es  0

        	Scenario: Validar nombre Clientes 
    Given  El nombre del cliene  es  "ClienteTest"
    When  el usuario decida realizar operacion cliente.
    Then el valor resultado es  1
     	Scenario: Validar nombre Producto 
    Given  El nombre del Producto  es  ""
    When  el usuario decida realizar operacion.
    Then el valor resultado es  0