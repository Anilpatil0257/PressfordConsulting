using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PressfordConsultingApi.Dtos;
using PressfordConsultingApi.Models;
using PressfordConsultingApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressfordConsultingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private IMapper _mapper;
        private PressfordConsultingDbContext _context;


        public ArticleController(IMapper mapper, PressfordConsultingDbContext context)
        {

            _mapper = mapper;
            _context = context;
        }
        //GET /api/GetArticles
        [HttpGet]
        [Route("/Article")]
        public IEnumerable<ArticleDto> GetArticles()
        {
            
            var articleList = _context.Articles.ToList();
            return _mapper.Map<IEnumerable<ArticleDto>>(articleList);
           


        }

        //GET /api/GetArticles/1
        [HttpGet]
        [Route("/Article/{id}")]
         public ArticleDto GetArticle(int id)
        {
            var article = _context.Articles.SingleOrDefault(a => a.articleId == id);
            if (article == null)
                StatusCode(404, "Articlenotfound");
            // return article;
            return _mapper.Map<ArticleDto>(article);

        }
        //Post /api/Article
        [HttpPost]
        public ArticleDto CreateArticle(ArticleDto articleDto)
        {
            if (!ModelState.IsValid)
                StatusCode(400, "Bad Request");
            var article = _mapper.Map<ArticleDto, Article>(articleDto);
            _context.Articles.Add(article);
            _context.SaveChanges();
            article.articleId = articleDto.articleId;
            return _mapper.Map<ArticleDto>(article);
            //return Created(Request.RequestUri +"/" )
        }
        //Put /api/Article
        [HttpPut]
        public void UpdateArticle(int id, Article article)
        {
            if (!ModelState.IsValid)
                StatusCode(400, "Bad Request");
            var articleInDb = _context.Articles.SingleOrDefault(a => a.articleId == id);
            if (articleInDb == null)
                StatusCode(404, "Articlenotfound");
              _mapper.Map<ArticleDto>(article);
            _context.SaveChanges();

        }
        //DELETE /api /article/1

        [HttpDelete]
        public void DeleteArticle(int id)
        {
            var articleInDb = _context.Articles.SingleOrDefault(a => a.articleId == id);
            if (articleInDb == null)
                StatusCode(404, "Articlenotfound");
            _context.Articles.Remove(articleInDb);
            _context.SaveChanges();
        }
    }
}
