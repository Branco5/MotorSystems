using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotorSystemsApp.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests
{
    [TestClass]
    public class ApiTests
    {
        private HttpClient httpClient;

        public ApiTests()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            httpClient = webAppFactory.CreateDefaultClient();
        }

        [TestMethod]
        public async Task TestGetProduct()
        {
            HttpResponseMessage response = await httpClient.GetAsync("api/Products/1");            
            Assert.IsNotNull(response);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task TestPostVehicle()
        {
            Vehicle v = new Vehicle
            {
                Plate = "ER-09-IO",
                Brand = "Mercedes",
                Client = null,
                Model = "Z1",
                Type = VehicleType.Car
            };
            var vehicleJson = JsonConvert.SerializeObject(v);
            var vehicleStringContent = new StringContent(vehicleJson, UnicodeEncoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/Vehicles", vehicleStringContent);
            Assert.IsNotNull(response);
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        [TestMethod]
        public async Task TestDeleteVehicle()
        {
            var response = await httpClient.DeleteAsync("api/Vehicles/ER-09-IO");
            Assert.IsNotNull(response);
            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, response.StatusCode);
        }

        [TestMethod]
        public async Task TestGetAllServices()
        {
            HttpResponseMessage response = await httpClient.GetAsync("api/Services");
            Assert.IsNotNull(response);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task TestGetOrder()
        {
            HttpResponseMessage response = await httpClient.GetAsync("api/Orders/1");
            Assert.IsNotNull(response);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}