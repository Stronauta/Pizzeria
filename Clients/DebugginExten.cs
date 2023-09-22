using System.Text.Json;

namespace PizzeriaPlace.Clients
{
	public static class ExtDepuracion
	{
		private static JsonSerializerOptions opti = new JsonSerializerOptions { WriteIndented = true };
		public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, opti);
	}
}
