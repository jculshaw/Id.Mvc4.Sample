using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Id.Mvc4.Sample.Controllers
{
    public class SearchController : ApiController
    {
        Models.LibraryEntities libraryDB = new Models.LibraryEntities();

        public IEnumerable<Models.Book> GetBySearch([FromUri]ViewModels.SearchCriteria criteria)
        {
            string authorCriteria = string.Empty;
            string titleCriteria = string.Empty;

            if (!string.IsNullOrWhiteSpace(criteria.Author)) authorCriteria = criteria.Author.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(criteria.Title)) titleCriteria = criteria.Title.ToLower().Trim();

            IQueryable<Models.Book> results = libraryDB.Books;

            if (criteria.FormatId != 0)
                results = results.Where(b => b.Format.FormatId == criteria.FormatId);
            if (criteria.SubjectId != 0)
                results = results.Where(b => b.Subject.SubjectId == criteria.SubjectId);
            if (titleCriteria != string.Empty)
                results = results.Where(b => b.Title.ToLower().Contains(titleCriteria));
            if (authorCriteria != string.Empty)
            {
                results = (from book in results
                           from author in book.Authors
                           where author.Name.ToLower().Contains(authorCriteria)
                           select book).Distinct();
            }

            results = results.Include(b => b.Authors).Include(b => b.Format).Include(b => b.Subject).OrderBy(b => b.Title);

            return results.ToList();

        }
    }
}
