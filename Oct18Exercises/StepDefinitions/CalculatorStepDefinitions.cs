using NUnit.Framework;

namespace Oct18Exercises.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        string p1, p2;
        int p0;
        string hq;
        int qh;
        [Given("the userid is (.*)")]
        public void GivenTheUseridIs(string userid)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            p1 = userid;
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string password)
        {
            //TODO: implement arrange (precondition) logic

            p2 = password;
        }

        [When("successful login")]
        public void WhenSuccessfulLogin()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{p1}{p2}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            string actual = null;
            //TODO: implement assert (verification) logic
            if((p1== "testuser_1" && p2 == "Test@123")|| (p1=="testuser_2" && p2 == "Test@153"))
            {
                actual = result;
                
            }
            else
            {
                actual = "Erroneous";
            }

            Assert.AreEqual(result, actual); 
        }
        [Given("the input is (.*)")]
        
        public void GivenTheInputIs(int input)
        {
            p0 = input;
        }
        [When("successful logout")]
        public void WhenSuccessfulLogout()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{p0}");
        }
        [Then("the result1 should be (.*)")]
        public void ThenTheResult1ShouldBe(string result)
        {
            string actual=null;
            if (p0 == 1)
            {
                actual = result;

            }
            else
            {
                actual = "User was not logged in";
            }
            Assert.AreEqual(result, actual);
        }
        [Given("the prodname is (.*)")]

        public void GivenTheProdnameIs(string input)
        {
            hq = input;
        }
        [Given("the quantity is (.*)")]

        public void GivenTheQuantityIs(int input)
        {
            qh = input;
        }

        [When("Added to the cart")]
        public void WhenAddedToTheCart()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{hq}{qh}");
        }
        [Then("the output should be (.*)")]
        public void ThenTheOutputShouldBe(string result)
        {
            string actual = null;
            if (qh>0 && hq!=null)
            {
                actual = result;

            }
            else
            {
                actual = "Not perfect to be added in";
            }
            Assert.AreEqual(result, actual);
        }

    }
}