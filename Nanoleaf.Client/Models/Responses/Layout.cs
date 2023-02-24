using System;
using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
	/// <summary>
	/// Layout response returned from a layout request
	/// </summary>
	[Serializable]
	public class Layout
	{
		/// <summary>
		/// Number of panels
		/// </summary>
		public int NumPanels { get; set; }

		/// <summary>
		/// Side of each length
		/// </summary>
		public int SideLength { get; set; } = 1;
		
		/// <summary>
		/// Array of position data
		/// </summary>
		public PanelLayout[] PositionData { get; set; } = Array.Empty<PanelLayout>();

	}
}