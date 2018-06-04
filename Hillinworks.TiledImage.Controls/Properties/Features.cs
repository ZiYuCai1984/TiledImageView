﻿namespace Hillinworks.TiledImage.Properties
{
	internal static class Features
	{

		/// <summary>
		/// Inflate tile render regions by 0.5 pixels to compensate possible gaps between them
		/// </summary>
		public static bool CompensateForTileGaps { get; } = true;

		/// <summary>
		/// Put the image in the center of the viewport if it's smaller
		/// </summary>
		public static bool CentralizeImageIfSmallerThanViewport { get; } = true;

		#region Debug-only features

#if DEBUG

		/// <summary>
		///     Save the ghost tiledImage to a PNG file for debug purpose.
		/// </summary>
		public static bool SaveGhostImage { get; } = false;

		/// <summary>
		///     The path where the ghost tiledImage should be saved.
		/// </summary>
		public static string GhostImageSavePath { get; } = @"ghostimage.png";

		/// <summary>
		///     Draw status (failed, canceled, load progress etc.) and bounding boxes of tiles that haven't been loaded.
		/// </summary>
		public static bool DrawTileStatus { get; } = false;



#endif

		#endregion
	}
}