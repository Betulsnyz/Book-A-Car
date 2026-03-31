using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        public List<TagCloud> GetTagCloudByBlogId(int id);
    }
}
