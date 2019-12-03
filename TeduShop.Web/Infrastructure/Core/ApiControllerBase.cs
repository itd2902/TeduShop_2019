using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this.errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage request,Func<HttpResponseMessage> func)
        {
            HttpResponseMessage response = null;
            try
            {
                response = func.Invoke();
            }
            //báo lỗi validate
            catch(DbEntityValidationException ex)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    //Trace.wriline  sẽ ra cửa sổ output
                    //C# 6 mới nhất không còn hỗ trợ string format nên code như dưới
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors.");
                    //hỗ trợ các phiên bản cũ
                    //Trace.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors.", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\",Error : \"{ve.ErrorMessage}\"");
                    }
                }
            }
            catch(DbUpdateException dbEx)
            {
                LogError(dbEx);
                response = request.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.BadRequest,ex.Message);
            }

            return response;
        }

        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                errorService.Add(error);
                errorService.Save();
            }
            catch
            {

                
            }
        }
    }
}
