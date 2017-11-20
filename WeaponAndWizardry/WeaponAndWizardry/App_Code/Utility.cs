using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.App_Code
{
    public static class Utility
    {
        /// <summary>
        /// Creates a deep copy of the Image object
        /// </summary>
        /// <param name="image">The image to copy</param>
        /// <returns>A copy of the image</returns>
        public static Image CopyImage(Image image)
        {
            Image copy = new Image();
            copy.Style["position"] = image.Style["position"].ToString();
            copy.Style["z-index"] = image.Style["z-index"].ToString();
            copy.Style["left"] = image.Style["left"].ToString();
            copy.Style["top"] = image.Style["top"].ToString();
            copy.Width = new Unit(image.Width.Value);
            copy.Height = new Unit(image.Height.Value);
            copy.ImageUrl = image.ImageUrl;
            return copy;
        }
    }
}