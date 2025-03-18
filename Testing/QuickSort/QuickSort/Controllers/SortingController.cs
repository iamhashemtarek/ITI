using Microsoft.AspNetCore.Mvc;
using QuickSort.Models;
using QuickSort.Services;

namespace QuickSort.Controllers
{
    public class SortingController : Controller
    {
        private readonly SortingService _sortingService;

        public SortingController(SortingService sortingService)
        {
            _sortingService = sortingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SortingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Parse input numbers
            int[] numbers = _sortingService.ParseNumbers(model.Numbers);

            if (numbers.Length == 0)
            {
                ModelState.AddModelError("Numbers", "Please enter valid numbers separated by commas");
                return View(model);
            }

            var viewModel = new SortingViewModel
            {
                OriginalNumbers = numbers
            };

            // Perform sorting based on selected algorithm
            switch (model.Algorithm)
            {
                case "bubble":
                    var bubbleResult = _sortingService.BubbleSort(numbers);
                    viewModel.SortedNumbers = bubbleResult.sortedArray;
                    viewModel.AlgorithmName = "Bubble Sort";
                    viewModel.ExecutionTime = bubbleResult.executionTime;
                    break;

                case "quick":
                    var quickResult = _sortingService.QuickSort(numbers);
                    viewModel.SortedNumbers = quickResult.sortedArray;
                    viewModel.AlgorithmName = "Quick Sort";
                    viewModel.ExecutionTime = quickResult.executionTime;
                    break;

                default:
                    ModelState.AddModelError("Algorithm", "Invalid sorting algorithm selected");
                    return View(model);
            }

            return View("Result", viewModel);
        }
    }
}
