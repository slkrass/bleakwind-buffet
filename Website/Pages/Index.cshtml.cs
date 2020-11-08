using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// The menu items to be displayed on the index page
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered item type
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Category { get; set; }

        /// <summary>
        /// The filtered calories maximum
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMax { get; set; } = 1000;

        /// <summary>
        /// The filtered calories minimum
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int CaloriesMin { get; set; }

        /// <summary>
        /// The filtered price maximum
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 10;

        /// <summary>
        /// The filtered price minimum
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; }

        /// <summary>
        /// Gets the search results for displaying on the page
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.Search(SearchTerms);//MenuItems,
            MenuItems = Menu.FilterByCategory(MenuItems, Category);//Add a IEnumerable<string>
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
