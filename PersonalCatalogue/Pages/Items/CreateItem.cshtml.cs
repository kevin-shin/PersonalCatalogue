using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalCatalogue.Data;

namespace PersonalCatalogue.Pages.Items
{
    public class CreateItemModel : PageModel
    {
        [BindProperty]
        public Item Item { get; set; }
        private IItemData _itemData { get; set; }

        public CreateItemModel(IItemData itemData)
        {
            _itemData = itemData;
        }

        public IActionResult OnGet()
        {
            Item = new Item();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Item = _itemData.Create(Item);
                _itemData.Commit();
                TempData["Message"] = "Item Created.";
                return RedirectToPage("./ItemDetail", new { itemId = Item.Id });
            }

            return Page();
        }
    }
}