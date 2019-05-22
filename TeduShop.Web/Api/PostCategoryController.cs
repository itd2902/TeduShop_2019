using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;
using TeduShop.Web.Infrastruture.Core;
using TeduShop.Web.Models.ViewModels;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        //Post
        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategory = Mapper.Map<PostCategory>(postCategoryViewModel);
                    postCategory = _postCategoryService.Add(postCategory);
                    _postCategoryService.SaveChange();
                    response = request.CreateResponse(HttpStatusCode.Created, postCategory);
                }
                return response;
            });
        }

        //Put
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategory = Mapper.Map<PostCategory>(postCategoryViewModel);
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.SaveChange();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        //Delete
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.SaveChange();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        //Get
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var lstCategory = _postCategoryService.GetAll();
                var lstCategoryViewModel = Mapper.Map<IEnumerable<PostCategoryViewModel>>(lstCategory);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, lstCategoryViewModel);
                return response;
            });
        }
    }
}