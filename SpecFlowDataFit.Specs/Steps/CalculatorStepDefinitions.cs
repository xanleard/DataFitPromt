using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowDataFit.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Validation _validation = new Validation();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _validation.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _validation.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _validation.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Given(@"un primer valor entero (.*)")]
        public void GivenUnPrimerValorEntero(int number)
        {
            _validation.FirstNumber = number;
        }

        [When(@"la factura sea mayor cero")]
        public void WhenLaFacturaSeaMayorCero()
        {
            _result = _validation.Add();
        }

        [When(@"Productos mayoa cero")]
        public void WhenProductosMayoaCero()
        {
            _result = _validation.ProductoValidacion();
        }


        [Then(@"el valor es (.*)")]
        public void ThenElValorEs(int result)
        {
            _result.Should().Be(result);
        }


        //clientes
        [Given(@"El cliene  esta  ""(.*)""")]
        public void GivenElClieneEsta(string p0)
        {
            _validation.enables = p0;
        }


        //Prodcutos activos 
        [Given(@"El producto  esta  ""(.*)""")]
        public void GivenElProductoEsta(string p0)
        {
            _validation.enables = p0;
        }

        [Given(@"El nombre del cliene  es  ""(.*)""")]
        public void GivenElNombreDelClieneEs(string p0)
        {
            _validation.enables = p0;
        }

        [Given(@"El nombre del Producto  es  ""(.*)""")]
        public void GivenElNombreDelProductoEs(string p0)
        {
            _validation.enables = p0;
        }


        [When(@"el usuario decida realizar operacion\.")]
        public void WhenElUsuarioDecidaRealizarOperacion_()
        {
            _result = _validation.ValidarClienteActivo();
        }

        [Then(@"el valor resultado es  (.*)")]
        public void ThenElValorResultadoEs(int result)
        {
            _result.Should().Be(result);
        }




    }
}
