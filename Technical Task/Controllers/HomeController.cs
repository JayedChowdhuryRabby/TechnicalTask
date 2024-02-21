using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Technical_Task.Models;

namespace Technical_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly TechnicalDb _db = new TechnicalDb();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult GenerateTextBoxes(int count)
        {
            var textBoxes = Enumerable.Range(1, count)
                .Select(i => new TextBoxModel { InputNumber = i })
                .ToList();
            return PartialView("_TextBoxesPartial", textBoxes);
        }

        [HttpPost]
        public PartialViewResult CalculateTotalSelected(List<TextBoxModel> textBoxes)
        {
            var totalSum = textBoxes.Where(tb => tb.IsSelected).Sum(tb => tb.InputNumber);

            return PartialView("_TotalSelectedCountPartial", totalSum);
        }

        [HttpPost]
        public void CalculateTotalSum(int totalSum)
        {
            // Save total sum in the database
            var newTotalSum = new TotalSum { SumValue = totalSum };
            _db.TotalSums.Add(newTotalSum);
            _db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
