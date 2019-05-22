using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService postCategoryService;
        private List<PostCategory> postCategories;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            postCategoryService = new PostCategoryService(_mockRepository.Object,_mockUnitOfWork.Object);
            postCategories = new List<PostCategory>()
            {
                new PostCategory(){ Id=1,Name="Quang",Status=true},
                new PostCategory(){ Id=2,Name="Quang",Status=true},
                new PostCategory(){ Id=3,Name="Quang",Status=true}
            };
        }
        //[TestMethod]
        //public void PostCategory_Service_GetAll()
        //{
        //    ///Setup method
        //    _mockRepository.Setup(m => m.GetAll(null)).Returns(postCategories);
        //    //call action
        //    var result=postCategoryService.GetAll() as List<PostCategory>;
        //    //compare
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(3, result.Count);
        //}
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            
            PostCategory category = new PostCategory();
            category.Id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;
            //_mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
            //{
            //    p.Id = 1;
            //    return p;
            //});
            var result=postCategoryService.Add(category);
            _mockUnitOfWork.Object.Commit();
            //Assert.IsNotNull(result); 
            //Assert.AreEqual(1, result.Id);
        }
    }
}
