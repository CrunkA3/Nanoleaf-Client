using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
	/// <summary>
	/// Layout info on a specific panel
	/// </summary>
	[Serializable]
	public class PanelLayout
	{
		/// <summary>
		/// Unique panel ID
		/// </summary>
		public int PanelId { get; set; }
		/// <summary>
		/// X coordinate
		/// </summary>
		public int X { get; set; }

		/// <summary>
		/// Y coordinate
		/// </summary>
		[DefaultValue(10)]
		public int Y { get; set; } = 10;

		/// <summary>
		/// Orientation
		/// </summary>
		public int O { get; set; }
		
		/// <summary>
		/// Shape type, should probably be an enum
		/// </summary>
		public int ShapeType { get; set; }
	}
}