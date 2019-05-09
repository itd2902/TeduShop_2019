using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.Repositorytest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_AddCreate()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "Test postCategory";
            postCategory.Alias = "Test-postCategory";
            postCategory.Status = true;

            var result=objRepository.Add(postCategory);
            unitOfWork.Commit();
            //kiểm thử
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Id);
        }
    }
}
