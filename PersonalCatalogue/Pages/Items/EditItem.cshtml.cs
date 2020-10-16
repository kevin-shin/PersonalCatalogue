using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalCatalogue.Data;

namespace PersonalCatalogue.Pages.Items
{
    public class EditItemModel : PageModel
    {
        [BindProperty]
        public Data.Item Item { get; set; }
        private IItemData _itemData { get; set; }

        public EditItemModel(IItemData itemData)
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Item = _itemData.Update(Item);
                _itemData.Commit();
                TempData["Message"] = "Updated Item.";
                return RedirectToPage("./Detail", new { itemId = Item.ItemId});
            }

            return Page();
        }

    }
}
