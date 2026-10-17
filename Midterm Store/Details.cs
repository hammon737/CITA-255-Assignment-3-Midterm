using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Store
{
    internal class Details
    {
        public static ImageSource[] ProductImage =
        {
            "healthpotion.png",
            "lovepotion.png",
            "gravitypotion.png",
            "senseenhancementpotion.png",
        };
        public static string[] ProductTitle =
        {
            "Health Potion",
            "Love Potion",
            "Gravity Potion",
            "Sensory Enhancement Potion"
        };

        public static double[] Prices =
        {
            15.25,
            25.99,
            13.99,
            12.45
        };

        public static string[] Description1 =
        {
            "This potion will heal any physical injuries.",
            "This is a love potion. Use with caution. Potionsellers Inc is not liable for any 'crimes of passion' this may cause.",
            "This potion manipulates the gravity around the user. Users should ensure that they are in a contained space before consuming.",
            "This potion increases the user's senses. Users can hear a pin drop from a mile away."
        };

        public static string[] Description2 =
        {
            "Warning: Do not attempt to use this potion to cure mental illness. It will not work.",
            " ",
            "Made with 100% real penguin feathers.",
            "Side effects may include: visual and auditory hallucinations, mild vertigo, eye strain, waves of nausea, possible death, and minor headaches."
        };

        public static string[] Stock =
        {
            "In Stock",
            "Out of Stock",
            "In Stock",
            "In Stock"
        };
    }
}
