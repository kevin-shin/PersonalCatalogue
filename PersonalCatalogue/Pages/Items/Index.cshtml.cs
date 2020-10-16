using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalCatalogue.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PersonalCatalogue.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IItemData _itemData;
        public IEnumerable<Data.Item> _items;

        [BindProperty(SupportsGet = true)] // modelBinding
        public string SearchTerm { get; set; }

        public IndexModel(IConfiguration configuration, IItemData itemData)
        {
            this._configuration = configuration;
            this._itemData = itemData;
        }

        public void OnGet()
        {
            _items = _itemData.GetItems(SearchTerm);
        }
    }
}
