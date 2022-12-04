using Microsoft.AspNetCore.Mvc;

namespace SwaggerUITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        /// <summary>
        /// This is description of method 1. It includes some text which we want to use in another method.
        /// <br>This method uses <paramref name="ID"/> parameter</br>
        /// <list type="bullet">
        /// <item>Usage description step 1</item>
        /// <item>Usage description step 2</item>
        /// </list>
        /// </summary>
        /// <param name="ID"></param>
        [HttpGet("apiMethod1")]
        public void APIMethod1(int ID)
        {

        }

        /// <summary>
        /// <inheritdoc cref="APIMethod1(int)"/>
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="argument"></param>
        [HttpGet("apiMethod2")]
        public void APIMethod2(int ID, string argument)
        {

        }
    }
}