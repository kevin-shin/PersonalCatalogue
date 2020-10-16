using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalCatalogue.Data;

namespace PersonalCatalogue.Pages.Items
{
    public class ItemDetailModel : PageModel
    {
        public Data.Item Item { get; set; }

        [TempData]
        public string Message { get; set; }
        private IItemData _itemData {get;set;}

        public ItemDetailModel(IItemData itemData)
        {
            _itemData = itemData;
        }

        public IActionResult OnGet(int itemId)
        {
            Item = _itemData.GetItemById(itemId);

            if (Item == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}
