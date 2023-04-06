﻿using Moq.AutoMock;
using CleanArchitecture.Application.Products.Queries.GetProductsList;
using NUnit.Framework;

namespace CleanArchitecture.Service.Products
{
    [TestFixture]
    public class ProductsControllerTests
    {
        private ProductsController _controller;
        private AutoMocker _mocker;

        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMocker();

            _controller = _mocker.CreateInstance<ProductsController>();
        }

        [Test]
        public void TestGetProductsListShouldReturnListOfProducts()
        {
            var product = new ProductModel();

            _mocker.GetMock<IGetProductsListQuery>()
                .Setup(p => p.Execute())
                .Returns(new List<ProductModel> { product });

            var results = _controller.Get();

            Assert.That(results,
                Contains.Item(product));
        }
    }
}