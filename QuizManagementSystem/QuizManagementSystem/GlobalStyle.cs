using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem
{
    public class GlobalStyle
    {
        public static void Apply(Form form)
        {
            // Initialize MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form as MaterialForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Set the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // Primary color
                Primary.BlueGrey900, // Dark primary color
                Primary.BlueGrey500, // Light primary color
                Accent.LightBlue200, // Accent color
                TextShade.WHITE // Text color
            );
        }
    }
}
