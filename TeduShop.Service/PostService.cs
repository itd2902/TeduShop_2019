using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Delete(int id);

        void Update(Post post);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPasing(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByTagPasing(string tag, int page, int pageSize, out int totalRow);

        Post GetById(int id);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        //hàm chỉ lấy ra bài viết
        //public IEnumerable<Post> GetAll()
        //{
        //    return _postRepository.GetAll();
        //}
        //hàm lấy ra bài viết nhưng lấy ra cả thể loại của bài viết
        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryId == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPasing(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTagPasing(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPasing(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}