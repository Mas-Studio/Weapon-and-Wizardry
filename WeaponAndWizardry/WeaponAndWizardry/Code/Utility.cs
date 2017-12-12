using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Provides utility functions and properties used in this project.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Gets the url of the TempData folder
        /// </summary>
        public static string TempDataUrl { get; } = HttpContext.Current.Server.MapPath("~/TempData/");

        /// <summary>
        /// Gets the url of the PlayerSaveData folder
        /// </summary>
        public static string PlayerSaveDataUrl { get; } = HttpContext.Current.Server.MapPath("~/PlayerSaveData/");

        /// <summary>
        /// Creates a deep copy of the Image object
        /// Author:
        ///     Name: Jia Qi Lee (George) Date: 2017-11-15
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